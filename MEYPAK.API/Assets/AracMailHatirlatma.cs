using MEYPAK.Entity.IdentityModels;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.FormYetki;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Net;
using MEYPAK.Entity.PocoModels.ARAC;
using System.ComponentModel;
using System.Diagnostics;

namespace MEYPAK.API.Assets
{
    public static class AracMailHatirlatma
    {

        public static IApplicationBuilder AracMail(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var serviceProvider = scopedServices.ServiceProvider;



            var arac = serviceProvider.GetRequiredService<IAracServis>();
            var aracMuayene = serviceProvider.GetRequiredService<IAracMuayeneResimServis>();
            var aracSigorta = serviceProvider.GetRequiredService<IAracSigortaResimServis>();
            var aracKasko = serviceProvider.GetRequiredService<IAracKaskoResimServis>();
            TarihleriKontrol(arac, aracMuayene, aracSigorta, aracKasko);
            return app;
        }

        private static async Task<bool> SendMail( string to, string subject, string body, string from = "elizmeypak@elizmeypak.com")
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("mail.kurumsaleposta.com", 587))
                {
                    smtpClient.EnableSsl = false;
                    smtpClient.Credentials = new NetworkCredential("info@elizmeypak.com", ".Zqky791Z8H=:hB-");

                    using (MailMessage mailMessage = new MailMessage(from, to, subject, body))
                    {
                       await  smtpClient.SendMailAsync(mailMessage);
                    }
                }

                return true; // E-posta başarıyla gönderildiğinde true döndürülür
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"E-posta gönderimi sırasında bir hata oluştu: {ex.Message}");
                return false; // E-posta gönderimi sırasında bir hata oluştuğunda false döndürülür
            }
        }

        private static bool CheckDateThreshold(DateTime targetDate)
        {
            DateTime currentDate = DateTime.Now.Date;
            TimeSpan remainingDays = targetDate.Date - currentDate;

            if (remainingDays.Days == 3 || remainingDays.Days == 7)
            {
                return true;
            }

            return false;
        }

        private static PocoARAC AracGetir(IAracServis aracServis, int id)
        {
            return aracServis.Getir(x => x.id == id).FirstOrDefault();
        }

        private static void TarihleriKontrol(IAracServis aracServis, IAracMuayeneResimServis aracMuayene, IAracSigortaResimServis aracSigorta, IAracKaskoResimServis aracKasko)
        {
            MuayeneTarihKontrol(aracMuayene,aracServis);
            SigortaTarihKontrol(aracSigorta,aracServis);
            KaskoTarihKontrol(aracKasko, aracServis);
        }

        private static void MuayeneTarihKontrol(IAracMuayeneResimServis aracMuayeneServis,IAracServis aracServis)
        {
            List<PocoARACMUAYENERESIM> muayeneList = aracMuayeneServis.Listele();
            foreach (var item in muayeneList.Where(x => x.kayittipi == 0))
            {
                if (CheckDateThreshold(item.muayenebittar))
                {
                    var arac = AracGetir(aracServis, item.aracid);
                    SendMail("tunahankaya@meypak.com.tr",$"{arac.plaka} | Muayene Bitiyor!!",$"{arac.plaka} Plakalı Aracın Muayene Tarihi Yaklaştı Lütfen Kontrol Ediniz!");  
                }
            }
        }
        private static void SigortaTarihKontrol(IAracSigortaResimServis aracSigortaServis, IAracServis aracServis)
        {
            List<PocoARACSIGORTARESIM> muayeneList = aracSigortaServis.Listele();
            foreach (var item in muayeneList.Where(x => x.kayittipi == 0))
            {
                if (CheckDateThreshold(item.sigbittar))
                {
                    var arac = AracGetir(aracServis, item.aracid);
                    SendMail("tunahankaya@meypak.com.tr", $"{arac.plaka} | Sigorta Bitiyor!!", $"{arac.plaka} Plakalı Aracın {item.sigacenteadi} Acentesindeki {item.sigpoliceno} Poliçe Numaralı Sigorta Tarihi Bitmeye Yaklaştı Lütfen Kontrol Ediniz!");
                }
            }
        }
        private static void KaskoTarihKontrol(IAracKaskoResimServis aracKaskoServis, IAracServis aracServis)
        {
            List<PocoARACKASKORESIM> muayeneList = aracKaskoServis.Listele();
            foreach (var item in muayeneList.Where(x => x.kayittipi == 0))
            {
                if (CheckDateThreshold(item.kasbittar))
                {
                    var arac = AracGetir(aracServis, item.aracid);
                    SendMail("tunahankaya@meypak.com.tr", $"{arac.plaka} | Kasko Bitiyor!!", $"{arac.plaka} Plakalı Aracın {item.kasacenteadi} Acentesindeki {item.kaspoliceno} Poliçe Numaralı Kasko Tarihi Bitmeye Yaklaştı Lütfen Kontrol Ediniz!");
                }
            }
        }




    }
}
