using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET.Firma
{
    public partial class FCekSenetDurum : XtraForm
    {
        public FCekSenetDurum()
        {
            InitializeComponent();
            _firmaCekServis = new GenericWebServis<PocoFIRMACEKSB>();
            _firmaSenetServis = new GenericWebServis<PocoFIRMASENETSB>();
            _musteriCekServis = new GenericWebServis<PocoMUSTERICEKSB>();
            _musteriSenetServis = new GenericWebServis<PocoMUSTERISENETSB>();
        }
        GenericWebServis<PocoFIRMACEKSB> _firmaCekServis;
        GenericWebServis<PocoFIRMASENETSB> _firmaSenetServis;
        GenericWebServis<PocoMUSTERICEKSB> _musteriCekServis;
        GenericWebServis<PocoMUSTERISENETSB> _musteriSenetServis;

        private void FCekSenetDurum_Load(object sender, EventArgs e)
        {
            DateTime AyIlk = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime AySon = AyIlk.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            DateTime HaftaninIlkGunu, HaftaninSonGunu;
            DateTime dt = DateTime.Now;
            DateTime BirDahakiAyIlk = AyIlk.AddMonths(1);
            DateTime BirDahakiAySon = BirDahakiAyIlk.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);


            switch ((int)dt.DayOfWeek)
            {
                case 0:
                    HaftaninIlkGunu = dt.AddDays(-6);
                    HaftaninSonGunu = HaftaninIlkGunu.AddDays(1);
                    break;

                default:
                    HaftaninIlkGunu = dt.AddDays(1 - (int)dt.DayOfWeek);
                    HaftaninSonGunu = HaftaninIlkGunu.AddDays(6);
                    break;
            }

            HaftaninIlkGunu.AddHours(-dt.Hour).AddMinutes(-dt.Minute).AddSeconds(-dt.Second);


            _firmaCekServis.Data(ServisList.FirmaCekSBListeServis);
            _firmaSenetServis.Data(ServisList.FirmaSenetSBListeServis);
            List<CekDurum> FirmaDurumList = new List<CekDurum>();
            FirmaDurumList.Add(new CekDurum("CEK",   _firmaCekServis.obje.Where(x => x.ODEMETARIH == DateTime.Now).Count() > 0 ? _firmaCekServis.obje.Where(x => x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0,  _firmaCekServis.obje.Where(x => x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Count() > 0 ? _firmaCekServis.obje.Where(x => x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0,  _firmaCekServis.obje.Where(x => x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Count() > 0 ? _firmaCekServis.obje.Where(x => x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Sum(x => x.TUTAR) : 0,  _firmaCekServis.obje.Where(x => x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Count() > 0 ? _firmaCekServis.obje.Where(x => x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            FirmaDurumList.Add(new CekDurum("SENET", _firmaSenetServis.obje.Where(x => x.VADETARIH == DateTime.Now).Count() > 0 ? _firmaSenetServis.obje.Where(x => x.VADETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0,_firmaSenetServis.obje.Where(x => x.VADETARIH >= HaftaninIlkGunu && x.VADETARIH <= HaftaninSonGunu).Count() > 0 ? _firmaSenetServis.obje.Where(x => x.VADETARIH >= HaftaninIlkGunu && x.VADETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _firmaSenetServis.obje.Where(x => x.VADETARIH >= AyIlk && x.VADETARIH <= AySon).Count() > 0 ? _firmaSenetServis.obje.Where(x => x.VADETARIH >= AyIlk && x.VADETARIH <= AySon).Sum(x => x.TUTAR) : 0,  _firmaSenetServis.obje.Where(x => x.VADETARIH >= BirDahakiAyIlk && x.VADETARIH <= BirDahakiAySon).Count() > 0 ? _firmaSenetServis.obje.Where(x => x.VADETARIH >= BirDahakiAyIlk && x.VADETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            gridControl1.DataSource = FirmaDurumList;

            _musteriCekServis.Data(ServisList.MusteriCekSBListeServis);
            _musteriSenetServis.Data(ServisList.MusteriSenetSBListeServis);
            List<CekDurum> MusteriDurumList = new List<CekDurum>();


            MusteriDurumList.Add(new CekDurum("Çek Portföy", _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 0 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Çek Ciro", _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 1 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Çek Tahsil", _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 3 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Çek Teminat", _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= HaftaninIlkGunu && x.ODEMETARIH <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= AyIlk && x.ODEMETARIH <= AySon).Sum(x => x.TUTAR) : 0, _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Count() > 0 ? _musteriCekServis.obje.Where(x => x.ISLEM == 4 && x.ODEMETARIH >= BirDahakiAyIlk && x.ODEMETARIH <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));

            MusteriDurumList.Add(new CekDurum("Senet Portföy", _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 0 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Senet Ciro", _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 1 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Senet Tahsil", _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 3 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            MusteriDurumList.Add(new CekDurum("Senet Teminat", _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy")).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= HaftaninIlkGunu && x.VADETARIHI <= HaftaninSonGunu).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= AyIlk && x.VADETARIHI <= AySon).Sum(x => x.TUTAR) : 0, _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Count() > 0 ? _musteriSenetServis.obje.Where(x => x.ISLEM == 4 && x.VADETARIHI >= BirDahakiAyIlk && x.VADETARIHI <= BirDahakiAySon).Sum(x => x.TUTAR) : 0));
            gridControl2.DataSource = MusteriDurumList;
        }

    }
}

