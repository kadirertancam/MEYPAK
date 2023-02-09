using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Concrete.EntityFramework.Repository.PersonelRepo;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Personel;
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

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelGorevKart : XtraForm
    {
        public FPersonelGorevKart()
        {
            InitializeComponent();
            _departmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            _gorevServis = new GenericWebServis<PocoPERSONELGOREV> ();
            _personelServis = new GenericWebServis<PocoPERSONEL>();
        }

        GenericWebServis<PocoPERSONELDEPARTMAN> _departmanServis;
        GenericWebServis<PocoPERSONELGOREV> _gorevServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
        private void FPersonelGorevKart_Load(object sender, EventArgs e)
        {
            DepartmanGridDoldur();
            DepartmanComboDoldur();
            GorevGridDoldur();
        }

        void DepartmanGridDoldur()
        {
            _departmanServis.Data(ServisList.PersonelDepartmanListeServis);
            GCDepartman.DataSource= _departmanServis.obje.Select(x=> new { Departman = x.adi ,ID=x.id});
            gridView1.Columns["ID"].Visible = false;
        }
        void GorevGridDoldur()
        {
            _gorevServis.Data(ServisList.PersonelGorevListeServis);
            GCGorev.DataSource=_gorevServis.obje.Select(x=> new {Departman=_departmanServis.obje.Where(y=> y.id==x.departmanid).FirstOrDefault().adi,Gorev= x.adi,ID=x.id });
            gridView2.Columns["ID"].Visible = false;
            GridColumn Departman = gridView2.Columns["Departman"];
            gridView2.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(Departman , DevExpress.Data.ColumnSortOrder.Ascending)
            }, 1);
            gridView2.ExpandAllGroups();
        }
        void DepartmanComboDoldur()
        {
            CBDepartman.Properties.DataSource = _departmanServis.obje.Select(x=> new {ID=x.id, Departman = x.adi});
            CBDepartman.Properties.DisplayMember = "Departman";
            CBDepartman.Properties.ValueMember = "ID";
            CBDepartman.Properties.PopulateColumns();
          
        }

        private void BTNDepartmanKaydet_Click(object sender, EventArgs e)
        {
            if (_departmanServis.obje.Where(x=> x.adi==TBDepartman.Text).Count()<1)
            {
                _departmanServis.Data(ServisList.PersonelDepartmanEkleServis, new PocoPERSONELDEPARTMAN()
                {
                    adi = TBDepartman.Text,
                    userid = MPKullanici.ID,
                });
                MessageBox.Show($"{TBDepartman.Text} Departmanı Başarıyla Eklendi");
                DepartmanGridDoldur();
                DepartmanComboDoldur();
            }
            else
                MessageBox.Show("Bu Departman Zaten Mevcuttur!");

        }

        private void BTGorevKaydet_Click(object sender, EventArgs e)
        {
            if (_gorevServis.obje.Where(x=> x.adi==TBGorev.Text).Count()<1)
            {
                if (CBDepartman.EditValue!=null)
                {
                _gorevServis.Data(ServisList.PersonelGorevEkleServis, new PocoPERSONELGOREV()
                {
                    departmanid=Convert.ToInt32(CBDepartman.EditValue.ToString()),
                    adi = TBGorev.Text,
                    userid = MPKullanici.ID,
                });
                    MessageBox.Show($"{TBGorev.Text} Gorevi Başarıyla Eklendi");
                    GorevGridDoldur();
                }
            }
            else
                MessageBox.Show("Bu Gorev Zaten Mevcuttur!");
        }

        private void BTGorevSil_Click(object sender, EventArgs e)
        {
            if (gridView2.SelectedRowsCount > 0 && gridView2.FocusedColumn.ToString()== "Gorev")
            {

                try
                {
                    _personelServis.Data(ServisList.PersonelListeServis);
                    if (_personelServis.obje.Where(x => x.personelgorevid.ToString() == gridView2.GetFocusedRowCellValue("ID").ToString()).Count() == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show($"{gridView2.GetFocusedRowCellValue("Gorev")} adlı görevi silmek istediğinizden emin misiniz?", "Görev Sil", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _gorevServis.Data(ServisList.PersonelGorevSilServis, null, null, _gorevServis.obje.Where(x => x.id.ToString() == gridView2.GetFocusedRowCellValue("ID").ToString()).ToList());
                            MessageBox.Show("Silme Başarılı");
                            GorevGridDoldur();
                        }
                    }
                    else
                        MessageBox.Show("Personel ile bağlantılı olan görev silinemez! ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Görev seçmelisiniz!");
                }

            }
            else
                MessageBox.Show("Görev seçmelisiniz!");
        }

        private void BTNDepartmanSil_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0 && gridView1.FocusedColumn.ToString() == "Departman")
            {

                try
                {
                    _personelServis.Data(ServisList.PersonelListeServis);
                    if (_personelServis.obje.Where(x => x.personeldepartmanid.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).Count() == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show($"{gridView1.GetFocusedRowCellValue("Departman")} adlı departmanı silmek istediğinizden emin misiniz?", "Görev Sil", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _departmanServis.Data(ServisList.PersonelDepartmanSilServis, null,null, _departmanServis.obje.Where(x=> x.id.ToString() ==gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
                            MessageBox.Show("Silme Başarılı");
                            DepartmanGridDoldur();
                        }
                    }
                    else
                        MessageBox.Show("Personel ile bağlantılı olan departman silinemez! ");
                }
                catch ( Exception)
                {
                    MessageBox.Show("Departman seçmelisiniz!");
                }

            }
            else
                MessageBox.Show("Departman seçmelisiniz!");
        }
    }
}
