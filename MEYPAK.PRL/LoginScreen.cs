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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            
        }
        Main fMain;
        private void BTNGiris_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text=="Admin")
            {
                fMain = new Main();
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!");
            }
        }
    }
}
