using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets;
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

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparisiHareketi : Form
    {
        public FMusteriSiparisiHareketi()
        {
            InitializeComponent();
        }
        ISiparisServis _siparisServis ;
        ISiparisDetayServis _siparisdetayServis ;
        List<PocoSIPARIS> mpSiparis ;
        List<PocoSIPARISDETAY> _mpSiparisDetay;

        private void FSiparisIrsaliyelestir_Load(object sender, EventArgs e)
        {
            dataGridSiparis.DataSource = _siparisServis.Listele();
           
            
        }

        private void BTNSiparisFiltrele_Click(object sender, EventArgs e)
        {
            dataGridSiparis.DataSource = "";
            mpSiparis = _siparisServis.Listele().Where(x => (DateTime)x.SIPARISTARIHI>=dateTimePicker1.Value).ToList();
            mpSiparis = mpSiparis.Where(x => (DateTime)x.SIPARISTARIHI<=dateTimePicker2.Value).ToList();
            dataGridSiparis.DataSource=mpSiparis;
        }

        private void dataGridSiparis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _mpSiparisDetay= _siparisdetayServis.Getir(x => x.SIPARISID == (int)dataGridSiparis.Rows[e.RowIndex].Cells[0].Value);
            dataGridSiparisDetay.DataSource = _mpSiparisDetay;
            GridYapılandır();
        }

        private void dataGridSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            LBLSiparisMik.Text = dataGridSiparisDetay.Rows[e.RowIndex].Cells["MIKTAR"].Value.ToString();
            LBLBekleyenMik.Text= dataGridSiparisDetay.Rows[e.RowIndex].Cells["BEKLEYENMIKTAR"].Value.ToString();
            var a = Enum.GetNames(typeof(SiparisDurum));
            LBLDurum.Text = a[(byte)dataGridSiparisDetay.Rows[e.RowIndex].Cells["HAREKETDURUMU"].Value];
        }
        
        private void BTNIrsaliyeOlustur_Click(object sender, EventArgs e)
        {
            FIrsaliyeOlustur fIrsaliyeOlustur = new FIrsaliyeOlustur();
            foreach (DataGridViewRow item in dataGridSiparisDetay.Rows)
            {
                if (Convert.ToBoolean(item.Cells["DVGCheckBox"].Value) == true)
                {
                     fIrsaliyeOlustur._tempSiparisDetay.Add(_mpSiparisDetay.Where(x => x.ID == (int)item.Cells["ID"].Value).FirstOrDefault());
                }
            }
            fIrsaliyeOlustur.ShowDialog();
        }

        void GridYapılandır()
        {
            DataGridViewCheckBoxColumn DVGCheckBox = new DataGridViewCheckBoxColumn();
            DVGCheckBox.FlatStyle = FlatStyle.Flat;
            DVGCheckBox.ValueType = typeof(bool);
            DVGCheckBox.Name = "DVGCheckBox";
            DVGCheckBox.HeaderText = "Seç";
            DVGCheckBox.FalseValue = false;
            DVGCheckBox.TrueValue = true;


            dataGridSiparisDetay.Columns.Add(DVGCheckBox);
            dataGridSiparisDetay.Columns["DVGCheckBox"].DisplayIndex = 0;
        }
    }
}
