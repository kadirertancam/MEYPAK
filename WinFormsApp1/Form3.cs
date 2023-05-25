using DevExpress.XtraReports.UI;
using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent(); 
           
        }
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLongPtrA(IntPtr hWnd, int nIndex);
        //public List<string> GetPrinterList()
        //{
        //    // BarTender uygulamasını oluşturun
        //    Engine engine = new Engine();
        //    engine.Start();

        //    try
        //    {
        //        // Mevcut yazıcı listesini alın
        //        Printers printers = new Printers(engine);

        //        // Yazıcı isimlerini içeren bir liste oluşturun
        //        List<string> printerList = new List<string>();

        //        foreach (Printer printer in printers)
        //        {
        //            printerList.Add(printer.PrinterName);
        //        }

        //        return printerList;
        //    }
        //    finally
        //    {
        //        engine.Stop();
        //    }
        //}


        private void Form3_Load(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            // Invoke the Print dialog.
            printTool.PrintDialog();
            // Send the report to the default printer.
            //printTool.Print();
            //// Send the report to the specified printer.
            //printTool.Print("myPrinter");
        }
    }
}
