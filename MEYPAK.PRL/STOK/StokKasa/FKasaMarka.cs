﻿using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK.StokKasa
{
    public partial class FKasaMarka : Form
    {
        public FKasaMarka()
        {
            InitializeComponent();
            _stokKasaMarakServis = new GenericWebServis<PocoSTOKKASAMARKA>();
        }
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarakServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.STOKKASAMARKATANIM.ToString()).EKLE==true)
            {
            _stokKasaMarakServis.Data(ServisList.StokKasaMarkaEkleServis,new PocoSTOKKASAMARKA()
            {
                adi=textEdit2.Text,
                kod=textEdit1.Text,
                aktif=1,
                userid = MPKullanici.ID,
            });
            _stokKasaMarakServis.Data(ServisList.StokKasaMarkaListeServis);

            gridControl1.DataSource = _stokKasaMarakServis.obje;
            gridControl1.RefreshDataSource();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void FKasaMarka_Load(object sender, EventArgs e)
        {
            _stokKasaMarakServis.Data(ServisList.StokKasaMarkaListeServis);

            gridControl1.DataSource = _stokKasaMarakServis.obje;
        }
    }
}
