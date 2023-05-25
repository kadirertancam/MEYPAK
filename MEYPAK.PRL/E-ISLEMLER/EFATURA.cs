using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Fatura;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class EFATURA : DevExpress.XtraEditors.XtraForm
    {
        ServiceReference1.IntegrationClient ıntegrationClient = new ServiceReference1.IntegrationClient();
        ServiceReference2.BasicIntegrationClient basicIntegration = new ServiceReference2.BasicIntegrationClient();
        ServiceReference1.WhoAmIInfo bb;
        List<InboxInvoiceListItem> gelenefaturatasktemp;
        InvoiceResponse tempp;
        List<FaturaDetailList> tempdetay;
        InboxInvoiceListResponse res;
        RepositoryItemButtonEdit repositoryItemButtonEdit3;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCari;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoFATURASTOKOLCUBR> _faturaStokOlcuBrServis;
        GenericWebServis<PocoOLCUBR> olcuBrServis;
        public EFATURA()
        {
            InitializeComponent();

            ıntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            ıntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
            bb = new WhoAmIInfo();
            DTPBastar.Text = DateTime.Now.AddDays(-1).ToString();
            DTPBittar.Text = DateTime.Now.ToString();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            _faturaStokOlcuBrServis = new GenericWebServis<PocoFATURASTOKOLCUBR>();
            olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            faturaStokEsleServis = new GenericWebServis<PocoFATURASTOKESLE>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempKasa = new PocoSTOKKASA();

        }

        RepositoryItemLookUpEdit riLookup;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        public PocoSTOKKASA _tempKasa;

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {


        }

        private void gridView1_Click(object sender, EventArgs e)
        {
        }
        GenericWebServis<PocoFATURASTOKESLE> faturaStokEsleServis;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            faturaStokEsleServis.Data(ServisList.FATURASTOKESLEListeServis);
            tempp = ıntegrationClient.GetInboxInvoiceAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result;
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;

            var datatb = new DataTable();
            datatb.Columns.Add("ID", typeof(int));
            datatb.Columns.Add("TIP", typeof(string));

            datatb.Rows.Add(0, "STOK");
            datatb.Rows.Add(1, "HIZMET");
            datatb.Rows.Add(2, "KASA");
            datatb.Rows.Add(3, "DEMIRBAS");
            datatb.Rows.Add(4, "MUHASEBE");

            var riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = datatb;
            riLookup.ValueMember = "TIP";
            riLookup.DisplayMember = "TIP";
            riLookup.NullText = "Sec";

            riLookup.HotTrackItems = true;
            riLookup.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = datatb.Rows.Count;
            riLookup.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup.AutoSearchColumnIndex = 1;
            
            riLookup.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup.EditValueChanged += RiLookup_EditValueChanged;
            riLookup.GetDataSourceRowByKeyValue(0);



            tempdetay = tempp.Value.Invoice.InvoiceLine.Select(x => new FaturaDetailList { SIRA = int.Parse(x.ID.Value),TIP="STOK", KOD = faturaStokEsleServis.obje.Where(y => y.stokadi == (x.Item.SellersItemIdentification!=null? x.Item.SellersItemIdentification.ID.Value.ToString():"")).Count() > 0 ? faturaStokEsleServis.obje.Where(y => y.stokadi == x.Item.SellersItemIdentification.ID.Value.ToString()).Select(z => _stokServis.obje.Where(y => y.id == z.stokid).FirstOrDefault().kod).FirstOrDefault() : "", ADI = x.Item.Name.Value, KUNYENO = x.Item.AdditionalItemIdentification != null ? x.Item.AdditionalItemIdentification.Where(x => x.ID.schemeID == "KUNYENO").Count() > 0 ? x.Item.AdditionalItemIdentification.Where(x => x.ID.schemeID == "KUNYENO").FirstOrDefault().ID.Value : "" : "", MIKTAR = x.InvoicedQuantity.Value, BIRIM = x.InvoicedQuantity.unitCode, NETFIYAT = x.Price.PriceAmount.Value, TUTAR = x.Price.PriceAmount.Value * x.InvoicedQuantity.Value }).ToList();
            gridControl2.DataSource = tempdetay;
            gridView2.Columns["S_KOD"].Visible = false;
            gridView2.Columns["KOD"].ColumnEdit = repositoryItemButtonEdit;
            gridView2.Columns["TIP"].ColumnEdit = riLookup;
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
           // riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CBArsiv.Checked)
            {
                res = ıntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    CreateStartDate = DTPBastar.DateTime,
                    CreateEndDate = DTPBittar.DateTime,
                    IsArchived = true 
                }).Result;
            }
            else
            {
                res = ıntegrationClient.GetInboxInvoiceListAsync(new InboxInvoiceListQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    CreateStartDate = DTPBastar.DateTime,
                    CreateEndDate = DTPBittar.DateTime,
                }).Result;

            }

            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Faturalaştır";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick1;

            RepositoryItemButtonEdit repositoryItemButtonEdit2 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit2.NullText = "";
            repositoryItemButtonEdit2.NullValuePrompt = "";
            repositoryItemButtonEdit2.Buttons[0].Caption = "Basım";
            repositoryItemButtonEdit2.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit2.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit3.NullText = "";
            repositoryItemButtonEdit3.NullValuePrompt = "";
            repositoryItemButtonEdit3.Buttons[0].Caption = "Seç";
            repositoryItemButtonEdit3.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit3.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3_ButtonClick; ;
            _cariServis.Data(ServisList.CariListeServis);
            gelenefaturatasktemp = res.Value.Items.ToList();
            if (res.Value.Items != null)
                gridControl1.DataSource = res.Value.Items.Select(x => new EFaturaGelenTask { SEC = false, ID = x.InvoiceId, CARISEC = _cariServis.obje.Where(y => y.vergino == x.TargetTcknVkn || y.tcno == x.TargetTcknVkn).Count()>0? _cariServis.obje.Where(y=>y.vergino==x.TargetTcknVkn || y.tcno==x.TargetTcknVkn).FirstOrDefault().kod:"", FATURALASTIR = "", BASIM = "", VKNTCK = x.TargetTcknVkn, CARIADI = x.TargetTitle, BELGENO = x.InvoiceId, TARIH = x.CreateDateUtc, VADETARIHI = x.ExecutionDate, TUTAR = x.TaxExclusiveAmount, KDV = x.TaxTotal, FATURATIP = x.Type.ToString(), ARSIVLENMIS = x.IsArchived, TIP = x.InvoiceTipType.ToString(), ETTNO = x.DocumentId, DURUM = x.StatusCode == 1000 ? "ONAYLANDI" : "BEKLEMEDE" });
            else
                gridControl1.DataSource = new List<EFaturaGelenTask>();

            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["BASIM"].ColumnEdit = repositoryItemButtonEdit2;
            gridView1.Columns["CARISEC"].ColumnEdit = repositoryItemButtonEdit3;
            

        }

        private void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            //FATURALAŞTIR
            _stokServis.Data(ServisList.StokListeServis);
            _faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _kasaServis.Data(ServisList.StokKasaListeServis);
            PocoFATURA fatura = new PocoFATURA();
            List<PocoFaturaKalem> faturakalem = new List<PocoFaturaKalem>();
            List<ListKasaList> kasaList = new List<ListKasaList>();
            string olcubrtemp;
            int olcubrid;
            try
            {
                foreach (var item in (List<FaturaDetailList>)gridControl2.DataSource)
                {
                    olcubrid = _faturaStokOlcuBrServis.obje.Where(x => x.kisa == item.BIRIM).FirstOrDefault().olcubrid;
                    olcubrtemp = olcuBrServis.obje.Where(x => x.id == olcubrid).FirstOrDefault().adi;
                    if (item.TIP == "STOK")
                    {
                        var tempstok = _stokServis.obje.Where(x => x.kod == item.KOD).FirstOrDefault();
                        faturakalem.Add(new PocoFaturaKalem()
                        {
                            StokId = tempstok.id,
                            StokAdı = tempstok.adi,
                            StokKodu = tempstok.kod,
                            Kunye = item.KUNYENO,
                            Daralı = item.MIKTAR,
                            Birim = olcubrtemp,
                            BirimFiyat = item.NETFIYAT,
                            BrütToplam = item.TUTAR,
                             Tipi="STOK"


                        });
                    }
                    if (item.TIP == "KASA")
                    {
                        var tempkasa = _kasaServis.obje.Where(x => x.kasakodu == item.KOD).FirstOrDefault();
                        faturakalem.Add(new PocoFaturaKalem()
                        {
                            StokId = tempkasa.id,
                            StokAdı = tempkasa.kasaadi,
                            StokKodu = tempkasa.kasakodu,
                            Kunye = "",
                            Daralı = item.MIKTAR,
                            Birim = olcubrtemp,
                            BirimFiyat = item.NETFIYAT,
                            BrütToplam = item.TUTAR,
                            Tipi = "KASA"


                        });

                    }
                }


                var faturaust = (EFaturaGelenTask)gridView1.GetFocusedRow();
                _cariServis.Data(ServisList.CariListeServis);
                var tmpcari = _cariServis.obje.Where(x => x.kod == faturaust.CARISEC).FirstOrDefault();
                var secilitempfat = gelenefaturatasktemp.Where(x => x.DocumentId == faturaust.ETTNO).FirstOrDefault();
                fatura.cariid = tmpcari.id;
                fatura.belgeno = faturaust.BELGENO;
                if (faturaust.VADETARIHI.HasValue)
                    fatura.vadetarihi = faturaust.VADETARIHI.Value;
                fatura.kdvtoplam = faturaust.KDV;
                fatura.geneltoplam = faturaust.TUTAR;
                fatura.bruttoplam = secilitempfat.TaxExclusiveAmount;
                fatura.nettoplam = faturaust.TUTAR - faturaust.KDV;
                fatura.iskontotoplam = fatura.bruttoplam - fatura.nettoplam;
                fatura.cariadi = tmpcari.unvan == "" ? tmpcari.adi + " " + tmpcari.soyadi : tmpcari.unvan;
                fatura.depoid = MPKullanici.DEPOID;
                _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
                fatura.althesapid = _cariAltHesCariServis.obje.Where(x => x.cariid == tmpcari.id).FirstOrDefault().carialthesid;
                var main = (Main)Application.OpenForms["Main"];
                XtraTabPage page = new XtraTabPage();
                 
                FAlisFatura ffatura = new FAlisFatura(fatura, faturakalem, null, 1);
                page.Name = "TPAlisFatura" + main.i;
                page.Text = "Alış Fatura Tanım";
                page.Tag = "TPAlisFatura" + main.i;
                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                main.Anasayfa.TabPages.Add(page);
                main.Anasayfa.SelectedTabPage = page;

                ffatura.TopLevel = false;
                ffatura.AutoScroll = true;
                ffatura.Dock = DockStyle.Fill;
                ffatura.Tag = "TPAlisFatura" + main.i;
                page.Controls.Add(ffatura);
                ffatura.Show();
                main.i++;
                this.Close();
                main.i++; 

               
            }
            catch (Exception)
            {
                MessageBox.Show("ölçü birimi eşleştirilemedi");
            }
        }

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FCariList carilist = new FCariList(this.Tag.ToString(), "EFaturaGelenKutu");
            carilist.ShowDialog();
            if (_tempCari != null)
                gridView1.SetFocusedRowCellValue("CARISEC", _tempCari.kod);


        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            System.IO.File.WriteAllBytes("Fatura.pdf", ıntegrationClient.GetInboxInvoicePdfAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result.Value.Data);
            Thread.Sleep(500);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "Fatura.pdf")
            {
                UseShellExecute = true
            };
            p.Start();

        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("TIP").ToString() == "STOK")
            {
                FStokList stoklist = new FStokList(this.Tag.ToString(), "EFaturaGelenKutu");
                stoklist.ShowDialog();
                gridView2.SetFocusedRowCellValue("KOD", _tempStok.kod);
                faturaStokEsleServis.Data(ServisList.FATURASTOKESLEListeServis);
                var foo = gridView2.GetFocusedRowCellValue("S_KOD");
                if (foo != null)
                {
                    if (faturaStokEsleServis.obje.Where(x => x.stokadi == gridView2.GetFocusedRowCellValue("S_KOD").ToString()).Count() > 0)
                    {
                        faturaStokEsleServis.Data(ServisList.FATURASTOKESLEEkleServis, new PocoFATURASTOKESLE()
                        {
                            id = faturaStokEsleServis.obje.Where(x => x.stokadi == gridView2.GetFocusedRowCellValue("S_KOD").ToString()).FirstOrDefault().id,
                            stokid = _tempStok.id,
                            stokadi = gridView2.GetFocusedRowCellValue("S_KOD").ToString(),
                            userid = MPKullanici.ID
                        });
                    }
                    else
                    {
                        faturaStokEsleServis.Data(ServisList.FATURASTOKESLEEkleServis, new PocoFATURASTOKESLE()
                        {
                            stokid = _tempStok.id,
                            stokadi = gridView2.GetFocusedRowCellValue("S_KOD").ToString(),
                            userid = MPKullanici.ID
                        });
                    }
                }
                else
                {
                    try
                    {

                   
                    faturaStokEsleServis.Data(ServisList.FATURASTOKESLEEkleServis, new PocoFATURASTOKESLE()
                    {
                        stokid = _tempStok.id,
                        stokadi = gridView2.GetFocusedRowCellValue("S_KOD").ToString(),
                        userid = MPKullanici.ID
                    });
                    }
                    catch (Exception)
                    {
                         
                    }
                }
            }
            if (gridView2.GetFocusedRowCellValue("TIP").ToString() == "KASA")
            {
                FStokKasaList2 fStokKasaList2= new FStokKasaList2(this.Tag.ToString(), "EFaturaGelenKutu");
                fStokKasaList2.ShowDialog();
                gridView2.SetFocusedRowCellValue("KOD", _tempKasa.kasakodu);



            }
        }

        private void gridView2_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            FaturaDetailList respinbox = view.GetRow(e.RowHandle) as FaturaDetailList;
            if (respinbox != null)
            {
                if (tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification != null))
                    e.IsEmpty = tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Select(x => x.Item.AdditionalItemIdentification.Count()).FirstOrDefault() > 0 ? false : true;
            }

        }

        private void gridView2_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            FaturaDetailList respinbox = view.GetRow(e.RowHandle) as FaturaDetailList;
            if (respinbox != null)
            {
                if (tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification != null))
                    if (tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Any(x => x.Item.AdditionalItemIdentification.Where(x => x.ID.schemeID == "KUNYENO").Count() > 0))
                        e.ChildList = tempp.Value.Invoice.InvoiceLine.Where(x => respinbox.SIRA.ToString() == x.ID.Value).Select(x => new { KUNYE = x.Item.AdditionalItemIdentification.Where(z => z.ID.schemeID == "KUNYENO").FirstOrDefault().ID.Value }).ToList();
            }

        }

        private void gridView2_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            if (tempp != null)
                if (tempp.Value.Invoice.InvoiceLine.Where(x => x.Item.AdditionalItemIdentification != null).Count() > 0)
                    e.RelationCount = 1;
                else
                    e.RelationCount = 0;

        }

        private void gridView2_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detay";
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity == "ONAYLANDI")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            {
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}