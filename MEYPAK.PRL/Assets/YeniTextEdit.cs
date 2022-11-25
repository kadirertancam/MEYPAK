using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.Assets
{
    public partial class YeniTextEdit : TextEdit
    {
        public YeniTextEdit()
        {
            InitializeComponent();
            this.Enter += YeniTextEdit_Enter;  
        }
        int sayac=0;
      

        private void YeniTextEdit_Enter(object? sender, EventArgs e)
        {
            this.SelectionStart = 0;
            this.SelectionLength = this.Text.Length;
        }

        
    }
}
