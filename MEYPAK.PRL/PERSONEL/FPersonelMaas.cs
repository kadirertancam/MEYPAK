using DevExpress.XtraEditors;
using ExcelDataReader;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelMaas : XtraForm
    {
        public FPersonelMaas()
        {
            InitializeComponent();
            temp = new List<PersonelMaasTemp>();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            //Veriler okunmaya başlıyor.
            //while (MaasexcelReader.Read())
            //{
            //    counter++;

            //    if (counter > 1)
            //    {
            //        try
            //        {

            //            if (MaasexcelReader[1] != null || MaasexcelReader[6] != null)
            //            {
            //                temp.Add(new PersonelMaasTemp()
            //                {
            //                    TC = MaasexcelReader[1] == null ? "" : MaasexcelReader.GetValue(1).ToString(),
            //                    MAAS = MaasexcelReader[6] == null ? 0 : MaasexcelReader.GetDouble(6)
            //                });
            //            }
            //        }
            //        catch (Exception)
            //        {


            //        }

            //    }
            //}
            //counter = 0;
            //while (BesexcelReader.Read())
            //{
            //    counter++;

            //    if (counter > 1)
            //    {
            //        try
            //        {

            //            if (BesexcelReader[1] != null || BesexcelReader[6] != null)
            //            {
            //                temp.Add(new PersonelMaasTemp()
            //                {
            //                    TC = BesexcelReader[1] == null ? "" : MaasexcelReader.GetValue(1).ToString(),
            //                    MAAS = BesexcelReader[6] == null ? 0 : MaasexcelReader.GetDouble(6)
            //                });
            //            }
            //        }
            //        catch (Exception)
            //        {


            //        }

            //    }
            //}
            foreach (var item in temp)
            {
                item.SONUC = (item.KARTAYATAN + item.BES ) - item.MESAI - item.TRAFIKCEZASI - item.AVANS - item.HACIZ - item.MAAS-item.GELMEDIGIGUN;
            }
            gridControl1.RefreshDataSource();
            

        }
        List<PersonelMaasTemp> temp;
        IExcelDataReader MaasexcelReader;
        IExcelDataReader BesexcelReader;
        IExcelDataReader DagitilanMaasexcelReader;
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyası|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                //Encoding 1252 hatasını engellemek için;

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                int counter = 0;

                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    MaasexcelReader = ExcelReaderFactory.CreateReader(stream);
                }
                else
                {
                    MaasexcelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }


                while (MaasexcelReader.Read())
                {
                    counter++;

                    if (counter > 1)
                    {
                        try
                        {

                            if (MaasexcelReader[1] != null || MaasexcelReader[6] != null)
                            {
                                temp.Add(new PersonelMaasTemp()
                                {
                                    TC = MaasexcelReader[1] == null ? "" : MaasexcelReader.GetValue(1).ToString(),
                                    KARTAYATAN = MaasexcelReader[6] == null ? 0 : MaasexcelReader.GetDouble(6)
                                });
                            }
                        }
                        catch (Exception)
                        {


                        }

                    }
                }

                //Okuma bitiriliyor.
                MaasexcelReader.Close();
            }
        }

        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyası|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                //Encoding 1252 hatasını engellemek için;

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                int counter = 0;


                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    BesexcelReader = ExcelReaderFactory.CreateReader(stream);
                }
                else
                {
                    BesexcelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                while (BesexcelReader.Read())
                {
                    counter++;
                    
                        if (counter > 1)
                        {
                            try
                            {

                                if (BesexcelReader[7] != null)
                                { 

                                    temp.Where(x=>x.TC==BesexcelReader[8].ToString()).FirstOrDefault().BES=BesexcelReader.GetDouble(7);
                                }
                            }
                            catch (Exception)
                            {

                             
                            }

                        } 
                }
            }
            gridControl1.DataSource = temp;
            gridControl1.RefreshDataSource();
        }

        private void buttonEdit3_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyası|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                //Encoding 1252 hatasını engellemek için;

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                int counter = 0;


                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    DagitilanMaasexcelReader = ExcelReaderFactory.CreateReader(stream);
                }
                else
                {
                    DagitilanMaasexcelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                while (DagitilanMaasexcelReader.Read())
                {
                    counter++;

                    if (counter > 1)
                    {
                      
                        if (DagitilanMaasexcelReader[7] != null)
                        {
                            try
                            {

                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().SIGORTADAKIMAAS = DagitilanMaasexcelReader.GetDouble(9);
                            }
                            catch (Exception)
                            {


                            }
                            try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().MAAS = DagitilanMaasexcelReader.GetDouble(10);
                            }
                            catch (Exception)
                            {


                            }
                            try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().GELMEDIGIGUN = DagitilanMaasexcelReader.GetDouble(11);
                            }
                            catch (Exception)
                            {


                            }  try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().MESAI = DagitilanMaasexcelReader.GetDouble(18);
                            }
                            catch (Exception)
                            {


                            } try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().TRAFIKCEZASI = DagitilanMaasexcelReader.GetDouble(20);
                            }
                            catch (Exception)
                            {


                            }try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().AVANS = DagitilanMaasexcelReader.GetDouble(21);
                            }
                            catch (Exception)
                            {


                            }try
                            {
                                temp.Where(x => x.TC == DagitilanMaasexcelReader[8].ToString()).FirstOrDefault().HACIZ = DagitilanMaasexcelReader.GetDouble(22);
                            }
                            catch (Exception)
                            {


                            }

                        }
                       

                    }
                }
                gridControl1.DataSource = temp;
                gridControl1.RefreshDataSource();
            }
        }
    }
}
