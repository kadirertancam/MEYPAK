
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Pkcs;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using MEYPAK.BLL.Assets;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.PERSONEL;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        #region TANIMLAR
        FSevkiyatPanel fSevkiyatPanel;
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
        #endregion
        void StokPanelAc()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StokPanelAc();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
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
    }
}
