using MEYPAK.PRL.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using System.IO;
using MEYPAK.Interfaces.Stok;
using DevExpress.XtraEditors;
using System.Net.Http;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Depo;
using System.Data;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Personel;

namespace MEYPAK.PRL
{
    public partial class FStokKart : XtraForm
    {
       
        public FStokKart()
        {
            InitializeComponent();
            
            _PocoOlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _StokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            _PocoStokServis = new GenericWebServis<PocoSTOK>();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
            stokOlculist = new List<PocoSTOKOLCUBR>();
            _stokResimServis = new GenericWebServis<PocoSTOKRESIM>();
            resimList = new List<PocoSTOKRESIM>();
            _StokKategoriervis = new GenericWebServis<PocoSTOKKATEGORI>();
            _silinenResimler = new List<PocoSTOKRESIM>();

        }
        #region Tanımlar
        PocoSTOKOLCUBR _tempStokOlcuBr;
        public PocoSTOK _tempStok;
        public PocoSTOKKATEGORI _tempKategori;
        public PocoSTOKMARKA _tempMarka;
        List<PocoSTOKRESIM> resimList;

        GenericWebServis<PocoSTOKRESIM> _stokResimServis;
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        GenericWebServis<PocoSTOK> _PocoStokServis;
        GenericWebServis<PocoOLCUBR> _PocoOlcuBrServis;
        GenericWebServis<PocoSTOKOLCUBR> _StokOlcuBrServis;
        GenericWebServis<PocoSTOKKATEGORI> _StokKategoriervis;
        List<PocoSTOKOLCUBR> _PocoSTOKOLCUBR;
        List<PocoOLCUBR> _tempPocoOLCUBR;
        List<PocoSTOKOLCUBR> stokOlculist;
        List<PocoSTOKRESIM> _silinenResimler;

        int stokid = 0, markaid = 0, num = 0;

        #endregion 

        #region Methods

        void OlcuBrGridDoldur()
        {
            if (CBOlcuBr.Enabled == false && _tempStok != null)
            {
                byte i = 0;
                _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
                DataTable datatable = new DataTable();
                DataColumn NUM = new DataColumn("NUM", typeof(int));
                datatable.Columns.Add(NUM);
                DataColumn OLCUBR = new DataColumn("OLCUBR", typeof(int));
                datatable.Columns.Add(OLCUBR);
                DataColumn KATSAYI = new DataColumn("KATSAYI", typeof(decimal));
                datatable.Columns.Add(KATSAYI);
                DataColumn ID = new DataColumn("ID", typeof(int));
                datatable.Columns.Add(ID);

                ID.ReadOnly= true;
                NUM.ReadOnly= true;
                //_StokOlcuBrServis.obje.Where(x=> x.stokid==_tempStok.id&& x.kayittipi == 0).ToList()[i].olcubrid
                //_StokOlcuBrServis.obje.Where(x=>x.stokid==_tempStok.id && x.kayittipi==0)
                DataTable datatb = new DataTable();
                datatb.Columns.Add("OLCUBR", typeof(int));
                datatb.Columns.Add("ADI", typeof(string));
                foreach (var item in _PocoOlcuBrServis.obje.Where(x=>x.kayittipi==0 ))
                {
                    datatb.Rows.Add(item.id, item.adi);
                }
                gridControl1.DataSource = datatable;

                RepositoryItemLookUpEdit riLookupolcubr = new RepositoryItemLookUpEdit();
                riLookupolcubr.DataSource = datatb;
                riLookupolcubr.ValueMember = "OLCUBR";
                riLookupolcubr.DisplayMember = "ADI";
                riLookupolcubr.NullText = "Sec";
                riLookupolcubr.HotTrackItems = true;
                riLookupolcubr.BestFitWidth = 170;
                riLookupolcubr.DropDownRows = datatb.Rows.Count;
                riLookupolcubr.AcceptEditorTextAsNewValue = DefaultBoolean.True;
                riLookupolcubr.AutoSearchColumnIndex = 1;
                riLookupolcubr.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;


                
                gridView1.Columns["OLCUBR"].ColumnEdit = riLookupolcubr;
                gridView1.Columns["OLCUBR"].OptionsColumn.AllowEdit = true;
                gridView1.Columns["OLCUBR"].Width = 170;
                gridView1.Columns["ID"].Visible = false;
                var b = _StokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id && x.kayittipi == 0).Count();
                var a = _StokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id && x.kayittipi == 0).Count() > i + 1 ? _StokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id && x.kayittipi == 0).ToList()[i].olcubrid : 0;

