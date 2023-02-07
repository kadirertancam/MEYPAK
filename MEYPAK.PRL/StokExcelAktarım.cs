using DevExpress.ClipboardSource.SpreadsheetML;
using ExcelDataReader;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class StokExcelAktarım : Form
    {
        public StokExcelAktarım()
        {
            InitializeComponent();
            listtstok = new List<PocoSTOK>();
            _stokMarkaServis = new GenericWebServis<PocoSTOKMARKA>();
            _stokKategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
        }

        DataTable temptable;
        List<PocoSTOK> listtstok;
        GenericWebServis<PocoSTOKMARKA> _stokMarkaServis;
        GenericWebServis<PocoSTOKKATEGORI> _stokKategoriServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBrServis;
        string path = "";
        Syncfusion.XlsIO.IWorkbook workbook;
        private void button1_Click(object sender, EventArgs e)
        {
            _stokMarkaServis.Data(ServisList.StokMarkaListeServis);
            _stokKategoriServis.Data(ServisList.StokKategoriListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                temptable= ConvertExcelToDataTable(openFileDialog.FileName);
                gridControl1.DataSource = temptable;
                for (int i = 0; i < temptable.Rows.Count; i++)
                { 
                        var tesst = temptable.Rows[i];
                     
                    _stokServis.Data(ServisList.StokEkleServis, new PocoSTOK()
                    {
                        kod = tesst[0].ToString(),
                        adi = tesst[1].ToString(),
                        markaid = _stokMarkaServis.obje.Where(x => x.adi == tesst[2].ToString()).FirstOrDefault().id,
                        kategoriid = _stokKategoriServis.obje.Where(x => x.acıklama == tesst[3].ToString()).FirstOrDefault().id,
                        olcubR1 = _olcuBrServis.obje.Where(x => x.birim == tesst[4].ToString()).FirstOrDefault().id,
                        aliskdv = 1,
                        satiskdv = 1,
                        userid = MPKullanici.ID,
                    });
                    _stokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis, new PocoSTOKOLCUBR()
                    {
                        katsayi = 1,
                        num = 1,
                        olcubrid = _olcuBrServis.obje.Where(x => x.birim == tesst[4].ToString()).FirstOrDefault().id,
                        stokid = _stokServis.obje2.id,
                        userid = MPKullanici.ID,
                    });
                }
            }
        }
        public static DataTable ConvertExcelToDataTable(string FileName)
        {
            DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file  
            using (OleDbConnection objConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"))
            {
                objConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = string.Empty;
                if (dt != null)
                {
                    var tempDataTable = (from dataRow in dt.AsEnumerable()
                                         where !dataRow["TABLE_NAME"].ToString().Contains("FilterDatabase")
                                         select dataRow).CopyToDataTable();
                    dt = tempDataTable;
                    totalSheet = dt.Rows.Count;
                    sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                }
                cmd.Connection = objConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds, "excelData");
                dtResult = ds.Tables["excelData"];
                objConn.Close();
                return dtResult; //Returning Dattable  
            }
        }
    }
}
