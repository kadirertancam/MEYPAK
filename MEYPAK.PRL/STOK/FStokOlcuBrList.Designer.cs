﻿namespace MEYPAK.PRL.STOK
{
    partial class FStokOlcuBrList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GCStokOlcuBrList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GCStokOlcuBrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCStokOlcuBrList
            // 
            this.GCStokOlcuBrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStokOlcuBrList.Location = new System.Drawing.Point(0, 0);
            this.GCStokOlcuBrList.MainView = this.gridView1;
            this.GCStokOlcuBrList.Name = "GCStokOlcuBrList";
            this.GCStokOlcuBrList.Size = new System.Drawing.Size(1398, 818);
            this.GCStokOlcuBrList.TabIndex = 0;
            this.GCStokOlcuBrList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GCStokOlcuBrList.Load += new System.EventHandler(this.FStokOlcuBrList_Load_1);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 303;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.GCStokOlcuBrList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FStokOlcuBrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 818);
            this.Controls.Add(this.GCStokOlcuBrList);
            this.Name = "FStokOlcuBrList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FStokOlcuBrList";
            this.Load += new System.EventHandler(this.FStokOlcuBrList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GCStokOlcuBrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCStokOlcuBrList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}