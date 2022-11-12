using DevExpress.Text.Interop;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PARAMETRELER
{
    public partial class FParaBirimi : Form
    {
      
            string islemtipi = "Kayıt";
            public FParaBirimi()
            {
                InitializeComponent();
                _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            }
            GenericWebServis<PocoPARABIRIM> _paraBirimServis;
            private void FParaBirimi_Load(object sender, EventArgs e)
            {
                DataGridDoldur();
            }
            int id;

            void DataGridDoldur()
            {
                _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
                DGParaBrm.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0).Select(x => new { x.id, x.adi, x.kisaadi, x.olusturmatarihi });
            DGParaBrm.Refresh();
            DGParaBrm.RefreshDataSource();
            }

            private void gridView1_DoubleClick(object sender, EventArgs e)
            {
                TBParaBrm.Text = gridView1.GetFocusedRowCellValue("adi").ToString();
                TBKisaltma.Text = gridView1.GetFocusedRowCellValue("birim").ToString();
                id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
                islemtipi = "Güncelleme";
            }

            private void BTKaydet_Click(object sender, EventArgs e)
            {
                if (islemtipi == "Kayıt")
                {
                    _paraBirimServis.Data(ServisList.ParaBirimiEkleServis, (new PocoPARABIRIM()
                    {
                        adi = TBParaBrm.Text,
                        kisaadi = TBKisaltma.Text,
                    }));

                }
                else
                    _paraBirimServis.Data(ServisList.ParaBirimiEkleServis, (new PocoPARABIRIM()
                    {
                        id = id,
                        adi = TBParaBrm.Text,
                        kisaadi = TBKisaltma.Text,
                    }));
                MessageBox.Show("Kayıt Başarılı.");
                id = 0;
                DataGridDoldur();
            }

            private void BTSil_Click(object sender, EventArgs e)
            {
                _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiSilServis, null, null, _paraBirimServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).ToList());
                MessageBox.Show("Silme Başarılı");
                DGParaBrm.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0);
                DataGridDoldur();
            }
        }

    }

