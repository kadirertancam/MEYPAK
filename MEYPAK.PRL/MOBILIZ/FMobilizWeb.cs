using MEYPAK.PRL.MOBILIZ.MobilizAssets;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsInput;

namespace MEYPAK.PRL.MOBILIZ
{
    public partial class FMobilizWeb : Form
    {
        public FMobilizWeb()
        {
            InitializeComponent();
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
        }
        private async void FMobilizWeb_Load(object sender, EventArgs e)
        {

            string url = "https://ng.mobiliz.com.tr/#!/login";

            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri(url);
        }
        private void WebView21_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            this.Focus();
            var sim = new InputSimulator();

            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            // Kullanıcı adı alanına klavye girişi yap
            sim.Keyboard.TextEntry("MBZ-031985");

            // Tab tuşuna basarak parola alanına geç
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);

            // Parola alanına klavye girişi yap
            sim.Keyboard.TextEntry("A3461.ts");

            // Enter tuşuna basarak giriş yap
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }



        #region OLD_METHODS


        //private void Kontrol()
        //{

        //    if (!IsCapsLockOn())
        //        BilgileriDoldur();
        //    else
        //    {
        //        var result = System.Windows.MessageBox.Show("Devam etmek için Klavyenizdeki büyük harf(Capslook) tuşunu deaktif etmeniz gerekmektedir. \n Kapattıktan sonra Onaylayınız. ", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question);

        //        if (result == MessageBoxResult.Yes)
        //        {
        //            if (!IsCapsLockOn())
        //                BilgileriDoldur();
        //        }
        //        else
        //            Kontrol();
        //    }


        //}

        //private async Task BilgileriDoldur()
        //{

        //    string usernamescript = $"document.querySelector(\"input[id='username']\").value = 'MBZ-031985';";
        //    string passwordScript = $"document.getElementById('password').value = 'A3461.ts';";

        //    string script = @"(function() {
        //        var username = 'kullanıcı_adı';
        //        var password = 'parola';
        //        var usernameField = document.getElementById('username');
        //        var passwordField = document.getElementById('password');
        //        var loginButton = document.querySelector('.login-btn');

        //        usernameField.value = MBZ-031985;
        //        passwordField.value = A3461.ts;
        //        loginButton.click();
        //    })();";
        //    this.TopMost = true;
        //    // WebView2'nin hazır olduğundan emin olun
        //    await webView21.EnsureCoreWebView2Async();
        //    await webView21.ExecuteScriptAsync(script);
        //    // JavaScript motorunun yüklendiğinden emin olun
        //    webView21.CoreWebView2.DOMContentLoaded += async (s, e) =>
        //        {

        //            //Task.Delay(100);
        //            //SendKeys((byte)Keys.Tab);
        //            //await webView21.ExecuteScriptAsync(usernamescript);
        //            //SendKeys((byte)0x08);
        //            //SendKeys(53);

        //            //SendKeys((byte)Keys.Tab);
        //            //await webView21.ExecuteScriptAsync(passwordScript);
        //            //SendKeys((byte)0x08);
        //            //SendKeys((byte)Keys.S);

        //            //SendKeys((byte)Keys.Enter);

        //        };
        //    this.TopMost = false;
        //}

        //[DllImport("user32.dll")]
        //public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        //private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        //private const int KEYEVENTF_KEYUP = 0x0002;

        //private void SendKeys(byte keyCode)
        //{
        //    keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY, UIntPtr.Zero);
        //    keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
        //}

        //[DllImport("user32.dll")]
        //public static extern short GetKeyState(int nVirtKey);

        //private const int VK_CAPITAL = 0x14;

        //private bool IsCapsLockOn()
        //{

        //    return (GetKeyState(VK_CAPITAL) & 0x0001) != 0;
        //}
        #endregion
    }
}
