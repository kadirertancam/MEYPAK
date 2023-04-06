using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Shapes;
using System.Net.Http;

namespace MEYPAK.UPDATE
{
    public partial class FUpdate : SplashScreen
    {
        public FUpdate()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        HttpClient httpClient;
        private void FUpdate_Load(object sender, EventArgs e)
        {
            HttpRequestMessage client;
            MessageBox.Show("İŞLEMBAŞLADI");

            string folderPath = Application.StartupPath.ToString()+"\\PRL"; // Klasör yolu
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            DirectorySecurity folderSecurity = folderInfo.GetAccessControl();
            SecurityIdentifier everyoneSid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            folderSecurity.AddAccessRule(new FileSystemAccessRule(everyoneSid, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            folderInfo.SetAccessControl(folderSecurity);
            Console.WriteLine("Herkes kullanıcısına tam denetim izinleri verildi.");
            if (File.Exists(@".\Version.txt"))
            {
                client = new HttpRequestMessage(HttpMethod.Post, "http://78.135.80.41:8081/Versiyon/Index");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("accept", "*/*");
                client.Headers.Add("Referer", "");
                client.Headers.Add("Origin", "");
                client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
                client.Headers.Add("sec-ch-ua-mobile", "?0");
                client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");  
                client.Headers.Add("Sec-Fetch-Dest", "empty");
                client.Headers.Add("Sec-Fetch-Mode", "cors");
                client.Headers.Add("Sec-Fetch-Site", "same-origin");
                client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");



            }

           
        }

        private void guncelle()
        {
            var client = new WebClient();
            try
            {
                Thread.Sleep(3000);
                File.Delete(@".\PRL\MEYPAK.PRL.exe");
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\PRL\\");
                foreach (FileInfo fi in dir.GetFiles())
                {
                    try
                    {
                        fi.Delete();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); } // Ignore all exceptions
                }
                DirectoryInfo[] subDirectories = dir.GetDirectories();
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    subDirectory.Delete(true);
                }
                client.DownloadFile(new Uri("https://elizmeypak.com.tr/Guncelleme/MEYPAK.PRL.zip"), Application.StartupPath + @"/MEYPAK.PRL.zip");
                string zipPath = @"./MEYPAK.PRL.zip";
                string extractPath = @".\PRL\";




                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\MEYPAK.PRL.zip");
                // Process.Start(@".\MEYPAK.PRL.exe");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //  Process.Start("MEYPAK.PRL.exe");
            }
        }
    }
}