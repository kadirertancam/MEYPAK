using DevExpress.DXTemplateGallery.Extensions;
using DevExpress.Utils.Layout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MEYPAK.BLL.Assets;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class KullaniciRapor : Form
    {
        public KullaniciRapor()
        {
            InitializeComponent();
            userServis = new GenericWebServis<MPUSER>();
        }
        AdoConnect con = new AdoConnect();
        DataTable[] dt;
        GridControl gridcontroller;
        GridView gridviewlar;
        StackPanel panell;
        GenericWebServis<MPUSER> userServis;
        private void KullaniciRapor_Load(object sender, EventArgs e)
        {
            userServis.Data(ServisList.UserGetServis); 
            gridControl2.DataSource = userServis.obje.Select(x => new
            { 
                ID=x.Id,
                KULLANICIADI = x.UserName, 
            });
            gridView2.Columns["ID"].Visible = false;
           

        }
        Label baslik;
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var ds = con.komutoku2("EXEC KULLANICIRAPOR '"+gridView2.GetFocusedRowCellValue("ID").ToString()+"'");
            dt = new DataTable[ds.Tables.Count];
            for (int i = 2; i < ds.Tables.Count-1; i++)
            {
                dt[i] = ds.Tables[i];
                gridcontroller = new GridControl();
                gridviewlar = new GridView();
                panell = new StackPanel();
                baslik = new Label();
                this.baslik.AutoSize = true;
                this.baslik.Location = new System.Drawing.Point(142, 0);
                this.baslik.Name = "label"+i;
                this.baslik.Size = new System.Drawing.Size(35, 13);
                this.baslik.TabIndex = 2;
                this.baslik.Text = dt[i].Rows[0].ItemArray[0].ToString().Split('.')[1].Replace('[',' ').Replace(']',' ');
                this.baslik.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
                this.flowLayoutPanel1.Controls.Add(this.panell);
               
                this.panell.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
                this.panell.Location = new System.Drawing.Point(3, 3);
                this.panell.Name = "stackPanel"+i;
                this.panell.Size = new System.Drawing.Size(400, 221);
                this.panell.TabIndex = 0;
                this.panell.Controls.Add(this.baslik);
                this.panell.Controls.Add(this.gridcontroller);
                ((System.ComponentModel.ISupportInitialize)(this.gridcontroller)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridviewlar)).BeginInit();
                this.flowLayoutPanel1.Controls.Add(this.panell);
                this.gridcontroller.MainView = this.gridviewlar;
                this.gridcontroller.Name = "gridControl" + i;
                this.gridcontroller.Size = new System.Drawing.Size(400, 200);
                this.gridcontroller.TabIndex = i;
                this.gridcontroller.Dock = DockStyle.Fill;

                this.gridcontroller.DataSource = dt[i];

                this.gridviewlar.GridControl = this.gridcontroller;
                this.gridviewlar.Name = "gridView" + i;
                this.gridviewlar.OptionsView.ColumnAutoWidth = false;
                
                this.gridcontroller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewlar});
                ((System.ComponentModel.ISupportInitialize)(this.gridcontroller)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.gridviewlar)).EndInit();
                this.gridviewlar.Columns[0].Visible = false;
            }
        }
    }
}