                foreach (var item in _PocoOlcuBrServis.obje.Where(x => x.kayittipi == 0))
                {
                    var item2 = _StokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id && x.kayittipi == 0 && x.num == i + 1).Count() >= 1 ? _StokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id && x.kayittipi == 0 && x.num == i + 1).FirstOrDefault() : null;
                    datatable.Rows.Add(
                    i + 1,
                    item2 !=null ? item2.olcubrid : 0,
                    item2 !=null ? item2.katsayi : 0,
                    item2 !=null ? item2.id:0 );
                    i++;
                }




            }
        }
        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextEdit)
                {
                    if (ctrl.Name != "BTStokKodu")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
            _silinenResimler.Clear();
            TBAlisKdv.Text = "0";
            TBSatisKdv.Text = "0";
            TBSatisOtv.Text = "0";
            TBAlisOtv.Text = "0";
            TBSFiyat1.Text = "0";
            TBSFiyat2.Text = "0";
            TBSFiyat3.Text = "0";
            TBSFiyat4.Text = "0";
            TBSFiyat5.Text = "0";
            TBAFiyat1.Text = "0";
            TBAFiyat2.Text = "0";
            TBAFiyat3.Text = "0";
            TBAFiyat4.Text = "0";
            TBAFiyat5.Text = "0";
            CBSDoviz.SelectedIndex = 0;
            CBADoviz.SelectedIndex = 0;
            CBOlcuBr.EditValue = 0;
            CBOlcuBr.Enabled = true;
            BTKategori.Enabled = true;
            _tempStok = null;
            _tempKategori = null;
            _tempMarka = null;

        }

        private void tbDoldur()                                                 // _tempStok nesnesi dolduğu zaman bu method ile formdaki nesneleri doldur
        {
           
            stokOlculist.Clear();
            _stokResimServis.Data(ServisList.StokResimListeServis);
            _PocoStokServis.Data(ServisList.StokListeServis);
            _markaServis.Data(ServisList.StokMarkaListeServis);
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            if (_tempStok != null)
            {
                stokid = _tempStok.id;
                BTStokKodu.Text = _tempStok.kod;
                resimList.Clear();
            }
            CBOlcuBr.EditValue = _tempStok.olcubR1;
            TBStokAdi.Text = _tempStok.adi;
            TBSatisOtv.Text = _tempStok.satisotv.ToString();
            TBSatisKdv.Text = _tempStok.satiskdv.ToString();
            BTMarka.Text = _markaServis.obje.Where(x => x.id.ToString() == _tempStok.markaid.ToString()).Count() > 0 ? _markaServis.obje.Where(x => x.id.ToString() == _tempStok.markaid.ToString()).FirstOrDefault().adi.ToString() : "";
            BTKategori.Text = _StokKategoriervis.obje.Where(x => x.id == _tempStok.kategoriid).Count() > 0 ? _StokKategoriervis.obje.Where(x => x.id == _tempStok.kategoriid).FirstOrDefault().acıklama : "";
            BTGrupKodu.Text = _tempStok.grupkodu.ToString();
            TBAlisOtv.Text = _tempStok.alisotv.ToString();
            TBAlisKdv.Text = _tempStok.aliskdv.ToString();
            TBAciklama.Text = _tempStok.aciklama;
            CBSDoviz.SelectedIndex = _tempStok.sdovizid;
            CBADoviz.SelectedIndex = _tempStok.adovizid;
            TBAFiyat1.Text = Convert.ToString(_tempStok.afiyaT1);
            TBAFiyat2.Text = Convert.ToString(_tempStok.afiyaT2);
            TBAFiyat3.Text = Convert.ToString(_tempStok.afiyaT3);
            TBAFiyat4.Text = Convert.ToString(_tempStok.afiyaT4);
            TBAFiyat5.Text = Convert.ToString(_tempStok.afiyaT5);
            TBSFiyat1.Text = Convert.ToString(_tempStok.sfiyaT1);
            TBSFiyat2.Text = Convert.ToString(_tempStok.sfiyaT2);
            TBSFiyat3.Text = Convert.ToString(_tempStok.sfiyaT3);
            TBSFiyat4.Text = Convert.ToString(_tempStok.sfiyaT4);
            TBSFiyat5.Text = Convert.ToString(_tempStok.sfiyaT5);

            if (_tempStok.id != null)
                foreach (var item in _stokResimServis.obje.Where(x => x.STOKID == stokid && x.kayittipi == 0))
                {
                    resimList.Add(item);
                }
            _StokKategoriervis.Data(ServisList.StokKategoriListeServis);
            OlcuBrGridDoldur();

            gridControl2.DataSource = resimList.Select(x => new { Resim = Base64ToImage(x.IMG), NUM = x.NUM });
            //gridControl1.DataSource = _StokOlcuBrServis.obje.Where(x => x.stokid == stokid).Select(x => new { ADI = _PocoOlcuBrServis.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi, KATSAYI = x.katsayi, SIRA = x.num });
            //gridControl1.RefreshDataSource();
            CBOlcuBr.Enabled = false;
            
            //var a = _PocoStokServis.obje.Select(x=>x.mpst.Select(z=>z));
            //stokOlculist = _tempStok.MPSTOKOLCUBR.ToList();

        }


        #endregion
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            _StokKategoriervis.Data(ServisList.StokKategoriListeServis);
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _PocoOlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _tempPocoOLCUBR = _PocoOlcuBrServis.obje.Where(x => x.kayittipi == 0).ToList();
            _PocoSTOKOLCUBR = _StokOlcuBrServis.obje.Where(x => x.kayittipi == 0).ToList();
            CBOlcuBr.Properties.DataSource = _PocoOlcuBrServis.obje.Where(x=>x.kayittipi==0).Select(x=> new {ID= x.id , ADI = x.adi});
            CBOlcuBr.Properties.ValueMember = "ID";
            CBOlcuBr.Properties.DisplayMember = "ADI";
            if (_tempStok!=null)
                tbDoldur();
            

        }
        private void BTKaydet_Click(object sender, EventArgs e)                 // Stok Kayıt
        {
            //Parallel.For(0, 50000, x =>

            //    {
            //        _markaServis.Data(ServisList.StokMarkaListeServis);
            //        _PocoStokServis.Data(ServisList.StokEkleServis,
            //     new PocoSTOK()
            //     {

            //         KOD = Faker.RandomNumber.Next(255).ToString(),
            //         ADI = Faker.Name.FullName(),
            //         MARKAID = Faker.RandomNumber.Next(255),
            //         KATEGORIID = Faker.RandomNumber.Next(255),
            //         KASAID = Faker.RandomNumber.Next(255),//_tempKasa.ID,
            //         GRUPKODU = Faker.RandomNumber.Next(255),
            //         ACIKLAMA = Faker.Name.FullName(),
            //         SATISKDV = Faker.RandomNumber.Next(255),
            //         ALISKDV = Faker.RandomNumber.Next(255),
            //         SATISOTV = Faker.RandomNumber.Next(255),
            //         ALISOTV = Faker.RandomNumber.Next(255),
            //         AFIYAT1 = Faker.RandomNumber.Next(255),
            //         AFIYAT2 = Faker.RandomNumber.Next(255),
            //         AFIYAT3 = Faker.RandomNumber.Next(255),
            //         AFIYAT4 = Faker.RandomNumber.Next(255),
            //         AFIYAT5 = Faker.RandomNumber.Next(255),
            //         SFIYAT1 = Faker.RandomNumber.Next(255),
            //         SFIYAT2 = Faker.RandomNumber.Next(255),
            //         SFIYAT3 = Faker.RandomNumber.Next(255),
            //         SFIYAT4 = Faker.RandomNumber.Next(255),
            //         SFIYAT5 = Faker.RandomNumber.Next(255),
            //         SDOVIZID = Faker.RandomNumber.Next(255),
            //         ADOVIZID = Faker.RandomNumber.Next(255),
            //     });
            //    });

        }
        private void BTSil_Click(object sender, EventArgs e)                  // Stok Sil
        {
            _PocoStokServis.Data(ServisList.StokSilServis, null, null, _PocoStokServis.obje.Where(x => x.id == stokid).ToList());
            Temizle(this.Controls);
        }



        #endregion

        #region KeyPress
        private void TBSFiyat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSatisKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAlisKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stokkart");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.id > 0)
                    tbDoldur();
        }

        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FMarkaList fMarkaKart = new FMarkaList(this.Tag.ToString(), "stokkart");
            fMarkaKart.ShowDialog();
            if (_tempMarka != null)
            {
                markaid = _tempMarka.id;
                BTMarka.Text = _tempMarka.adi;
                _tempMarka = null;
            }
        }

        private void buttonEdit3_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FKategoriList fKategoriKart = new FKategoriList(this.Tag.ToString(), "stokkart");
            fKategoriKart.ShowDialog();
            if (_tempKategori != null)
                BTKategori.Text = _tempKategori.acıklama;
        }





        private void BTStokKartiKaydet_Click(object sender, EventArgs e)
        {
            _StokKategoriervis.Data(ServisList.StokKategoriListeServis);
            if (_StokKategoriervis.obje.Where(x => x.acıklama == BTKategori.Text).Count() > 0 && CBOlcuBr.EditValue != null && Convert.ToInt32(CBOlcuBr.EditValue)>0)
            {
                _markaServis.Data(ServisList.StokMarkaListeServis);
                _tempStok = new PocoSTOK()
                {
                    id = stokid,
                    kod = BTStokKodu.Text,
                    adi = TBStokAdi.Text,
                    markaid = _markaServis.obje.Where(x => x.kayittipi == 0 && x.adi == BTMarka.Text).Count() != 0 ? _markaServis.obje.Where(x => x.kayittipi == 0 && x.adi == BTMarka.Text).FirstOrDefault().id : 0,
                    kategoriid = _StokKategoriervis.obje.Where(x => x.kayittipi == 0 && x.acıklama == BTKategori.Text).FirstOrDefault().id,
                    olcubR1 = Convert.ToInt32(CBOlcuBr.EditValue),
                    grupkodu = BTGrupKodu.Text,
                    aciklama = TBAciklama.Text,
                    satiskdv = Convert.ToInt32(TBSatisKdv.Text),
                    aliskdv = Convert.ToInt32(TBAlisKdv.Text),
                    satisotv = Convert.ToInt32(TBSatisOtv.Text),
                    alisotv = Convert.ToInt32(TBAlisOtv.Text),
                    afiyaT1 = Convert.ToDecimal(TBAFiyat1.Text),
                    afiyaT2 = Convert.ToDecimal(TBAFiyat2.Text),
                    afiyaT3 = Convert.ToDecimal(TBAFiyat3.Text),
                    afiyaT4 = Convert.ToDecimal(TBAFiyat4.Text),
                    afiyaT5 = Convert.ToDecimal(TBAFiyat5.Text),
                    sfiyaT1 = Convert.ToDecimal(TBSFiyat1.Text),
                    sfiyaT2 = Convert.ToDecimal(TBSFiyat2.Text),
                    sfiyaT3 = Convert.ToDecimal(TBSFiyat3.Text),
                    sfiyaT4 = Convert.ToDecimal(TBSFiyat4.Text),
                    sfiyaT5 = Convert.ToDecimal(TBSFiyat5.Text),
                    sdovizid = CBSDoviz.SelectedIndex,
                    adovizid = CBADoviz.SelectedIndex,
                    donem = DateTime.Now.ToString("yyyy"),


                };
                
                var snc = _PocoStokServis.obje;
                _PocoStokServis.Data(ServisList.StokEkleServis, _tempStok);
                _PocoStokServis.Data(ServisList.StokListeServis);
                _tempStok = _PocoStokServis.obje.Where(x => x.kayittipi == 0 && x.kod == _tempStok.kod).FirstOrDefault();
                int stokolcubirimi =(int)_StokOlcuBrServis.obje.Where(x => x.kayittipi == 0 && x.stokid == _tempStok.id).Count();

               if (stokolcubirimi >0)
               {
                    for (int i = 1; i < gridView1.RowCount; i++)
                    {
                        DataRowView row = gridView1.GetRow(i) as DataRowView;
                        if (row != null && Convert.ToInt32(row.Row.ItemArray[1])!=0)
                        {
                            _StokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis, new PocoSTOKOLCUBR()
                            {
                                num = Convert.ToInt32(row.Row.ItemArray[0]),
                                stokid = _tempStok.id,
                                olcubrid = Convert.ToInt32(row.Row.ItemArray[1]),
                                katsayi = Convert.ToDecimal(row.Row.ItemArray[2]),
                                id = Convert.ToInt32(row.Row.ItemArray[3])
                            });
                        }
                    }
                }
               else if (stokolcubirimi == 0)
                {
                    _StokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis, new PocoSTOKOLCUBR()
                    {
                        num = 1,
                        stokid = _tempStok.id,
                        olcubrid = _tempStok.olcubR1,
                        katsayi = 1,
                    });
                }
                
                
                foreach (var item in resimList)
                {
                    if (!_silinenResimler.Contains(item))
                    {
                        item.STOKID = _tempStok.id;
                        _stokResimServis.Data(ServisList.StokResimEkleServis, item);
                    }
                }
                foreach (var item in _silinenResimler)
                {
                    _stokResimServis.Data(ServisList.StokResimDeleteByIdServis, id: item.id.ToString(), method: HttpMethod.Post);
                }
             
                stokid = 0;
                if (snc != null)
                    MessageBox.Show("Kayıt Başarılı.");
                Temizle(this.Controls);
                BTStokKodu.Text = "";
                gridControl1.DataSource = "";
            }
            else
            {
                MessageBox.Show("Kategori veya Olcu Birim Seçmeden Stok Ekleyemezsiniz!");
            }



        }

        private void BTOlcuBirimiEkle_Click_1(object sender, EventArgs e)
        {

        }
        string base64 = "";
        private void buttonEdit1_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    buttonEdit1.Text = DosyaYolu;
                    pictureEdit1.Image = new Bitmap(DosyaYolu);
                    base64 = ImageToBase64(DosyaYolu);
                }
            }
        }
        public object base64resim;
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            catch (Exception)
            {

                return null;
            }

        }
        string b64string = "";
        public string ImageToBase64(string path)
        {
            try
            {
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        b64string = Convert.ToBase64String(imageBytes);
                        return b64string;
                    }
                }
            }
            catch
            {
                return "";
            }
        }

        //RESİM Kaydet
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).Count() != 0)
            {
                _stokResimServis.Data(ServisList.StokResimListeServis);
                if (_stokResimServis.obje.Where(x => x.STOKID == _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id).Count() == 0)
                {
                    resimList.Add(new PocoSTOKRESIM()
                    {
                        STOKID = _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id,
                        NUM = 0,
                        IMG = base64,

                    });
                }
                else
                {
                    resimList.Add(new PocoSTOKRESIM()
                    {
                        STOKID = _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id,
                        NUM = _stokResimServis.obje.Where(x => x.STOKID == _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id).Last().NUM + 1,
                        IMG = base64,
                    });
                }

                gridControl2.DataSource = resimList.Select(x => new { Resim = Base64ToImage(x.IMG), NUM = x.NUM });
            }
            else
            {
                MessageBox.Show("Stok Seçmeden veya Stok Eklemeden Stok Resmi Ekleyemezsiniz!");
            }
        }



        private void BTStokKodu_Leave_1(object sender, EventArgs e)
        {
            _PocoStokServis.Data(ServisList.StokListeServis);
            if (BTStokKodu.Text != "")
            {
                _tempStok = _PocoStokServis.obje.Where(x => x.kayittipi == 0 && x.kod == BTStokKodu.Text).FirstOrDefault();
                if (_tempStok != null)
                    tbDoldur();
                else
                {
                    Temizle(this.Controls);
                    gridControl1.DataSource = "";
                    stokid = 0;
                }
            }
        }

        private void BTSil_Click_1(object sender, EventArgs e)
        {
            if (_tempStok != null)
            {
                _PocoStokServis.Data(ServisList.StokDeleteByIdServis, id: _tempStok.id.ToString(), method: HttpMethod.Post);
                Temizle(this.Controls);
                MessageBox.Show("Stok Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Stok Seçmeden Stok Silme İşlemi Yapamazsınız!");
            }

        }

       

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //TODO :Yarın burası yapılacak
        }

        private void BTResimSil_Click(object sender, EventArgs e)
        {
            _silinenResimler.Add(resimList.Where(x => x.NUM.ToString() == tileView1.GetFocusedRowCellValue("NUM").ToString()).FirstOrDefault());
            resimList.Remove(resimList.Where(x => x.NUM.ToString() == tileView1.GetFocusedRowCellValue("NUM")).FirstOrDefault());
            gridControl2.DataSource = resimList;
            gridControl2.RefreshDataSource();
        }

        private void GBStokKartiKdvOtv_Enter(object sender, EventArgs e)
        {

        }

        private void TBSatisOtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAlisOtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        #endregion

    }
}