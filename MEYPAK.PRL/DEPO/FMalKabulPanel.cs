using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels;
using MEYPAK.PRL.Assets.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulPanel : Form
    {
        public FMalKabulPanel()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(105, 105, 105);
            dataGridView2.EnableHeadersVisualStyles = false;
            DGVTopla = new DataGridViewButtonColumn();
            _sevkiyatCekiPanel = new FSevkiyatCekiPanel();
        }
        DataGridViewButtonColumn DGVTopla;
        List<MPSIPARIS> _tempSiparis;
        FSevkiyatCekiPanel _sevkiyatCekiPanel;
        List<MPSIPARISDETAY> _tempSTOKSEVK;
        List<MPSIPARISDETAY> _tempSiparisDetay;
        private void FMalKabulPanel_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= StaticContext._siparisServis.Listele().Where(x => x.TIP == 1).Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
            DGVTopla.Name = "DGVOnay";
            DGVTopla.HeaderText = "Onayla";
            DGVTopla.DisplayIndex = 3;
            DGVTopla.FlatStyle = FlatStyle.Flat;
            DGVTopla.CellTemplate.Style.ForeColor = Color.Aqua;
            DGVTopla.CellTemplate.Style.SelectionForeColor = Color.Aqua;
            DGVTopla.Text = "Onayla";
            DGVTopla.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(DGVTopla);
            dataGridView1.Columns["DGVOnay"].DefaultCellStyle.ForeColor = Color.Aqua;
            dataGridView2.DataSource = StaticContext._depoEmirServis.Listele().Where(x=>x.TIP==1).Select(x => new { x.ID, x.MPSIPARIS.BELGENO, x.MIKTAR, x.MPSIPARIS.CARIADI, x.MPSIPARIS.DEPOID, x.TIP, x.DURUM }).ToList();
            dataGridView2.Refresh();
        }
    }
}
