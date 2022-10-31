
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Pkcs;
using DevExpress.XtraEditors;


using MEYPAK.BLL.Assets;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
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
            fStokHareket = new FStokHareket();
            fSTOKKART = new FStokKart();
            fDepoKart = new FDepoKart();
            fStokSayim=new FStokSayim();
            fOlcuBrKart = new FOlcuBrKart();
            fSayimIsle = new FSayimIsle();
            fSiparis = new FMusteriSiparis();
            fSevkiyatPanel= new FSevkiyatPanel();
            fMalKabulPanel = new FMalKabulPanel();
            fSatınAlmaSiparis = new FSatınAlmaSiparis();
            fStokFiyatList = new FStokFiyatList();
            fCariHareket = new FCariHareket();
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
        FMalKabulPanel fMalKabulPanel;
        FSatınAlmaSiparis fSatınAlmaSiparis;
        FStokFiyatList fStokFiyatList;
        FCariHareket fCariHareket;
        #endregion
        void StokPanelAc()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StokPanelAc();
        }

        private void stokKartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StokPanelAc();
        }

        private void markaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokHareketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fStokHareket.TopLevel = false;
            //fStokHareket.AutoScroll = true;
            //fStokHareket.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fStokHareket);
            //fStokHareket.Show();
        }

        private void depoTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fDepoKart.TopLevel = false;
            //fDepoKart.AutoScroll = true;
            //fDepoKart.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fDepoKart);
            //fDepoKart.Show();
        }

        private void stokSayımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fStokSayim.TopLevel = false;
            //fStokSayim.AutoScroll = true;
            //fStokSayim.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fStokSayim);
            //fStokSayim.Show();
        }

        private void ölçüBirimTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    panel2.Controls.Clear();
        //    fOlcuBrKart.TopLevel = false;
        //    fOlcuBrKart.AutoScroll = true;
        //    fOlcuBrKart.Dock = DockStyle.Fill;
        //    panel2.Controls.Add(fOlcuBrKart);
        //    fOlcuBrKart.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sayımİşleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fSayimIsle.TopLevel = false;
            //fSayimIsle.AutoScroll = true;
            //fSayimIsle.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fSayimIsle);
            //fSayimIsle.Show();
        }

        private void siparişTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fSiparis.TopLevel = false;
            //fSiparis.AutoScroll = true;
            //fSiparis.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fSiparis);
            //fSiparis.Show();
        }

        private void sevkiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fSevkiyatPanel.TopLevel = false;
            //fSevkiyatPanel.AutoScroll = true;
            //fSevkiyatPanel.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fSevkiyatPanel);
            //fSevkiyatPanel._siparisServis.Data(ServisList.SiparisListeServis);
            //fSevkiyatPanel._depoEmirServis.Data(ServisList.DepoEmirListeServis);
            //fSevkiyatPanel.dataGridView1.DataSource = fSevkiyatPanel._siparisServis.obje.Where(x => x.TIP == 0).Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
            //fSevkiyatPanel._siparisServis.Data(ServisList.SiparisListeServis);

            //fSevkiyatPanel.dataGridView2.DataSource = fSevkiyatPanel._depoEmirServis.obje.Select(x => new { x.ID, BELGENO = fSevkiyatPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO, x.MIKTAR, CARIADI = fSevkiyatPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().CARIADI, DEPO = fSevkiyatPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().DEPOID, x.TIP, x.DURUM }).ToList();
            //fSevkiyatPanel.dataGridView2.Refresh();
            //fSevkiyatPanel.Show();
        }

        private void malKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fMalKabulPanel.TopLevel = false;
            //fMalKabulPanel.AutoScroll = true;
            //fMalKabulPanel.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fMalKabulPanel);
            //fMalKabulPanel._siparisServis.Data(ServisList.SiparisListeServis);
            //fMalKabulPanel._siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            //fMalKabulPanel._depoEmirServis.Data(ServisList.DepoEmirListeServis);
            //fMalKabulPanel._siparisServis.Data(ServisList.SiparisListeServis);
            //fMalKabulPanel.dataGridView1.DataSource = fMalKabulPanel._siparisServis.obje.Where(x => x.TIP == 1).Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
            //fMalKabulPanel.dataGridView2.DataSource = fMalKabulPanel._depoEmirServis.obje.Select(x => new { x.ID, BELGENO = fMalKabulPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().BELGENO, x.MIKTAR, CARIADI = fMalKabulPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().CARIADI, DEPO = fMalKabulPanel._siparisServis.obje.Where(z => z.ID == x.SIPARISID).FirstOrDefault().DEPOID, x.TIP, x.DURUM }).ToList();
            //fMalKabulPanel.dataGridView2.Refresh();
            //fMalKabulPanel.Show();
        }
        private void satınAlmaSiparişTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fSatınAlmaSiparis.TopLevel = false;
            //fSatınAlmaSiparis.AutoScroll = true;
            //fSatınAlmaSiparis.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fSatınAlmaSiparis);
            //fSatınAlmaSiparis.Show();
        }

        private void stokListeFiyatTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //fStokFiyatList.TopLevel = false;
            //fStokFiyatList.AutoScroll = true;
            //fStokFiyatList.Dock = DockStyle.Fill;
            //panel2.Controls.Add(fStokFiyatList);
            //fStokFiyatList.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fSTOKKART.TopLevel = false;
            fSTOKKART.AutoScroll = true;
            fSTOKKART.Dock = DockStyle.Fill;
            panel2.Controls.Add(fSTOKKART);
            fSTOKKART.Show();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fStokHareket.TopLevel = false;
            fStokHareket.AutoScroll = true;
            fStokHareket.Dock = DockStyle.Fill;
            panel2.Controls.Add(fStokHareket);
            fStokHareket.Show();
        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fStokSayim.TopLevel = false;
            fStokSayim.AutoScroll = true;
            fStokSayim.Dock = DockStyle.Fill;
            panel2.Controls.Add(fStokSayim);
            fStokSayim.Show();
        }

        private void accordionControlElement30_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fCariHareket.TopLevel = false;
            fCariHareket.AutoScroll = true;
            fCariHareket.Dock = DockStyle.Fill;
            panel2.Controls.Add(fCariHareket);
            fCariHareket.Show();
        }
    }
}
