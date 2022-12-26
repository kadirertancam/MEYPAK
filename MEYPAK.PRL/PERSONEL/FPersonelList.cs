using MEYPAK.BLL.PERSONEL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Personel;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using DevExpress.XtraEditors;
using MEYPAK.Interfaces.Depo;
using MEYPAK.PRL.DEPO.Raporlar;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK.Raporlar;
using MEYPAK.PRL.PERSONEL.Raporlar;
using System.Windows.Media.TextFormatting;
using DevExpress.XtraTab;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.KASA;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelList : XtraForm
    {
        FPersonelKart FPersonelKart;
        public FPersonelList(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _personelServis = new GenericWebServis<PocoPERSONEL>();
        }
        #region Tanımlar
        string _islem, _form;
        GenericWebServis<PocoPERSONEL> _personelServis;
        FPersonelKart fPersonelKart;
        FPersonelRaporu fPersonelRaporu;
        FKasaHareket fKasaHareket;
        public PocoPERSONEL _tempPocoPERSONEL;
        Main main;
        int i = 0;

        #endregion
        private void FPersonelList_Load(object sender, EventArgs e)
        {
            _personelServis.Data(ServisList.PersonelListeServis);
            DGPersonelList.DataSource = _personelServis.obje;
            gridView1.Columns["id"].VisibleIndex = 0;
            gridView1.Columns["tc"].VisibleIndex = 1;
            gridView1.Columns["adi"].VisibleIndex = 2;
            gridView1.Columns["soyadi"].VisibleIndex = 3;
            gridView1.Columns["adisoyadi"].VisibleIndex = 4;
            gridView1.Columns["dogumtar"].VisibleIndex = 5;

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FPersonelKart"))
                        fPersonelKart = (FPersonelKart)frm; 
                    else if (frm.Name.Contains("FPersonelRaporu"))
                        fPersonelRaporu = (FPersonelRaporu)frm;
                    else if (frm.Name.Contains("FKasaHareket"))
                        fKasaHareket = (FKasaHareket)frm;
                }
            }

        }

        private void DGPersonelList_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FPersonelKart")
            {
                fPersonelKart._tempPocoPERSONEL = _personelServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            else if (_islem == "FPersonelRaporu")
            {
                fPersonelRaporu._tempPersonel =   _personelServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            else if (_islem == "FKasaHareket")
            {
                fKasaHareket._tempPersonel     =  _personelServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }


            this.Close();
        }
    }
    }