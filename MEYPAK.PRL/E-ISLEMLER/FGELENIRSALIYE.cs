using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using e_İrsaliyeDemo_v1._0._0;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using ServiceReference1;
using ServiceReference11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.E_ISLEMLER
{
    public partial class FGELENIRSALIYE : Form
    {
        public FGELENIRSALIYE()
        {
            InitializeComponent();
            client = DespatchTasks2.Instance.CreateClient();
            DTPBastar.Text = DateTime.Now.AddDays(-1).ToString();
            DTPBittar.Text = DateTime.Now.ToString();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _faturaStokOlcuBrServis = new GenericWebServis<PocoFATURASTOKOLCUBR>();
            olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            faturaStokEsleServis = new GenericWebServis<PocoFATURASTOKESLE>();
        }
        ServiceReference1.IntegrationClient ıntegrationClient = new ServiceReference1.IntegrationClient();
        ServiceReference2.BasicIntegrationClient basicIntegration = new ServiceReference2.BasicIntegrationClient();
        ServiceReference1.WhoAmIInfo bb; 
        List<InboxDespatchListItem> geleneirsaliyetasktemp;
        DespatchResponse tempp;
        List<FaturaDetailList> tempdetay;
        InboxDespatchListResponse res;
        RepositoryItemButtonEdit repositoryItemButtonEdit3;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCari;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoFATURASTOKOLCUBR> _faturaStokOlcuBrServis;
        GenericWebServis<PocoOLCUBR> olcuBrServis;
        DespatchIntegrationClient client;
      

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FCariList carilist = new FCariList(this.Tag.ToString(), "EIrsaliyeGelenKutu");
            carilist.ShowDialog();
            if (_tempCari != null)
                gridView1.SetFocusedRowCellValue("CARISEC", _tempCari.kod);
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var irstemp = client.GetInboxDespatchPdfAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result;
            System.IO.File.WriteAllBytes("Irsaliye.pdf", irstemp.Value.Items.FirstOrDefault().Data);
            Thread.Sleep(500);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "Irsaliye.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void RepositoryItemButtonEdit_ButtonClick1(object sender, ButtonPressedEventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            _faturaStokOlcuBrServis.Data(ServisList.FATURASTOKOLCUBRListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            PocoIRSALIYE fatura = new PocoIRSALIYE();
            List<PocoIrsaliyeKalem> faturakalem = new List<PocoIrsaliyeKalem>();
            string olcubrtemp;
            int olcubrid;
            try
            {
                foreach (var item in (List<FaturaDetailList>)gridControl2.DataSource)
                {
                    olcubrid = _faturaStokOlcuBrServis.obje.Where(x => x.kisa == item.BIRIM).FirstOrDefault().olcubrid;
                    olcubrtemp = olcuBrServis.obje.Where(x => x.id == olcubrid).FirstOrDefault().adi;

                    var tempstok = _stokServis.obje.Where(x => x.kod == item.KOD).FirstOrDefault();
                    faturakalem.Add(new PocoIrsaliyeKalem()
                    {
                        StokId = tempstok.id,
                        StokAdı = tempstok.adi,
                        StokKodu = tempstok.kod,
                        Kunye = item.KUNYENO,
                        Daralı = item.MIKTAR,
                        Birim = olcubrtemp,  


                    });
                }

                var irsaliyeust = (EFaturaGelenTask)gridView1.GetFocusedRow();
                _cariServis.Data(ServisList.CariListeServis);
                var tmpcari = _cariServis.obje.Where(x => x.kod == irsaliyeust.CARISEC).FirstOrDefault();
                var secilitempfat = geleneirsaliyetasktemp.Where(x => x.DespatchId == irsaliyeust.ETTNO).FirstOrDefault();
                fatura.cariid = tmpcari.id;
                fatura.belgeno = irsaliyeust.BELGENO;
                if (irsaliyeust.VADETARIHI.HasValue)
                    fatura.vadetarihi = irsaliyeust.VADETARIHI.Value;  
                fatura.cariadi = tmpcari.unvan == "" ? tmpcari.adi + " " + tmpcari.soyadi : tmpcari.unvan;
                fatura.depoid = MPKullanici.DEPOID;
                _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
                fatura.althesapid = _cariAltHesCariServis.obje.Where(x => x.cariid == tmpcari.id).FirstOrDefault().carialthesid;
                var main = (Main)Application.OpenForms["Main"];
                XtraTabPage page = new XtraTabPage();
                FAlisIrsaliye ffatura = new FAlisIrsaliye(fatura, faturakalem, null, 1);
                page.Name = "TPAlisIrsaliye" + main.i;
                page.Text = "Alış Irsaliye Tanım";
                page.Tag = "TPAlisIrsaliye" + main.i;
                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                main.Anasayfa.TabPages.Add(page);
                main.Anasayfa.SelectedTabPage = page;

                ffatura.TopLevel = false;
                ffatura.AutoScroll = true;
                ffatura.Dock = DockStyle.Fill;
                ffatura.Tag = "TPAlisIrsaliye" + main.i;
                page.Controls.Add(ffatura);
                ffatura.Show(); 
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ölçü birimi eşleştirilemedi");
            }
        }


        GenericWebServis<PocoFATURASTOKESLE> faturaStokEsleServis;
        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FStokList stoklist = new FStokList(this.Tag.ToString(), "EIrsaliyeGelenKutu");
            stoklist.ShowDialog();
            gridView2.SetFocusedRowCellValue("KOD", _tempStok.kod);
            faturaStokEsleServis.Data(ServisList.FATURASTOKESLEListeServis);
            if (faturaStokEsleServis.obje.Where(x => x.stokadi == gridView2.GetFocusedRowCellValue("S_KOD").ToString()).Count() > 0)
            {
                faturaStokEsleServis.Data(ServisList.FATURASTOKESLEEkleServis, new PocoFATURASTOKESLE()
                {
                    id= faturaStokEsleServis.obje.Where(x => x.stokadi == gridView2.GetFocusedRowCellValue("S_KOD").ToString() ).FirstOrDefault().id,
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

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                res = client.GetInboxDespatchListAsync(new InboxDespatchListQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    CreateStartDate = DTPBastar.DateTime,
                    CreateEndDate = DTPBittar.DateTime,
                }).Result;
                if (res.IsSucceded)
                {
                    MessageBox.Show(string.Format("Metot başarıyla çağrıldı. {0} kayıt döndü.", res.Value.TotalCount));
                }
                else
                {
                    MessageBox.Show(res.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "Irsaliyeleştir";
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
            geleneirsaliyetasktemp = res.Value.Items.ToList();
            if (res.Value.Items != null)
                gridControl1.DataSource = res.Value.Items.Select(x => new EFaturaGelenTask { SEC = false, ID = x.DespatchId, CARISEC = _cariServis.obje.Where(y => y.vergino == x.TargetTcknVkn || y.tcno == x.TargetTcknVkn).Count()>0? _cariServis.obje.Where(y => y.vergino == x.TargetTcknVkn || y.tcno == x.TargetTcknVkn).FirstOrDefault().kod:"", FATURALASTIR = "", BASIM = "", VKNTCK = x.TargetTcknVkn, CARIADI = x.TargetTitle, BELGENO = x.DespatchNumber, TARIH = x.CreateDateUtc, VADETARIHI = x.IssueDate, ARSIVLENMIS = x.IsArchived, ETTNO = x.DespatchId, DURUM = x.StatusCode == 1000 ? "ONAYLANDI" : "BEKLEMEDE" });
            else
                gridControl1.DataSource = new List<EFaturaGelenTask>();

            gridView1.Columns["FATURALASTIR"].ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["BASIM"].ColumnEdit = repositoryItemButtonEdit2;
            gridView1.Columns["CARISEC"].ColumnEdit = repositoryItemButtonEdit3;
        }
        
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            faturaStokEsleServis.Data(ServisList.FATURASTOKESLEListeServis);
            tempp = client.GetInboxDespatchAsync(gridView1.GetFocusedRowCellValue("ETTNO").ToString()).Result;
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            _stokServis.Data(ServisList.StokListeServis);
            tempdetay = tempp.Value.DespatchAdvice.DespatchLine.Select(x => new FaturaDetailList { SIRA = int.Parse(x.ID.Value),KOD =   faturaStokEsleServis.obje.Where(y=>y.stokadi==x.Item.SellersItemIdentification.ID.Value.ToString()).Count()>0? faturaStokEsleServis.obje.Where(y => y.stokadi == x.Item.SellersItemIdentification.ID.Value.ToString()).Select(z=> _stokServis.obje.Where(y=>y.id==z.stokid).FirstOrDefault().kod).FirstOrDefault():"", S_KOD = x.Item.SellersItemIdentification.ID.Value.ToString(), ADI = x.Item.Name.Value, KUNYENO = x.Item.AdditionalItemIdentification != null ? x.Item.AdditionalItemIdentification.Where(x => x.ID.schemeID == "KUNYENO").Count() > 0 ? x.Item.AdditionalItemIdentification.Where(x => x.ID.schemeID == "KUNYENO").FirstOrDefault().ID.Value : "" : "", MIKTAR = x.DeliveredQuantity.Value, BIRIM = x.DeliveredQuantity.unitCode }).ToList();
            gridControl2.DataSource = tempdetay;
            gridView2.Columns["S_KOD"].Visible = false;
            gridView2.Columns["KOD"].ColumnEdit = repositoryItemButtonEdit;
            gridControl2.RefreshDataSource();
        }
    }
}
