using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
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
            _fMalKabulCekiPanel = new FMalKabulCekiPanel();
        }
        DataGridViewButtonColumn DGVTopla;
        List<PocoSIPARIS> _tempSiparis;
        FMalKabulCekiPanel _fMalKabulCekiPanel;
        List<PocoSIPARISDETAY> _tempSTOKSEVK;
        List<PocoSIPARISDETAY> _tempSiparisDetay;
        ISiparisServis _siparisServis;
        IDepoEmirServis _depoEmirServis;
        private void FMalKabulPanel_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= _siparisServis.Listele().Where(x => x.TIP == 1).Select(x => new { x.SEVKIYATTARIHI, x.BELGENO, x.CARIADI }).ToList();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _tempSiparisDetay = StaticContext._siparisDetayServis.Listele().Where(x => x.MPSIPARIS.BELGENO.ToString() == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).ToList();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVOnay")
            {
                int i = 1;
                var a = _depoEmirServis.Ekle(new PocoDEPOEMIR()
                {
                    SIPARISID = StaticContext._siparisServis.Listele().Where(x => x.BELGENO == dataGridView1.Rows[e.RowIndex].Cells["BELGENO"].Value.ToString()).FirstOrDefault().ID,
                    MIKTAR = _tempSiparisDetay.Sum(x => x.MIKTAR),
                    SIRA = i,
                    TARIH = DateTime.Now,
                    TIP = 1,   /// TOPLAMA EMRİ TIPI OUTPUT =0 INPUT=1
                    DURUM = 1,
                    ACIKLAMA = ""



                });
                dataGridView2.DataSource = StaticContext._depoEmirServis.Listele().Select(x => new { x.ID, x.MPSIPARIS.BELGENO, x.MIKTAR, x.MPSIPARIS.CARIADI, x.MPSIPARIS.DEPOID, x.TIP, x.DURUM }).ToList();
                dataGridView2.Refresh();
                foreach (var item in _tempSiparisDetay.Where(x => x.HAREKETDURUMU == 0).ToList())
                {
                    item.HAREKETDURUMU = 1;
                    StaticContext._siparisDetayServis.Guncelle(item);


                    StaticContext._siparisSevkEmriHarServis.Ekle(new PocoSIPARISSEVKEMIRHAR()
                    {
                        EMIRMIKTARI = a.MIKTAR,
                        SIPARISID = a.SIPARISID,
                        SIPARISKALEMID = item.ID,
                        EMIRID = a.ID,
                        SIPARISMIKTARI = _tempSiparisDetay.Sum(x => x.MIKTAR),
                        KULLANICIID = 0,
                        TARIH = DateTime.Now

                    });


                    dataGridView3.DataSource = StaticContext._siparisSevkEmriHarServis.Listele();
                    dataGridView3.Refresh();
                    i++;
                }

            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _tempSTOKSEVK = StaticContext._depoEmirServis.Listele().Where(x => x.ID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).Select(x => x.MPSIPARIS.MPSIPARISDETAYList.ToList()).FirstOrDefault();
            _fMalKabulCekiPanel = new FMalKabulCekiPanel();
            _fMalKabulCekiPanel._tempEmir = StaticContext._depoEmirServis.Getir(x => x.ID.ToString() == dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            _fMalKabulCekiPanel._tempList = _tempSTOKSEVK.Select(x => new PocoSTOKMALKABULLIST() { MPSTOK = x.MPSTOK, MPSIPARISDETAY = x, SIPARISMIKTARI = x.MIKTAR, DEPOID = x.MPSIPARIS.DEPOID, BIRIMID = x.BIRIMID, EMIRID = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString()), SIPARISDETAYID = x.ID, STOKID = x.STOKID }).ToList();

            _fMalKabulCekiPanel.ShowDialog();
        }
    }
}
