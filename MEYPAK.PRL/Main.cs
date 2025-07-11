﻿using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.KULLANICI;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.PRL.ARACLAR;
using MEYPAK.PRL.ARAÇLAR;
using MEYPAK.PRL.BANKA;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.CARI.Raporlar;
using MEYPAK.PRL.CEKSENET;
using MEYPAK.PRL.CEKSENET.Firma;
using MEYPAK.PRL.CEKSENET.Firma.Çek;
using MEYPAK.PRL.CEKSENET.Müşteri.Çek;
using MEYPAK.PRL.CEKSENET.Müşteri.Senet;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.DEPO.Raporlar;
using MEYPAK.PRL.DESTEKSERVIS;
using MEYPAK.PRL.E_ISLEMLER;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.KASA;
using MEYPAK.PRL.KULLANICI;
using MEYPAK.PRL.MOBILIZ;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.PERSONEL.Raporlar;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL.STOK.FiyatListesi;
using MEYPAK.PRL.STOK.Raporlar;
using MEYPAK.PRL.STOK.StokKasa;
using Microsoft.AspNetCore.Identity;
using ServiceReference1;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Xml.Serialization;

namespace MEYPAK.PRL
{
    public partial class Main : XtraForm
    {
        public Main(MPUSER kullanici, List<string> roller, int depoid)
        {
            InitializeComponent();
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly |
                                    BindingFlags.NonPublic |
                                    BindingFlags.Public | BindingFlags.Instance |
                                    BindingFlags.Static))
                {
                    if ((method.Attributes & MethodAttributes.Abstract) == MethodAttributes.Abstract || method.ContainsGenericParameters)
                    {
                        continue;
                    }
                    System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(method.MethodHandle);

                }
            }
            this.DEPOID = depoid;
            _parabirimServis = new GenericWebServis<PocoPARABIRIM>();
            Kullanici = kullanici;
            Roller = roller;
            _mükellefListesi = new GenericWebServis<PocoMUKELLEFLISTESI>();
            _formYetkiServis = new GenericWebServis<PocoFORMYETKI>();
            _formServis = new GenericWebServis<PocoFORM>();
        }
        #region TANIMLAR
        FStokList fstokList;
        FCariList fcariList;
        FFaturaList ffaturaList;
        FSevkiyatPanel fSevkiyatPanel;
        FSatisIrsaliye fSatisIrsaliye;
        FOlcuBrKart fOlcuBrKart;
        FStokKart fSTOKKART;
        FStokHareket fStokHareket;
        FDepoKart fDepoKart;
        FStokSayim fStokSayim;
        FSayimIsle fSayimIsle;
        FMusteriSiparis fSiparis;
        FSatinAlmaSiparis fSatinAlmaSiparis;
        FMalKabulPanel fMalKabulPanel;
        FStokFiyat fStokFiyat;
        FHizmetKart fHizmetKart;
        FCariHareket fCariHareket;
        FCariDurum fCariDurum;
        FCariKart fCariKart;
        FCariAltHesap fCariAltHesap;
        FPersonelKart fPersonelKart;
        FStokKasaPanel fKasaPanel;
        FParaBirimi fParaBirimi;
        FFatura ffatura;
        FStokKasaHareket fStokKasaHareket;
        FKasaMarka fKasaMarka;
        FMarkaKart fMarkaKart;
        FGindeFaturaEşleştir fGindeFaturaEşleştir;
        FAlisIrsaliye fFAlisIrsaliye;
        FAlisFatura fFAlisFatura;
        FMusteriSiparisIrsaliyelestir fMusteriSiparisIrsaliyelestir;
        FSeriTanim fSeriTanim;
        FSatisIrsaliyeFaturalastir fSatisIrsaliyeFaturalastir;
        FCariRaporu fCariRaporu;
        FFaturaRaporu fFaturaRaporu;
        FStokHareketRaporu fStokHareketRaporu;
        FStokFiyatRaporu fStokFiyatRaporu;
        FStokSayimRaporu fStokSayimRaporu;
        FStokRaporu fStokListesiRaporu;
        FCariHareketRaporu fCariHareketRaporu;
        FStokKategoriRaporu fStokKategoriRaporu;
        FStokKasaHareketRaporu fStokKasaHarRaporu;
        FMusteriSiparisRaporu fMusteriSiparisRaporu;
        FDepoRaporu fDepoRaporu;
        FGELENIRSALIYE fGELENIRSALIYE;
        FAracTanim fAracTanim;
        FAracRota fAracRota;
        FPersonelList fPersonelList;
        FPersonelRaporu fPersonelRaporu;
        FStokSevkiyatRaporu fStokSevkiyatRaporu;
        FKasaKart fKasaKart;
        FKasaHareket fKasaHareket;
        FBankaTanim fBankaTanim;
        FBankaHesapTanim fBankaHesapTanim;
        FBankaSubeTanim fBankaSubeTanim;
        FHesapHareket fHesapHareket;
        FMusteriCekTanim fMusteriCekTanim;
        FMusteriCekCariCiro fMusteriCekCariCiro;
        FMusteriSenetTanim fMusteriSenetTanim;
        FMusteriSenetCariCiro fMusteriSenetCariCiro;
        FFirmaCekTanim fFirmaCekTanim;
        FFirmaSenetTanim fFirmaSenetTanim;
        FMusteriCekTahsilat fMusteriCekTahsilat;
        FMusteriCekTeminat fMusteriCekTeminat;
        FMusteriCekProtesto fMusteriCekProtesto;
        FMusteriSenetTahsilat fMusteriSenetTahsilat;
        FMusteriSenetTeminat fMusteriSenetTeminat;
        FMusteriSenetProtesto fMusteriSenetProtesto;
        FStokSarf fStokSarf;
        StokKasaGirisPanel stokkasa;
        EFATURA fefatura;
        FFirmaCekListe fFirmaCekListe;
        FCekSenetDurum fCekSenetDurum;
        FKullaniciTanim fKullaniciTanim;
        FKullaniciYonetim fKullaniciYonetim;
        FGidenEFatura fGidenEFatura;
        EFaturaParams eFaturaParams;
        FGidenEArsiv fGidenEArsiv;
        FGidenEIrsaliye fGidenEIrsaliye;
        FFATURASTOKOLCUESLE fFATURASTOKOLCUESLE;
        FMustahsil fMustahsilMakbuz;
        FGidenEMustahsil fGidenEMustahsil;
        FDestekServis fDestekServis;
        FMobilizWeb fMobilizWeb;

        public Tarih_Date _tarih_Date = new Tarih_Date();
        public DataTable guncelkur;
        GenericWebServis<PocoPARABIRIM> _parabirimServis;
        GenericWebServis<PocoMUKELLEFLISTESI> _mükellefListesi;
        GenericWebServis<PocoFORMYETKI> _formYetkiServis;
        GenericWebServis<PocoFORM> _formServis;
        public MPUSER Kullanici;
        public List<string> Roller;
        public List<PocoFORMYETKI> yetkiListe;
        public List<PocoFORM> formListe;
        public int DEPOID;
        #endregion



        public void GuncelKur()
        {
            try
            {

                HttpRequestMessage client;
                HttpClient httpClient = new HttpClient();
                client = new HttpRequestMessage(HttpMethod.Post, "https://www.tcmb.gov.tr/kurlar/today.xml");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("Host", "www.tcmb.gov.tr");
                client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
                client.Method = HttpMethod.Get;
                httpClient.DefaultRequestHeaders.ExpectContinue = false;
                HttpResponseMessage resp = httpClient.SendAsync(client).Result;
                var aaaa = resp.Content.ReadAsStringAsync().Result.ToString();
                XmlSerializerHelper xmlSerializerHelper = new XmlSerializerHelper();
                _tarih_Date = (Tarih_Date)xmlSerializerHelper.DeserializeFromXml(typeof(Tarih_Date), aaaa);
                _parabirimServis.Data(ServisList.ParaBirimiListeServis);
                foreach (var item in _tarih_Date.Currency)
                {
                    if (_parabirimServis.obje.Where(x => x.adi == item.Isim).Count() > 0)
                        _parabirimServis.Data(ServisList.ParaBirimiEkleServis, new PocoPARABIRIM()
                        {
                            id = _parabirimServis.obje.Where(x => x.adi == item.Isim).FirstOrDefault().id,
                            adi = item.Isim,
                            kisaadi = item.Kod,
                            dovizsatis = Convert.ToDecimal(item.ForexSelling == "" ? "0" : item.ForexSelling),
                            dovizalis = item.ForexBuying,
                            dovizefektifalis = Convert.ToDecimal(item.BanknoteBuying == "" ? "0" : item.BanknoteBuying),
                            dovizefektifsatis = Convert.ToDecimal(item.BanknoteSelling == "" ? "0" : item.BanknoteSelling),
                            userid = MPKullanici.ID,

                        });
                    else
                        _parabirimServis.Data(ServisList.ParaBirimiEkleServis, new PocoPARABIRIM()
                        {

                            adi = item.Isim,
                            kisaadi = item.Kod,
                            dovizsatis = Convert.ToDecimal(item.ForexSelling == "" ? "0" : item.ForexSelling),
                            dovizalis = item.ForexBuying,
                            dovizefektifalis = Convert.ToDecimal(item.BanknoteBuying == "" ? "0" : item.BanknoteBuying),
                            dovizefektifsatis = Convert.ToDecimal(item.BanknoteSelling == "" ? "0" : item.BanknoteSelling),
                            userid = MPKullanici.ID,

                        });
                }
            }
            catch
            {

            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (!Roller.Contains("ADMIN"))
            {
                _formServis.Data(ServisList.FormListeServis);
                formListe = _formServis.obje;
                _formYetkiServis.Data(ServisList.FormYetkiListeServis);
                yetkiListe = _formYetkiServis.obje.Where(x => x.KULLANICIID == Kullanici.Id).ToList();
                foreach (var yetki in yetkiListe)
                {
                    string FormAdi = formListe.Where(x => x.id == yetki.FORMID).Count() > 0 ? formListe.Where(x => x.id == yetki.FORMID).FirstOrDefault().FORMADI : "";
                    foreach (AccordionControlElement Menus in accordionControl1.Elements)
                    {
                        int menu = 0;
                        foreach (AccordionControlElement Categorys in Menus.Elements)
                        {
                            int category = 0;
                            if (Categorys.Elements.Count() > 0)
                            {
                                foreach (AccordionControlElement Element in Categorys.Elements)
                                {

                                    string Tag = Element.Tag != null ? Element.Tag.ToString() : "";
                                    if (Tag != "" && FormAdi != "" && Tag == FormAdi)
                                    {
                                        category++;
                                        Element.Visible = true;
                                        Element.Enabled = true;
                                    }
                                }
                                if (category > 0)
                                {
                                    menu++;
                                    Categorys.Visible = true;
                                    Categorys.Enabled = true;
                                }
                            }
                            else
                            {
                                string Tag = Categorys.Tag != null ? Categorys.Tag.ToString() : "";
                                if (Tag != "" && FormAdi != "" && Tag == FormAdi)
                                {
                                    menu++;
                                    Categorys.Visible = true;
                                    Categorys.Enabled = true;
                                }
                            }

                        }
                        if (menu > 0)
                        {
                            Menus.Visible = true;
                            Menus.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                foreach (AccordionControlElement Menus in accordionControl1.Elements)
                {
                    foreach (AccordionControlElement Categorys in Menus.Elements)
                    {
                        foreach (AccordionControlElement Element in Categorys.Elements)
                        {
                            Element.Visible = true;
                            Element.Enabled = true;
                        }
                        Categorys.Visible = true;
                        Categorys.Enabled = true;
                    }
                    Menus.Visible = true;
                    Menus.Enabled = true;
                }
            }

            ACEKullanici.Text = Kullanici.AD + " " + Kullanici.SOYAD;

        }




        public int i = 0;
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSTOKKART = new FStokKart();
            page.Name = "TPStokKart" + i;
            page.Text = "Stok Kart";
            page.Tag = "TPStokKart" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSTOKKART.TopLevel = false;
            fSTOKKART.AutoScroll = true;
            fSTOKKART.Tag = "TPStokKart" + i;
            fSTOKKART.Dock = DockStyle.Fill;
            page.Controls.Add(fSTOKKART);
            fSTOKKART.Show();
            i++;
        }
        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fHizmetKart = new FHizmetKart();
            page.Name = "TPHizmetKart" + i;
            page.Text = "Hizmet Kart";
            page.Tag = "TPHizmetKart" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fHizmetKart.FormBorderStyle = FormBorderStyle.None;
            fHizmetKart.TopLevel = false;
            fHizmetKart.AutoScroll = true;
            fHizmetKart.Dock = DockStyle.Fill;
            fHizmetKart.Tag = "TPHizmetKart" + i;
            page.Controls.Add(fHizmetKart);
            fHizmetKart.Show();
            i++;
        }
        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokHareket = new FStokHareket();
            page.Name = "TPStokHareket" + i;
            page.Text = "Stok Hareket";
            page.Tag = "TPStokHareket" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokHareket.TopLevel = false;
            fStokHareket.AutoScroll = true;
            fStokHareket.Dock = DockStyle.Fill;
            fStokHareket.Tag = "TPStokHareket" + i;
            page.Controls.Add(fStokHareket);
            fStokHareket.Show();
        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokSayim = new FStokSayim();
            page.Name = "TPStokSayim" + i;
            page.Text = "Stok Sayım";
            page.Tag = "TPStokSayim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokSayim.TopLevel = false;
            fStokSayim.AutoScroll = true;
            fStokSayim.Dock = DockStyle.Fill;
            fStokSayim.Tag = "TPStokSayim" + i;
            page.Controls.Add(fStokSayim);
            fStokSayim.Show();
        }

        private void accordionControlElement30_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCariHareket = new FCariHareket();
            page.Name = "TPCariHareket" + i;
            page.Text = "Cari Hareket";
            page.Tag = "TPCariHareket" + i;


            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;
            fCariHareket.TopLevel = false;
            fCariHareket.AutoScroll = true;
            fCariHareket.Dock = DockStyle.Fill;
            fCariHareket.Tag = "TPCariHareket" + i;
            page.Controls.Add(fCariHareket);
            fCariHareket.Show();
        }


        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
            foreach (Form frm in Application.OpenForms)
            {
                if ((arg.Page as XtraTabPage).Tag == frm.Tag)
                {
                    frm.Dispose();
                }
            }
            (arg.Page as XtraTabPage).Dispose();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSiparis = new FMusteriSiparis();
            page.Name = "TPMusteriSiparis" + i;
            page.Text = "Müşteri Sipariş";
            page.Tag = "TPMusteriSiparis" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSiparis.TopLevel = false;
            fSiparis.AutoScroll = true;
            fSiparis.Dock = DockStyle.Fill;
            fSiparis.Tag = "TPMusteriSiparis" + i;
            page.Controls.Add(fSiparis);
            fSiparis.Show();
            i++;

        }

        private void accordionControlElement34_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSiparis = new FMusteriSiparis();
            page.Name = "TPMusteriSiparis" + i;
            page.Text = "Müşteri Sipariş";
            page.Tag = "TPMusteriSiparis" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSiparis.TopLevel = false;
            fSiparis.AutoScroll = true;
            fSiparis.Dock = DockStyle.Fill;
            fSiparis.Tag = "TPMusteriSiparis" + i;
            page.Controls.Add(fSiparis);
            fSiparis.Show();
            i++;
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void accordionControlElement36_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCariDurum = new FCariDurum();
            page.Name = "TPCariDurum" + i;
            page.Text = "Cari Durum";
            page.Tag = "TPCariDurum" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fCariDurum.TopLevel = false;
            fCariDurum.AutoScroll = true;
            fCariDurum.Dock = DockStyle.Fill;
            fCariDurum.Tag = "TPCariDurum" + i;
            page.Controls.Add(fCariDurum);
            fCariDurum.Show();
            i++;
        }

        private void accordionControlElement37_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSatinAlmaSiparis = new FSatinAlmaSiparis();
            page.Name = "TPSatinAlmaSiparis" + i;
            page.Text = "SatınAlma Sipariş";
            page.Tag = "TPSatinAlmaSiparis" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSatinAlmaSiparis.TopLevel = false;
            fSatinAlmaSiparis.AutoScroll = true;
            fSatinAlmaSiparis.Dock = DockStyle.Fill;
            fSatinAlmaSiparis.Tag = "TPSatinAlmaSiparis" + i;
            page.Controls.Add(fSatinAlmaSiparis);
            fSatinAlmaSiparis.Show();
            i++;
        }

        private void accordionControlElement29_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSayimIsle = new FSayimIsle();
            page.Name = "TPSayimIsle" + i;
            page.Text = "Sayım İşle";
            page.Tag = "TPSayimIsle" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSayimIsle.TopLevel = false;
            fSayimIsle.AutoScroll = true;
            fSayimIsle.Dock = DockStyle.Fill;
            fSayimIsle.Tag = "TPSevkiyatPanel" + i;
            page.Controls.Add(fSayimIsle);
            fSayimIsle.Show();
            i++;
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSevkiyatPanel = new FSevkiyatPanel();
            page.Name = "TPSevkiyatPanel" + i;
            page.Text = "Sevkiyat Panel";
            page.Tag = "TPSevkiyatPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSevkiyatPanel.TopLevel = false;
            fSevkiyatPanel.AutoScroll = true;
            fSevkiyatPanel.Dock = DockStyle.Fill;
            fSevkiyatPanel.Tag = "TPSevkiyatPanel" + i;
            page.Controls.Add(fSevkiyatPanel);
            fSevkiyatPanel.Show();
            i++;
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCariKart = new FCariKart();
            page.Name = "TPCariKartPanel" + i;
            page.Text = "Cari Kart Panel";
            page.Tag = "TPCariKartPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fCariKart.TopLevel = false;
            fCariKart.AutoScroll = true;
            fCariKart.Dock = DockStyle.Fill;
            fCariKart.Tag = "TPCariKartPanel" + i;
            page.Controls.Add(fCariKart);
            fCariKart.Show();
            i++;
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fOlcuBrKart = new FOlcuBrKart();
            page.Name = "TPOlcuBrPanel" + i;
            page.Text = "Ölçü Birim Panel";
            page.Tag = "TPOlcuBrPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fOlcuBrKart.TopLevel = false;
            fOlcuBrKart.AutoScroll = true;
            fOlcuBrKart.Dock = DockStyle.Fill;
            fOlcuBrKart.Tag = "TPOlcuBrPanel" + i;
            page.Controls.Add(fOlcuBrKart);
            fOlcuBrKart.Show();
            i++;
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fDepoKart = new FDepoKart();
            page.Name = "TPDepoKartPanel" + i;
            page.Text = "Depo Panel";
            page.Tag = "TPDepoKartPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fDepoKart.TopLevel = false;
            fDepoKart.AutoScroll = true;
            fDepoKart.Dock = DockStyle.Fill;
            fDepoKart.Tag = "TPDepoKartPanel" + i;
            page.Controls.Add(fDepoKart);
            fDepoKart.Show();
            i++;
        }

        private void accordionControlElement41_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fPersonelKart = new FPersonelKart();
            page.Name = "TPPersonelKartPanel" + i;
            page.Text = "Personel Kart Panel";
            page.Tag = "TPPersonelKartPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fPersonelKart.TopLevel = false;
            fPersonelKart.AutoScroll = true;
            fPersonelKart.Dock = DockStyle.Fill;
            fPersonelKart.Tag = "TPPersonelKartPanel" + i;
            page.Controls.Add(fPersonelKart);
            fPersonelKart.Show();
            i++;
        }

        private void accordionControlElement42_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKasaPanel = new FStokKasaPanel();
            page.Name = "TPKasaPanel" + i;
            page.Text = "Kasa Kart Panel";
            page.Tag = "TPKasaPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKasaPanel.TopLevel = false;
            fKasaPanel.AutoScroll = true;
            fKasaPanel.Dock = DockStyle.Fill;
            fKasaPanel.Tag = "TPKasaPanel" + i;
            page.Controls.Add(fKasaPanel);
            fKasaPanel.Show();
            i++;
        }

        private void accordionControlElement43_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSatisIrsaliye = new FSatisIrsaliye();
            page.Name = "TPSatisIrsaliye" + i;
            page.Text = "Satis Irsaliye";
            page.Tag = "TPSatisIrsaliye" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSatisIrsaliye.TopLevel = false;
            fSatisIrsaliye.AutoScroll = true;
            fSatisIrsaliye.Dock = DockStyle.Fill;
            fSatisIrsaliye.Tag = "TPSatisIrsaliye" + i;
            page.Controls.Add(fSatisIrsaliye);
            fSatisIrsaliye.Show();
            i++;
        }

        private void accordionControlElement44_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fParaBirimi = new FParaBirimi();
            page.Name = "TPParaBirimi" + i;
            page.Text = "Para Birim Tanım";
            page.Tag = "TPParaBirimi" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fParaBirimi.TopLevel = false;
            fParaBirimi.AutoScroll = true;
            fParaBirimi.Dock = DockStyle.Fill;
            fParaBirimi.Tag = "TPParaBirimi" + i;
            page.Controls.Add(fParaBirimi);
            fParaBirimi.Show();
            i++;
        }

        private void accordionControlElement45_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            ffatura = new FFatura();
            page.Name = "TPFatura" + i;
            page.Text = "Fatura Tanım";
            page.Tag = "TPFatura" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            ffatura.TopLevel = false;
            ffatura.AutoScroll = true;
            ffatura.Dock = DockStyle.Fill;
            ffatura.Tag = "TPFatura" + i;
            page.Controls.Add(ffatura);
            ffatura.Show();
            i++;
        }

        private void accordionControlElement46_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokKasaHareket = new FStokKasaHareket();
            page.Name = "TPStokKasaHareket" + i;
            page.Text = "Stok Kasa Hareket";
            page.Tag = "TPStokKasaHareket" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokKasaHareket.TopLevel = false;
            fStokKasaHareket.AutoScroll = true;
            fStokKasaHareket.Dock = DockStyle.Fill;
            fStokKasaHareket.Tag = "TPStokKasaHareket" + i;
            page.Controls.Add(fStokKasaHareket);
            fStokKasaHareket.Show();
            i++;
        }

        private void accordionControlElement47_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKasaMarka = new FKasaMarka();
            page.Name = "TPStokKasaMarka" + i;
            page.Text = "Stok Kasa Marka";
            page.Tag = "TPStokKasaMarka" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKasaMarka.TopLevel = false;
            fKasaMarka.AutoScroll = true;
            fKasaMarka.Dock = DockStyle.Fill;
            fKasaMarka.Tag = "TPStokKasaMarka" + i;
            page.Controls.Add(fKasaMarka);
            fKasaMarka.Show();
            i++;
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMarkaKart = new FMarkaKart();
            page.Name = "TPMarkaKart" + i;
            page.Text = "Marka Kart";
            page.Tag = "TPMarkaKart" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMarkaKart.FormBorderStyle = FormBorderStyle.None;
            fMarkaKart.TopLevel = false;
            fMarkaKart.AutoScroll = true;
            fMarkaKart.Dock = DockStyle.Fill;
            fMarkaKart.Tag = "TPMarkaKart" + i;
            page.Controls.Add(fMarkaKart);
            fMarkaKart.Show();
            i++;
        }


        private void accordionControlElement49_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFAlisFatura = new FAlisFatura();
            page.Name = "TPAlisFatura" + i;
            page.Text = "Alış Fatura";
            page.Tag = "TPAlisFatura" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFAlisFatura.TopLevel = false;
            fFAlisFatura.AutoScroll = true;
            fFAlisFatura.Dock = DockStyle.Fill;
            fFAlisFatura.Tag = "TPAlisFatura" + i;
            page.Controls.Add(fFAlisFatura);
            fFAlisFatura.Show();
            i++;
        }
        private void accordionControlElement50_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokFiyat = new FStokFiyat();
            page.Name = "TPStokFiyat" + i;
            page.Text = "Stok Fiyat Tanım";
            page.Tag = "TPStokFiyat" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;
            fStokFiyat.TopLevel = false;
            fStokFiyat.AutoScroll = true;
            fStokFiyat.Dock = DockStyle.Fill;
            fStokFiyat.Tag = "TPStokFiyat" + i;
            page.Controls.Add(fStokFiyat);
            fStokFiyat.Show();

        }
        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMalKabulPanel = new FMalKabulPanel();
            page.Name = "TPMalKabul" + i;
            page.Text = "Mal Kabul";
            page.Tag = "TPMalKabul" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMalKabulPanel.TopLevel = false;
            fMalKabulPanel.AutoScroll = true;
            fMalKabulPanel.Dock = DockStyle.Fill;
            fMalKabulPanel.Tag = "TPMalKabul" + i;
            page.Controls.Add(fMalKabulPanel);
            fMalKabulPanel.Show();
            i++;
        }

        private void accordionControlElement51_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFAlisIrsaliye = new FAlisIrsaliye();
            page.Name = "TPAlisIrsaliye" + i;
            page.Text = "Alış Irsaliye";
            page.Tag = "TPAlisIrsaliye" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFAlisIrsaliye.TopLevel = false;
            fFAlisIrsaliye.AutoScroll = true;
            fFAlisIrsaliye.Dock = DockStyle.Fill;
            fFAlisIrsaliye.Tag = "TPAlisIrsaliye" + i;
            page.Controls.Add(fFAlisIrsaliye);
            fFAlisIrsaliye.Show();
            i++;
        }


        private void ACEMusteriSiparisIrsaliyelestir_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSiparisIrsaliyelestir = new FMusteriSiparisIrsaliyelestir();
            page.Name = "TPMusteriSiparisIrsaliyelestir" + i;
            page.Text = "Müşteri Siparişi İrsaliyeleştir";
            page.Tag = "TPMusteriSiparisIrsaliyelestir" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSiparisIrsaliyelestir.TopLevel = false;
            fMusteriSiparisIrsaliyelestir.AutoScroll = true;
            fMusteriSiparisIrsaliyelestir.Dock = DockStyle.Fill;
            fMusteriSiparisIrsaliyelestir.Tag = "TPMusteriSiparisIrsaliyelestir" + i;
            page.Controls.Add(fMusteriSiparisIrsaliyelestir);
            fMusteriSiparisIrsaliyelestir.Show();
            i++;

        }

        private void accordionControlElement48_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fstokList = new FStokList();
            page.Name = "TPStokList" + i;
            page.Text = "Stok List";
            page.Tag = "TPStokList" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fstokList.FormBorderStyle = FormBorderStyle.None;
            fstokList.TopLevel = false;
            fstokList.AutoScroll = true;
            fstokList.Dock = DockStyle.Fill;
            fstokList.Tag = "TPStokList" + i;
            page.Controls.Add(fstokList);
            fstokList.Show();
            i++;
        }

        private void accordionControlElement52_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fcariList = new FCariList();
            page.Name = "TPCariList" + i;
            page.Text = "Cari List";
            page.Tag = "TPCariList" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fcariList.FormBorderStyle = FormBorderStyle.None;
            fcariList.TopLevel = false;
            fcariList.AutoScroll = true;
            fcariList.Dock = DockStyle.Fill;
            fcariList.Tag = "TPCariList" + i;
            page.Controls.Add(fcariList);
            fcariList.Show();
            i++;
        }

        private void accordionControlElement53_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            ffaturaList = new FFaturaList(islem: "FFatura");
            page.Name = "TPFaturaList" + i;
            page.Text = "Fatura List";
            page.Tag = "TPFaturaList" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            ffaturaList.FormBorderStyle = FormBorderStyle.None;
            ffaturaList.TopLevel = false;
            ffaturaList.AutoScroll = true;
            ffaturaList.Dock = DockStyle.Fill;
            ffaturaList.Tag = "TPFaturaList" + i;
            page.Controls.Add(ffaturaList);
            ffaturaList.Show();
            i++;
        }

        private void accordionControlElement54_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokFiyatRaporu = new FStokFiyatRaporu(islem: "FStokFiyatRaporu");
            page.Name = "TPStokFiyatRaporu" + i;
            page.Text = "Stok Fiyat Raporu";
            page.Tag = "TPStokFiyatRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokFiyatRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokFiyatRaporu.TopLevel = false;
            fStokFiyatRaporu.AutoScroll = true;
            fStokFiyatRaporu.Dock = DockStyle.Fill;
            fStokFiyatRaporu.Tag = "TPStokFiyatRaporu" + i;
            page.Controls.Add(fStokFiyatRaporu);
            fStokFiyatRaporu.Show();
            i++;
        }

        private void accordionControlElement55_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokHareketRaporu = new FStokHareketRaporu(islem: "FStokHareketRaporu");
            page.Name = "TPStokHareketRaporu" + i;
            page.Text = "Stok Hareket Raporu";
            page.Tag = "TPStokHareketRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokHareketRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokHareketRaporu.TopLevel = false;
            fStokHareketRaporu.AutoScroll = true;
            fStokHareketRaporu.Dock = DockStyle.Fill;
            fStokHareketRaporu.Tag = "TPStokHareketRaporu" + i;
            page.Controls.Add(fStokHareketRaporu);
            fStokHareketRaporu.Show();
            i++;
        }

        private void accordionControlElement56_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokSayimRaporu = new FStokSayimRaporu(islem: "FStokSayimRaporu");
            page.Name = "TPStokSayimRaporu" + i;
            page.Text = "Stok Sayım Raporu";
            page.Tag = "TPStokSayimRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokSayimRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokSayimRaporu.TopLevel = false;
            fStokSayimRaporu.AutoScroll = true;
            fStokSayimRaporu.Dock = DockStyle.Fill;
            fStokSayimRaporu.Tag = "TPStokSayimRaporu" + i;
            page.Controls.Add(fStokSayimRaporu);
            fStokSayimRaporu.Show();
            i++;
        }

        private void accordionControlElement57_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokListesiRaporu = new FStokRaporu(islem: "FStokListesiRaporu");
            page.Name = "TPStokListesiRaporu" + i;
            page.Text = "Stok Listesi Raporu";
            page.Tag = "TPStokListesiRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokListesiRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokListesiRaporu.TopLevel = false;
            fStokListesiRaporu.AutoScroll = true;
            fStokListesiRaporu.Dock = DockStyle.Fill;
            fStokListesiRaporu.Tag = "TPStokListesiRaporu" + i;
            page.Controls.Add(fStokListesiRaporu);
            fStokListesiRaporu.Show();
            i++;
        }

        private void accordionControlElement58_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCariHareketRaporu = new FCariHareketRaporu(islem: "FCariHareketRaporu");
            page.Name = "TPCariHareketRaporu" + i;
            page.Text = "Cari Hareket Raporu";
            page.Tag = "TPCariHareketRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fCariHareketRaporu.FormBorderStyle = FormBorderStyle.None;
            fCariHareketRaporu.TopLevel = false;
            fCariHareketRaporu.AutoScroll = true;
            fCariHareketRaporu.Dock = DockStyle.Fill;
            fCariHareketRaporu.Tag = "TPCariHareketRaporu" + i;
            page.Controls.Add(fCariHareketRaporu);
            fCariHareketRaporu.Show();
            i++;

        }

        private void accordionControlElement59_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokKategoriRaporu = new FStokKategoriRaporu(islem: "FStokKategoriRaporu");
            page.Name = "TPStokKategoriRaporu" + i;
            page.Text = "Stok Kategori Raporu";
            page.Tag = "TPStokKategoriRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokKategoriRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokKategoriRaporu.TopLevel = false;
            fStokKategoriRaporu.AutoScroll = true;
            fStokKategoriRaporu.Dock = DockStyle.Fill;
            fStokKategoriRaporu.Tag = "TPStokKategoriRaporu" + i;
            page.Controls.Add(fStokKategoriRaporu);
            fStokKategoriRaporu.Show();
            i++;
        }

        private void accordionControlElement60_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokKasaHarRaporu = new FStokKasaHareketRaporu(islem: "FStokKasaHareketRaporu");
            page.Name = "TPStokKasaHareketRaporu" + i;
            page.Text = "Stok Kasa Hareket Raporu";
            page.Tag = "TPStokKasaHareketRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokKasaHarRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokKasaHarRaporu.TopLevel = false;
            fStokKasaHarRaporu.AutoScroll = true;
            fStokKasaHarRaporu.Dock = DockStyle.Fill;
            fStokKasaHarRaporu.Tag = "TPStokKasaHareketRaporu" + i;
            page.Controls.Add(fStokKasaHarRaporu);
            fStokKasaHarRaporu.Show();
            i++;
        }

        private void ACESeriTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSeriTanim = new FSeriTanim(islem: "FSeriTanim");
            page.Name = "TPSeriTanım" + i;
            page.Text = "Seri Tanım";
            page.Tag = "TPSeriTanım" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSeriTanim.FormBorderStyle = FormBorderStyle.None;
            fSeriTanim.TopLevel = false;
            fSeriTanim.AutoScroll = true;
            fSeriTanim.Dock = DockStyle.Fill;
            fSeriTanim.Tag = "TPSeriTanım" + i;
            page.Controls.Add(fSeriTanim);
            fSeriTanim.Show();
            i++;
        }

        private void ACEFaturaRaporu_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFaturaRaporu = new FFaturaRaporu(islem: "FFaturaRaporu");
            page.Name = "TPFaturaRaporu" + i;
            page.Text = "Fatura Raporu";
            page.Tag = "TPFaturaRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFaturaRaporu.FormBorderStyle = FormBorderStyle.None;
            fFaturaRaporu.TopLevel = false;
            fFaturaRaporu.AutoScroll = true;
            fFaturaRaporu.Dock = DockStyle.Fill;
            fFaturaRaporu.Tag = "TPFaturaRaporu" + i;
            page.Controls.Add(fFaturaRaporu);
            fFaturaRaporu.Show();
            i++;
        }

        private void ACESatisIrsaliyeFaturalastir_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSatisIrsaliyeFaturalastir = new FSatisIrsaliyeFaturalastir();
            page.Name = "TPSatisIrsaliyeFaturalastir" + i;
            page.Text = "Satış Irsaliyesi Faturalaştır";
            page.Tag = "TPSatisIrsaliyeFaturalastir" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fSatisIrsaliyeFaturalastir.FormBorderStyle = FormBorderStyle.None;
            fSatisIrsaliyeFaturalastir.TopLevel = false;
            fSatisIrsaliyeFaturalastir.AutoScroll = true;
            fSatisIrsaliyeFaturalastir.Dock = DockStyle.Fill;
            fSatisIrsaliyeFaturalastir.Tag = "TPSatisIrsaliyeFaturalastir" + i;
            page.Controls.Add(fSatisIrsaliyeFaturalastir);
            fSatisIrsaliyeFaturalastir.Show();
            i++;
        }

        private void ACECariRapor_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCariRaporu = new FCariRaporu();
            page.Name = "TPCariRaporu" + i;
            page.Text = "Cari Raporu";
            page.Tag = "TPCariRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fCariRaporu.FormBorderStyle = FormBorderStyle.None;
            fCariRaporu.TopLevel = false;
            fCariRaporu.AutoScroll = true;
            fCariRaporu.Dock = DockStyle.Fill;
            fCariRaporu.Tag = "TPCariRaporu" + i;
            page.Controls.Add(fCariRaporu);
            fCariRaporu.Show();
            i++;

        }

        private void ACEMusteriSiparisRaporu_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSiparisRaporu = new FMusteriSiparisRaporu();
            page.Name = "TPMusteriSiparisRaporu" + i;
            page.Text = "Müşteri Sipariş Raporu";
            page.Tag = "TPMusteriSiparisRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSiparisRaporu.FormBorderStyle = FormBorderStyle.None;
            fMusteriSiparisRaporu.TopLevel = false;
            fMusteriSiparisRaporu.AutoScroll = true;
            fMusteriSiparisRaporu.Dock = DockStyle.Fill;
            fMusteriSiparisRaporu.Tag = "TPMusteriSiparisRaporu" + i;
            page.Controls.Add(fMusteriSiparisRaporu);
            fMusteriSiparisRaporu.Show();
            i++;

        }

        private void ACEDepoRaporu_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fDepoRaporu = new FDepoRaporu();
            page.Name = "TPDepoRaporu" + i;
            page.Text = "Depo Raporu";
            page.Tag = "TPDepoRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fDepoRaporu.FormBorderStyle = FormBorderStyle.None;
            fDepoRaporu.TopLevel = false;
            fDepoRaporu.AutoScroll = true;
            fDepoRaporu.Dock = DockStyle.Fill;
            fDepoRaporu.Tag = "TPDepoRaporu" + i;
            page.Controls.Add(fDepoRaporu);
            fDepoRaporu.Show();
            i++;
        }

        private void ACEAracTanim_Click(object sender, EventArgs e)
        {

            XtraTabPage page = new XtraTabPage();
            fAracTanim = new FAracTanim();
            page.Name = "TPAracTanim" + i;
            page.Text = "Araç Tanım";
            page.Tag = "TPAracTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fAracTanim.FormBorderStyle = FormBorderStyle.None;
            fAracTanim.TopLevel = false;
            fAracTanim.AutoScroll = true;
            fAracTanim.Dock = DockStyle.Fill;
            fAracTanim.Tag = "TPAracTanim" + i;
            page.Controls.Add(fAracTanim);
            fAracTanim.Show();
            i++;
        }

        private void ACEAracRotaTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fAracRota = new FAracRota();
            page.Name = "TPAracRota" + i;
            page.Text = "Araç Rota";
            page.Tag = "TPAracRota" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fAracRota.FormBorderStyle = FormBorderStyle.None;
            fAracRota.TopLevel = false;
            fAracRota.AutoScroll = true;
            fAracRota.Dock = DockStyle.Fill;
            fAracRota.Tag = "TPAracRota" + i;
            page.Controls.Add(fAracRota);
            fAracRota.Show();
            i++;
        }

        private void ACEPersonelListe_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fPersonelList = new FPersonelList();
            page.Name = "TPPersonelList" + i;
            page.Text = "Personel Liste";
            page.Tag = "TPPersonelList" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fPersonelList.FormBorderStyle = FormBorderStyle.None;
            fPersonelList.TopLevel = false;
            fPersonelList.AutoScroll = true;
            fPersonelList.Dock = DockStyle.Fill;
            fPersonelList.Tag = "TPPersonelList" + i;
            page.Controls.Add(fPersonelList);
            fPersonelList.Show();
            i++;
        }

        private void ACEPersonelRaporu_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fPersonelRaporu = new FPersonelRaporu();
            page.Name = "TPPersonelRaporu" + i;
            page.Text = "Personel Raporu";
            page.Tag = "TPPersonelRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fPersonelRaporu.FormBorderStyle = FormBorderStyle.None;
            fPersonelRaporu.TopLevel = false;
            fPersonelRaporu.AutoScroll = true;
            fPersonelRaporu.Dock = DockStyle.Fill;
            fPersonelRaporu.Tag = "TPPersonelList" + i;
            page.Controls.Add(fPersonelRaporu);
            fPersonelRaporu.Show();
            i++;
        }

        private void ACEStokSevkiyatRaporu_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokSevkiyatRaporu = new FStokSevkiyatRaporu();
            page.Name = "TPStokSevkiyatRaporu" + i;
            page.Text = "Stok Sevkiyat Raporu";
            page.Tag = "TPStokSevkiyatRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokSevkiyatRaporu.FormBorderStyle = FormBorderStyle.None;
            fStokSevkiyatRaporu.TopLevel = false;
            fStokSevkiyatRaporu.AutoScroll = true;
            fStokSevkiyatRaporu.Dock = DockStyle.Fill;
            fStokSevkiyatRaporu.Tag = "TPStokSevkiyatRaporu" + i;
            page.Controls.Add(fStokSevkiyatRaporu);
            fStokSevkiyatRaporu.Show();
            i++;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ACEKasaKart_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKasaKart = new FKasaKart();
            page.Name = "TPKasaKart" + i;
            page.Text = "Kasa Kart";
            page.Tag = "TPKasaKart" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKasaKart.FormBorderStyle = FormBorderStyle.None;
            fKasaKart.TopLevel = false;
            fKasaKart.AutoScroll = true;
            fKasaKart.Dock = DockStyle.Fill;
            fKasaKart.Tag = "TPKasaKart" + i;
            page.Controls.Add(fKasaKart);
            fKasaKart.Show();
            i++;
        }

        private void ACEKasaHar_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKasaHareket = new FKasaHareket();
            page.Name = "TPKasaHareket" + i;
            page.Text = "Kasa Hareket";
            page.Tag = "TPKasaHareket" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKasaHareket.FormBorderStyle = FormBorderStyle.None;
            fKasaHareket.TopLevel = false;
            fKasaHareket.AutoScroll = true;
            fKasaHareket.Dock = DockStyle.Fill;
            fKasaHareket.Tag = "TPKasaHareket" + i;
            page.Controls.Add(fKasaHareket);
            fKasaHareket.Show();
            i++;
        }

        private void ACEBankaKart_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fBankaTanim = new FBankaTanim();
            page.Name = "TPBankaTanim" + i;
            page.Text = "Banka Tanım";
            page.Tag = "TPBankaTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fBankaTanim.FormBorderStyle = FormBorderStyle.None;
            fBankaTanim.TopLevel = false;
            fBankaTanim.AutoScroll = true;
            fBankaTanim.Dock = DockStyle.Fill;
            fBankaTanim.Tag = "TPBankaTanim" + i;
            page.Controls.Add(fBankaTanim);
            fBankaTanim.Show();
            i++;
        }

        private void ACESubeKart_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fBankaSubeTanim = new FBankaSubeTanim();
            page.Name = "TPBankaSubeTanim" + i;
            page.Text = "Sube Tanım";
            page.Tag = "TPBankaSubeTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fBankaSubeTanim.FormBorderStyle = FormBorderStyle.None;
            fBankaSubeTanim.TopLevel = false;
            fBankaSubeTanim.AutoScroll = true;
            fBankaSubeTanim.Dock = DockStyle.Fill;
            fBankaSubeTanim.Tag = "TPBankaSubeTanim" + i;
            page.Controls.Add(fBankaSubeTanim);
            fBankaSubeTanim.Show();
            i++;
        }

        private void ACEHesapKart_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fBankaHesapTanim = new FBankaHesapTanim();
            page.Name = "TPBankaHesapTanim" + i;
            page.Text = "Hesap Tanım";
            page.Tag = "TPBankaHesapTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fBankaHesapTanim.FormBorderStyle = FormBorderStyle.None;
            fBankaHesapTanim.TopLevel = false;
            fBankaHesapTanim.AutoScroll = true;
            fBankaHesapTanim.Dock = DockStyle.Fill;
            fBankaHesapTanim.Tag = "TPBankaHesapTanim" + i;
            page.Controls.Add(fBankaHesapTanim);
            fBankaHesapTanim.Show();
            i++;
        }

        private void ACEHesapHar_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fHesapHareket = new FHesapHareket();
            page.Name = "TPHesapHareket" + i;
            page.Text = "Hesap Hareket";
            page.Tag = "TPHesapHareket" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fHesapHareket.FormBorderStyle = FormBorderStyle.None;
            fHesapHareket.TopLevel = false;
            fHesapHareket.AutoScroll = true;
            fHesapHareket.Dock = DockStyle.Fill;
            fHesapHareket.Tag = "TPHesapHareket" + i;
            page.Controls.Add(fHesapHareket);
            fHesapHareket.Show();
            i++;
        }

        private void ACEMusteriCekTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriCekTanim = new FMusteriCekTanim();
            page.Name = "TPMusteriÇekTanım" + i;
            page.Text = "Müşteri Çek Tanım";
            page.Tag = "TPMusteriÇekTanım" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriCekTanim.FormBorderStyle = FormBorderStyle.None;
            fMusteriCekTanim.TopLevel = false;
            fMusteriCekTanim.AutoScroll = true;
            fMusteriCekTanim.Dock = DockStyle.Fill;
            fMusteriCekTanim.Tag = "TPMusteriÇekTanım" + i;
            page.Controls.Add(fMusteriCekTanim);
            fMusteriCekTanim.Show();
            i++;
        }

        private void ACEMCekCariCiro_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriCekCariCiro = new FMusteriCekCariCiro();
            page.Name = "TPMusteriÇekCariCiro" + i;
            page.Text = "Müşteri Çek Cari Ciro";
            page.Tag = "TPMusteriÇekCariCiro" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriCekCariCiro.FormBorderStyle = FormBorderStyle.None;
            fMusteriCekCariCiro.TopLevel = false;
            fMusteriCekCariCiro.AutoScroll = true;
            fMusteriCekCariCiro.Dock = DockStyle.Fill;
            fMusteriCekCariCiro.Tag = "TPMusteriÇekCariCiro" + i;
            page.Controls.Add(fMusteriCekCariCiro);
            fMusteriCekCariCiro.Show();
            i++;
        }

        private void ACEMSenetTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSenetTanim = new FMusteriSenetTanim();
            page.Name = "TPMusteriSenetTanım" + i;
            page.Text = "Müşteri Senet Tanım";
            page.Tag = "TPMusteriSenetTanım" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSenetTanim.FormBorderStyle = FormBorderStyle.None;
            fMusteriSenetTanim.TopLevel = false;
            fMusteriSenetTanim.AutoScroll = true;
            fMusteriSenetTanim.Dock = DockStyle.Fill;
            fMusteriSenetTanim.Tag = "TPMusteriSenetTanım" + i;
            page.Controls.Add(fMusteriSenetTanim);
            fMusteriSenetTanim.Show();
            i++;

        }

        private void ACEMSenetCariCiro_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSenetCariCiro = new FMusteriSenetCariCiro();
            page.Name = "TPMusteriSenetCariCiro" + i;
            page.Text = "Müşteri Senet Cari Ciro";
            page.Tag = "TPMusteriSenetCariCiro" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSenetCariCiro.FormBorderStyle = FormBorderStyle.None;
            fMusteriSenetCariCiro.TopLevel = false;
            fMusteriSenetCariCiro.AutoScroll = true;
            fMusteriSenetCariCiro.Dock = DockStyle.Fill;
            fMusteriSenetCariCiro.Tag = "TPMusteriSenetCariCiro" + i;
            page.Controls.Add(fMusteriSenetCariCiro);
            fMusteriSenetCariCiro.Show();
            i++;
        }

        private void ACEFCekTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFirmaCekTanim = new FFirmaCekTanim();
            page.Name = "TPFirmaCekTanim" + i;
            page.Text = "Firma Çek Tanım";
            page.Tag = "TPFirmaCekTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFirmaCekTanim.FormBorderStyle = FormBorderStyle.None;
            fFirmaCekTanim.TopLevel = false;
            fFirmaCekTanim.AutoScroll = true;
            fFirmaCekTanim.Dock = DockStyle.Fill;
            fFirmaCekTanim.Tag = "TPFirmaCekTanim" + i;
            page.Controls.Add(fFirmaCekTanim);
            fFirmaCekTanim.Show();
            i++;
        }

        private void ACEFSenetTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFirmaSenetTanim = new FFirmaSenetTanim();
            page.Name = "TPFirmaSenetTanim" + i;
            page.Text = "Firma Senet Tanım";
            page.Tag = "TPFirmaSenetTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFirmaSenetTanim.FormBorderStyle = FormBorderStyle.None;
            fFirmaSenetTanim.TopLevel = false;
            fFirmaSenetTanim.AutoScroll = true;
            fFirmaSenetTanim.Dock = DockStyle.Fill;
            fFirmaSenetTanim.Tag = "TPFirmaSenetTanim" + i;
            page.Controls.Add(fFirmaSenetTanim);
            fFirmaSenetTanim.Show();
            i++;
        }

        private void ACEMCekTahsilat_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriCekTahsilat = new FMusteriCekTahsilat();
            page.Name = "TPMusteriCekTahsilat" + i;
            page.Text = "Müşteri Çek Tahsilat";
            page.Tag = "TPMusteriCekTahsilat" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriCekTahsilat.FormBorderStyle = FormBorderStyle.None;
            fMusteriCekTahsilat.TopLevel = false;
            fMusteriCekTahsilat.AutoScroll = true;
            fMusteriCekTahsilat.Dock = DockStyle.Fill;
            fMusteriCekTahsilat.Tag = "TPMusteriCekTahsilat" + i;
            page.Controls.Add(fMusteriCekTahsilat);
            fMusteriCekTahsilat.Show();
            i++;
        }

        private void ACEMCekTeminat_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriCekTeminat = new FMusteriCekTeminat();
            page.Name = "TPMusteriCekTeminat" + i;
            page.Text = "Müşteri Çek Teminat";
            page.Tag = "TPMusteriCekTeminat" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriCekTeminat.FormBorderStyle = FormBorderStyle.None;
            fMusteriCekTeminat.TopLevel = false;
            fMusteriCekTeminat.AutoScroll = true;
            fMusteriCekTeminat.Dock = DockStyle.Fill;
            fMusteriCekTeminat.Tag = "TPMusteriCekTeminat" + i;
            page.Controls.Add(fMusteriCekTeminat);
            fMusteriCekTeminat.Show();
            i++;
        }

        private void ACEMCekProtesto_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriCekProtesto = new FMusteriCekProtesto();
            page.Name = "TPMusteriCekProtesto" + i;
            page.Text = "Müşteri Çek Protesto";
            page.Tag = "TPMusteriCekProtesto" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriCekProtesto.FormBorderStyle = FormBorderStyle.None;
            fMusteriCekProtesto.TopLevel = false;
            fMusteriCekProtesto.AutoScroll = true;
            fMusteriCekProtesto.Dock = DockStyle.Fill;
            fMusteriCekProtesto.Tag = "TPMusteriCekProtesto" + i;
            page.Controls.Add(fMusteriCekProtesto);
            fMusteriCekProtesto.Show();
            i++;
        }

        private void ACEMSenetTahsilat_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSenetTahsilat = new FMusteriSenetTahsilat();
            page.Name = "TPMusteriSenetTahsilat" + i;
            page.Text = "Müşteri Senet Tahsilat";
            page.Tag = "TPMusteriSenetTahsilat" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSenetTahsilat.FormBorderStyle = FormBorderStyle.None;
            fMusteriSenetTahsilat.TopLevel = false;
            fMusteriSenetTahsilat.AutoScroll = true;
            fMusteriSenetTahsilat.Dock = DockStyle.Fill;
            fMusteriSenetTahsilat.Tag = "TPMusteriSenetTahsilat" + i;
            page.Controls.Add(fMusteriSenetTahsilat);
            fMusteriSenetTahsilat.Show();
            i++;
        }

        private void ACEMSenetTeminat_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSenetTeminat = new FMusteriSenetTeminat();
            page.Name = "TPMusteriSenetTeminat" + i;
            page.Text = "Müşteri Senet Teminat";
            page.Tag = "TPMusteriSenetTeminat" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSenetTeminat.FormBorderStyle = FormBorderStyle.None;
            fMusteriSenetTeminat.TopLevel = false;
            fMusteriSenetTeminat.AutoScroll = true;
            fMusteriSenetTeminat.Dock = DockStyle.Fill;
            fMusteriSenetTeminat.Tag = "TPMusteriSenetTeminat" + i;
            page.Controls.Add(fMusteriSenetTeminat);
            fMusteriSenetTeminat.Show();
            i++;
        }

        private void ACEMSenetProtesto_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMusteriSenetProtesto = new FMusteriSenetProtesto();
            page.Name = "TPMusteriSenetProtesto" + i;
            page.Text = "Müşteri Senet Protesto";
            page.Tag = "TPMusteriSenetProtesto" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMusteriSenetProtesto.FormBorderStyle = FormBorderStyle.None;
            fMusteriSenetProtesto.TopLevel = false;
            fMusteriSenetProtesto.AutoScroll = true;
            fMusteriSenetProtesto.Dock = DockStyle.Fill;
            fMusteriSenetProtesto.Tag = "TPMusteriSenetProtesto" + i;
            page.Controls.Add(fMusteriSenetProtesto);
            fMusteriSenetProtesto.Show();
            i++;
        }

        private void ACEStokSarf_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fStokSarf = new FStokSarf();
            page.Name = "TPStokSarf" + i;
            page.Text = "Stok Sarfiyat";
            page.Tag = "TPStokSarf" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fStokSarf.FormBorderStyle = FormBorderStyle.None;
            fStokSarf.TopLevel = false;
            fStokSarf.AutoScroll = true;
            fStokSarf.Dock = DockStyle.Fill;
            fStokSarf.Tag = "TPStokSarf" + i;
            page.Controls.Add(fStokSarf);
            fStokSarf.Show();
            i++;
        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            stokkasa = new StokKasaGirisPanel();
            page.Name = "StokKasaGirisPanel" + i;
            page.Text = "Stok Kasa Girişi";
            page.Tag = "StokKasaGirisPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            stokkasa.FormBorderStyle = FormBorderStyle.None;
            stokkasa.TopLevel = false;
            stokkasa.AutoScroll = true;
            stokkasa.Dock = DockStyle.Fill;
            stokkasa.Tag = "StokKasaGirisPanel" + i;
            page.Controls.Add(stokkasa);
            stokkasa.Show();
            i++;
        }

        private void accordionControlElement64_Click(object sender, EventArgs e)
        {


        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fefatura = new EFATURA();
            page.Name = "EfaturaPanel" + i;
            page.Text = "Gelen Kutusu";
            page.Tag = "EfaturaPanel" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fefatura.FormBorderStyle = FormBorderStyle.None;
            fefatura.TopLevel = false;
            fefatura.AutoScroll = true;
            fefatura.Dock = DockStyle.Fill;
            fefatura.Tag = "EfaturaPanel" + i;
            page.Controls.Add(fefatura);
            fefatura.Show();
            i++;
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Mükellef listesi güncellenecektir, devam etmek istermisiniz?(Biraz zaman alabilir)", "Mükellef Listesi Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ServiceReference1.IntegrationClient ıntegrationClient = new ServiceReference1.IntegrationClient();
                ıntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
                ıntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
                ServiceReference1.WhoAmIInfo bb = new WhoAmIInfo();

                SystemUsersResponse res = ıntegrationClient.GetEInvoiceUsersAsync(new PagedQueryContext()
                {
                    PageIndex = 0,
                    PageSize = 999999,
                }).Result;
                if (res.Value.Items != null)
                {
                    _mükellefListesi.Data(ServisList.MUKELLEFLISTESIListeFiltreServis, null);

                    foreach (var item in res.Value.Items)
                    {


                        _mükellefListesi.Data(ServisList.MUKELLEFLISTESIEkleServis, new PocoMUKELLEFLISTESI()
                        {
                            cariadi = item.Title,
                            vkn = item.Identifier,
                            urn = item.PostboxAlias,
                            userid = MPKullanici.ID
                        });
                    }
                }
            }
        }

        private void ACECekListe_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFirmaCekListe = new FFirmaCekListe();
            page.Name = "FFirmaCekListe" + i;
            page.Text = "Firma Çek Liste";
            page.Tag = "FFirmaCekListe" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFirmaCekListe.FormBorderStyle = FormBorderStyle.None;
            fFirmaCekListe.TopLevel = false;
            fFirmaCekListe.AutoScroll = true;
            fFirmaCekListe.Dock = DockStyle.Fill;
            fFirmaCekListe.Tag = "FFirmaCekListe" + i;
            page.Controls.Add(fFirmaCekListe);
            fFirmaCekListe.Show();
            i++;
        }

        private void ACECekSenetDurum_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fCekSenetDurum = new FCekSenetDurum();
            page.Name = "FCekSenetDurum" + i;
            page.Text = "Çek Senet Durum";
            page.Tag = "FCekSenetDurum" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fCekSenetDurum.FormBorderStyle = FormBorderStyle.None;
            fCekSenetDurum.TopLevel = false;
            fCekSenetDurum.AutoScroll = true;
            fCekSenetDurum.Dock = DockStyle.Fill;
            fCekSenetDurum.Tag = "FCekSenetDurum" + i;
            page.Controls.Add(fCekSenetDurum);
            fCekSenetDurum.Show();
            i++;
        }

        private void ACEKullaniciTanim_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKullaniciTanim = new FKullaniciTanim();
            page.Name = "FKullaniciTanim" + i;
            page.Text = "Kullanıcı Tanım";
            page.Tag = "FKullaniciTanim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKullaniciTanim.FormBorderStyle = FormBorderStyle.None;
            fKullaniciTanim.TopLevel = false;
            fKullaniciTanim.AutoScroll = true;
            fKullaniciTanim.Dock = DockStyle.Fill;
            fKullaniciTanim.Tag = "FKullaniciTanim" + i;
            page.Controls.Add(fKullaniciTanim);
            fKullaniciTanim.Show();
            i++;
        }

        private void ACEKullanici_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fKullaniciYonetim = new FKullaniciYonetim();
            page.Name = "FKullaniciYonetim" + i;
            page.Text = "Kullanıcı Yönetim";
            page.Tag = "FKullaniciYonetim" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fKullaniciYonetim.FormBorderStyle = FormBorderStyle.None;
            fKullaniciYonetim.TopLevel = false;
            fKullaniciYonetim.AutoScroll = true;
            fKullaniciYonetim.Dock = DockStyle.Fill;
            fKullaniciYonetim.Tag = "FKullaniciYonetim" + i;
            page.Controls.Add(fKullaniciYonetim);
            fKullaniciYonetim.Show();
            i++;
        }

        private void accordionControlElement65_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGidenEFatura = new FGidenEFatura();
            page.Name = "FGidenEFatura" + i;
            page.Text = "Giden Fatura";
            page.Tag = "FGidenEFatura" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGidenEFatura.FormBorderStyle = FormBorderStyle.None;
            fGidenEFatura.TopLevel = false;
            fGidenEFatura.AutoScroll = true;
            fGidenEFatura.Dock = DockStyle.Fill;
            fGidenEFatura.Tag = "FGidenEFatura" + i;
            page.Controls.Add(fGidenEFatura);
            fGidenEFatura.Show();
            i++;
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            eFaturaParams = new EFaturaParams();
            page.Name = "EFaturaParams" + i;
            page.Text = "EFatura Parametre";
            page.Tag = "EFaturaParams" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            eFaturaParams.FormBorderStyle = FormBorderStyle.None;
            eFaturaParams.TopLevel = false;
            eFaturaParams.AutoScroll = true;
            eFaturaParams.Dock = DockStyle.Fill;
            eFaturaParams.Tag = "EFaturaParams" + i;
            page.Controls.Add(eFaturaParams);
            eFaturaParams.Show();
            i++;
        }

        private void accordionControlElement66_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGidenEArsiv = new FGidenEArsiv();
            page.Name = "FGidenEArsiv" + i;
            page.Text = "Giden EArşiv";
            page.Tag = "FGidenEArsiv" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGidenEArsiv.FormBorderStyle = FormBorderStyle.None;
            fGidenEArsiv.TopLevel = false;
            fGidenEArsiv.AutoScroll = true;
            fGidenEArsiv.Dock = DockStyle.Fill;
            fGidenEArsiv.Tag = "FGidenEArsiv" + i;
            page.Controls.Add(fGidenEArsiv);
            fGidenEArsiv.Show();
            i++;
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGidenEIrsaliye = new FGidenEIrsaliye();
            page.Name = "FGidenEIrsaliye" + i;
            page.Text = "Giden EIrsaliye";
            page.Tag = "FGidenEIrsaliye" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGidenEIrsaliye.FormBorderStyle = FormBorderStyle.None;
            fGidenEIrsaliye.TopLevel = false;
            fGidenEIrsaliye.AutoScroll = true;
            fGidenEIrsaliye.Dock = DockStyle.Fill;
            fGidenEIrsaliye.Tag = "FGidenEIrsaliye" + i;
            page.Controls.Add(fGidenEIrsaliye);
            fGidenEIrsaliye.Show();
            i++;
        }

        private void ACEMustahsilMakbuz_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMustahsilMakbuz = new FMustahsil();
            page.Name = "FMustahsil" + i;
            page.Text = "Müstahsil Makbuzu";
            page.Tag = "FMustahsil" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMustahsilMakbuz.FormBorderStyle = FormBorderStyle.None;
            fMustahsilMakbuz.TopLevel = false;
            fMustahsilMakbuz.AutoScroll = true;
            fMustahsilMakbuz.Dock = DockStyle.Fill;
            fMustahsilMakbuz.Tag = "FMustahsil" + i;
            page.Controls.Add(fMustahsilMakbuz);
            fMustahsilMakbuz.Show();
            i++;
        }

        private void ACEEMustahsilGiden_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGidenEMustahsil = new FGidenEMustahsil();
            page.Name = "FGidenEMustahsil" + i;
            page.Text = "Giden Müstahsil Makbuzu";
            page.Tag = "FGidenEMustahsil" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGidenEMustahsil.FormBorderStyle = FormBorderStyle.None;
            fGidenEMustahsil.TopLevel = false;
            fGidenEMustahsil.AutoScroll = true;
            fGidenEMustahsil.Dock = DockStyle.Fill;
            fGidenEMustahsil.Tag = "FGidenEMustahsil" + i;
            page.Controls.Add(fGidenEMustahsil);
            fGidenEMustahsil.Show();
            i++;
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement61_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fFATURASTOKOLCUESLE = new FFATURASTOKOLCUESLE();
            page.Name = "FFATURASTOKOLCUESLE" + i;
            page.Text = "STOK OLCU BIRIM ESLE";
            page.Tag = "FFATURASTOKOLCUESLE" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fFATURASTOKOLCUESLE.FormBorderStyle = FormBorderStyle.None;
            fFATURASTOKOLCUESLE.TopLevel = false;
            fFATURASTOKOLCUESLE.AutoScroll = true;
            fFATURASTOKOLCUESLE.Dock = DockStyle.Fill;
            fFATURASTOKOLCUESLE.Tag = "FFATURASTOKOLCUESLE" + i;
            page.Controls.Add(fFATURASTOKOLCUESLE);
            fFATURASTOKOLCUESLE.Show();
            i++;
        }


        private void ACEDestekServis1_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fDestekServis = new FDestekServis();
            page.Name = "FDestekServis" + i;
            page.Text = "Destek Servis";
            page.Tag = "FDestekServis" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fDestekServis.FormBorderStyle = FormBorderStyle.None;
            fDestekServis.TopLevel = false;
            fDestekServis.AutoScroll = true;
            fDestekServis.Dock = DockStyle.Fill;
            fDestekServis.Tag = "FDestekServis" + i;
            page.Controls.Add(fDestekServis);
            fDestekServis.Show();
            i++;
        }

        private void ACEMobilizWeb_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fMobilizWeb = new FMobilizWeb();
            page.Name = "FMobilizWeb" + i;
            page.Text = "Mobiliz Web";
            page.Tag = "FMobilizWeb" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fMobilizWeb.FormBorderStyle = FormBorderStyle.None;
            fMobilizWeb.TopLevel = false;
            fMobilizWeb.AutoScroll = true;
            fMobilizWeb.Dock = DockStyle.Fill;
            fMobilizWeb.Tag = "FMobilizWeb" + i;
            page.Controls.Add(fMobilizWeb);
            fMobilizWeb.Show();
            i++;
        }
        private void accordionControlElement22_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGELENIRSALIYE = new FGELENIRSALIYE();
            page.Name = "FGelenIrsaliye" + i;
            page.Text = "Gelen Irsaliye";
            page.Tag = "FGelenIrsaliye" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGELENIRSALIYE.FormBorderStyle = FormBorderStyle.None;
            fGELENIRSALIYE.TopLevel = false;
            fGELENIRSALIYE.AutoScroll = true;
            fGELENIRSALIYE.Dock = DockStyle.Fill;
            fGELENIRSALIYE.Tag = "FGelenIrsaliye" + i;
            page.Controls.Add(fGELENIRSALIYE);
            fGELENIRSALIYE.Show();
            i++;
        }

        private void accordionControlElement71_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fGindeFaturaEşleştir = new  FGindeFaturaEşleştir();
            page.Name = "FGidenFaturaEslestir" + i;
            page.Text = "Giden Fatura Eşleştir";
            page.Tag = "FGidenFaturaEslestir" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            Anasayfa.TabPages.Add(page);
            Anasayfa.SelectedTabPage = page;

            fGindeFaturaEşleştir.FormBorderStyle = FormBorderStyle.None;
            fGindeFaturaEşleştir.TopLevel = false;
            fGindeFaturaEşleştir.AutoScroll = true;
            fGindeFaturaEşleştir.Dock = DockStyle.Fill;
            fGindeFaturaEşleştir.Tag = "FGidenFaturaEslestir" + i;
            page.Controls.Add(fGindeFaturaEşleştir);
            fGindeFaturaEşleştir.Show();
            i++;
        }
    }
}

