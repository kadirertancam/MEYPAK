
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Pkcs;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets.Kur;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.CARI.Raporlar;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL.STOK.FiyatListesi;
using MEYPAK.PRL.STOK.Raporlar;
using MEYPAK.PRL.STOK.StokKasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MEYPAK.PRL
{
    public partial class Main : XtraForm
    {
        public Main()
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
            _parabirimServis = new GenericWebServis<PocoPARABIRIM>();
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
        FAlisIrsaliye fFAlisIrsaliye;
        FAlisFatura fFAlisFatura;
        FMusteriSiparisIrsaliyelestir fMusteriSiparisIrsaliyelestir;
        FSeriTanim fSeriTanim;
        
        FStokHareketRaporu fStokHareketRaporu;
        FStokFiyatRaporu fStokFiyatRaporu;
        FStokSayimRaporu fStokSayimRaporu;
        FStokListesiRaporu fStokListesiRaporu;
        FCariHareketRaporu fCariHareketRaporu;
        FStokKategoriRaporu fStokKategoriRaporu;
        FStokKasaHareketRaporu fStokKasaHarRaporu;


        public Tarih_Date _tarih_Date;
        public DataTable guncelkur;
        GenericWebServis<PocoPARABIRIM> _parabirimServis;
        #endregion
        void StokPanelAc()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StokPanelAc();
        }
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


                        });
                }
            }
            catch
            {

            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //guncelkur = CurrenciesExchange.GetDataTableAllCurrenciesTodaysExchangeRates();
            //GuncelKur();
        }

        int i = 0;
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSTOKKART = new FStokKart();
            page.Name = "TPStokKart" + i;
            page.Text = "Stok Kart";
            page.Tag = "TPStokKart" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;
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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;
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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;
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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            fStokListesiRaporu = new FStokListesiRaporu(islem: "FStokListesiRaporu");
            page.Name = "TPStokListesiRaporu" + i;
            page.Text = "Stok Listesi Raporu";
            page.Tag = "TPStokListesiRaporu" + i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

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
            xtraTabControl1.TabPages.Add(page);
            xtraTabControl1.SelectedTabPage = page;

            fSeriTanim.FormBorderStyle = FormBorderStyle.None;
            fSeriTanim.TopLevel = false;
            fSeriTanim.AutoScroll = true;
            fSeriTanim.Dock = DockStyle.Fill;
            fSeriTanim.Tag = "TPSeriTanım" + i;
            page.Controls.Add(fSeriTanim);
            fSeriTanim.Show();
            i++;
        }
    }
}
