using DevExpress.Utils.Extensions;
using DevExpress.XtraReports.Templates;
using DevExpress.XtraSplashScreen;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace MEYPAK.PRL
{
    public partial class Splash : SplashScreen
    {
        public Splash()
        {
            _stokResimServis = new GenericWebServis<PocoSTOKRESIM>();
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
             im= new List<Image>();
        }
        GenericWebServis<PocoSTOKRESIM> _stokResimServis;
        #region Overrides
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
        public override void ProcessCommand(Enum cmd, object arg)
        {
            //log



            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        public List<Image> im;
        private void Splash_Load(object sender, EventArgs e)
        {
            string resxFile = Application.StartupPath + "/resourcefile.resx";
            using (ResXResourceWriter resx = new ResXResourceWriter(resxFile))
            {


                Image img;
                _stokResimServis.Data(ServisList.StokResimListeServis);
                foreach (var item in _stokResimServis.obje.Select(x => new { x.STOKID, x.IMG }))
                {
                    img = Base64ToImage(item.IMG);

                    resx.AddResource("elizmeypak_"+item.STOKID.ToString(), new Bitmap(img));



                }
                resx.Close(); 
            }
          
            using (ResXResourceReader resxReader = new ResXResourceReader(resxFile))
            {
                foreach (DictionaryEntry entry in resxReader)
                {
                    if (((string)entry.Key).StartsWith("elizmeypak"))
                        im.Add(((Image)entry.Value));
                }
            }
            //string[] headerColumns = new string[headers.Count];
            //headers.GetValueList().CopyTo(headerColumns, 0);
            //Console.WriteLine("{0,-8} {1,-10} {2,-4}   {3,-5}   {4,-9}\n",
            //                  headerColumns);
            //foreach (var auto in autos)
            //    Console.WriteLine("{0,-8} {1,-10} {2,4}   {3,5}   {4,9}",
            //                      auto.Make, auto.Model, auto.Year,
            //                      auto.Doors, auto.Cylinders);
        }
    }

} 