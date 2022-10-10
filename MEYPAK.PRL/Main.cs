using MEYPAK.Interfaces;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class Main : Form
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
            fSiparis = new FSiparis();
            fSevkiyatPanel= new FSevkiyatPanel();
        }
        #region TANIMLAR
        FSevkiyatPanel fSevkiyatPanel;
        FOlcuBrKart fOlcuBrKart;
        FStokKart fSTOKKART;
        FStokHareket fStokHareket;
        FDepoKart fDepoKart;
        FStokSayim fStokSayim;
        FSayimIsle fSayimIsle;
        FSiparis fSiparis;
        #endregion
        void StokPanelAc()
        {
            panel2.Controls.Clear();
            fSTOKKART.TopLevel = false;
            fSTOKKART.AutoScroll = true;
            fSTOKKART.Dock = DockStyle.Fill;
            panel2.Controls.Add(fSTOKKART);
            fSTOKKART.Show();
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
            panel2.Controls.Clear();
            fStokHareket.TopLevel = false;
            fStokHareket.AutoScroll = true;
            fStokHareket.Dock = DockStyle.Fill;
            panel2.Controls.Add(fStokHareket);
            fStokHareket.Show();
        }

        private void depoTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fDepoKart.TopLevel = false;
            fDepoKart.AutoScroll = true;
            fDepoKart.Dock = DockStyle.Fill;
            panel2.Controls.Add(fDepoKart);
            fDepoKart.Show();
        }

        private void stokSayımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fStokSayim.TopLevel = false;
            fStokSayim.AutoScroll = true;
            fStokSayim.Dock = DockStyle.Fill;
            panel2.Controls.Add(fStokSayim);
            fStokSayim.Show();
        }

        private void ölçüBirimTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fOlcuBrKart.TopLevel = false;
            fOlcuBrKart.AutoScroll = true;
            fOlcuBrKart.Dock = DockStyle.Fill;
            panel2.Controls.Add(fOlcuBrKart);
            fOlcuBrKart.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sayımİşleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fSayimIsle.TopLevel = false;
            fSayimIsle.AutoScroll = true;
            fSayimIsle.Dock = DockStyle.Fill;
            panel2.Controls.Add(fSayimIsle);
            fSayimIsle.Show();
        }

        private void siparişTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fSiparis.TopLevel = false;
            fSiparis.AutoScroll = true;
            fSiparis.Dock = DockStyle.Fill;
            panel2.Controls.Add(fSiparis);
            fSiparis.Show();
        }

        private void sevkiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fSevkiyatPanel.TopLevel = false;
            fSevkiyatPanel.AutoScroll = true;
            fSevkiyatPanel.Dock = DockStyle.Fill;
            panel2.Controls.Add(fSevkiyatPanel);
            fSevkiyatPanel.Show();
        }
    }
}
