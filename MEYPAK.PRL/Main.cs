
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Pkcs;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets.Kur;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.PARAMETRELER;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
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
        FStokFiyatList fStokFiyatList;
        FCariHareket fCariHareket;
        FCariDurum fCariDurum;
        FCariKart fCariKart;
        FCariAltHesap fCariAltHesap;
        FPersonelKart fPersonelKart;
        FStokKasaPanel fKasaPanel;
        FParaBirimi fParaBirimi;
        FFatura ffatura;
        FKasaTakip fStokKasaHareket;
        FKasaMarka fKasaMarka;
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
        public void GuncelKur() {
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
            _tarih_Date = (Tarih_Date)xmlSerializerHelper.DeserializeFromXml(typeof(Tarih_Date),aaaa);
            _parabirimServis.Data(ServisList.ParaBirimiListeServis);
            foreach (var item in _tarih_Date.Currency)
            {
                if(_parabirimServis.obje.Where(x => x.adi == item.Isim).Count()>0)
                _parabirimServis.Data(ServisList.ParaBirimiEkleServis, new PocoPARABIRIM()
                {
                    id= _parabirimServis.obje.Where(x => x.adi == item.Isim).FirstOrDefault().id,
                    adi = item.Isim,
                    kisaadi = item.Kod,
                    dovizsatis = Convert.ToDecimal(item.ForexSelling==""?"0":item.ForexSelling),
                    dovizalis = item.ForexBuying,
                    dovizefektifalis = Convert.ToDecimal(item.BanknoteBuying==""?"0":item.BanknoteBuying),
                    dovizefektifsatis = Convert.ToDecimal(item.BanknoteSelling==""?"0":item.BanknoteSelling),


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
            guncelkur = CurrenciesExchange.GetDataTableAllCurrenciesTodaysExchangeRates();
            GuncelKur();
        }

        int i = 0;
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            XtraTabPage page = new XtraTabPage();
            fSTOKKART = new FStokKart(); 
            page.Name = "TPStokKart"+i;
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
            fStokHareket.Tag= "TPStokHareket" + i;
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
                if((arg.Page as XtraTabPage).Tag== frm.Tag)
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
            fSiparis.Tag= "TPMusteriSiparis" + i;
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
            fStokKasaHareket = new FKasaTakip();
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
    }
}
