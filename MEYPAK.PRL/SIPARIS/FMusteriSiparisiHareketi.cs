using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.IRSALIYE;
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
            GCSiparis.DataSource = _siparisServis.Listele();
           
            
        }

        private void BTNSiparisFiltrele_Click(object sender, EventArgs e)
        {
            GCSiparis.DataSource = "";
            mpSiparis = _siparisServis.Listele().Where(x => (DateTime)x.siparistarihi >=DTItibarenTar.Value).ToList();
            mpSiparis = mpSiparis.Where(x => (DateTime)x.siparistarihi <=DTKadarTar.Value).ToList();
            GCSiparis.DataSource=mpSiparis;
        }

        private void dataGridSiparis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _mpSiparisDetay= _siparisdetayServis.Getir(x => x.siparisid == (int)GCSiparis.Rows[e.RowIndex].Cells[0].Value);
            GCSiparisDetay.DataSource = _mpSiparisDetay;
            GridYapılandır();
        }

        private void dataGridSiparisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LBSiparisMiktar.Text = GCSiparisDetay.Rows[e.RowIndex].Cells["MIKTAR"].Value.ToString();
            LBBekleyenMiktar.Text= GCSiparisDetay.Rows[e.RowIndex].Cells["BEKLEYENMIKTAR"].Value.ToString();
            var a = Enum.GetNames(typeof(SiparisDurum));
            LBDurum.Text = a[(byte)GCSiparisDetay.Rows[e.RowIndex].Cells["HAREKETDURUMU"].Value];
        }
        
        private void BTNIrsaliyeOlustur_Click(object sender, EventArgs e)
        {
            FSatisIrsaliye fIrsaliyeOlustur = new FSatisIrsaliye();
            foreach (DataGridViewRow item in GCSiparisDetay.Rows)
            {
                if (Convert.ToBoolean(item.Cells["DVGCheckBox"].Value) == true)
                {
                    // fIrsaliyeOlustur._tempIrsaliyeDetay.Add(_mpSiparisDetay.Where(x => x.ID == (int)item.Cells["ID"].Value).FirstOrDefault());
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


            GCSiparisDetay.Columns.Add(DVGCheckBox);
            GCSiparisDetay.Columns["DVGCheckBox"].DisplayIndex = 0;
        }

        
    }
}
