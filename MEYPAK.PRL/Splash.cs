using DevExpress.XtraSplashScreen;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        GenericWebServis<PocoSTOKRESIM> _stokResimServis;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
          //  _stokResimServis.obje.Where(x => x.STOKID == stokid).Select(x => new { Resim = Base64ToImage(x.IMG) });





            System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream file =
                thisExe.GetManifestResourceStream("ZedGraph.Demo.ngc4414.jpg");
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}