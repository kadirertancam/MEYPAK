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
using DevExpress.XtraRichEdit.Import.Html;
using System.Threading.Tasks;
using DevExpress.XtraMap;

namespace MEYPAK.UPDATE
{
    public partial class FUpdate : SplashScreen
    {
        public FUpdate()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
            httpClient = new HttpClient();
            clientt = new WebClient();
        }

        #region Overrides
        WebClient clientt; HttpClient httpClient;
        string Content;
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
      
        private   void FUpdate_Load(object sender, EventArgs e)
        {
            HttpRequestMessage client; 
            if(!Directory.Exists(Application.StartupPath.ToString() + "\\PRL")){
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\PRL");
            }
            string folderPath = Application.StartupPath.ToString()+"\\PRL"; // Klasör yolu
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            DirectorySecurity folderSecurity = folderInfo.GetAccessControl();
            SecurityIdentifier everyoneSid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            folderSecurity.AddAccessRule(new FileSystemAccessRule(everyoneSid, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            folderInfo.SetAccessControl(folderSecurity); 
           
                client = new HttpRequestMessage(HttpMethod.Post, "http://78.135.80.41:8081/Versiyon");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("accept", "*/*");
                client.Headers.Add("Referer", "http://78.135.80.41:8081/Versiyon");
                client.Headers.Add("Origin", "http://78.135.80.41:8081");
                client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
                client.Headers.Add("sec-ch-ua-mobile", "?0");
                client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");  
                client.Headers.Add("Sec-Fetch-Dest", "empty");
                client.Headers.Add("Sec-Fetch-Mode", "cors");
                client.Headers.Add("Sec-Fetch-Site", "same-origin");
                client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                HttpResponseMessage resp = httpClient.Send(client);
                Content = resp.Content.ReadAsStringAsync().Result;

                clientt.DownloadProgressChanged += Client_DownloadProgressChanged;
                clientt.DownloadFileCompleted += Client_DownloadFileCompleted;
            if (!File.Exists(@".\Version.txt"))
            { 
                StreamWriter st = new StreamWriter(@".\Version.txt");
                st.WriteLine("0.0.0.0");
                st.Close();
                Thread.Sleep(200);
            }
                var snc=  File.ReadAllLines(@".\Version.txt");
                if (snc[0] != Content.ToString())
                {
                    labelStatus.Text = "Yeni versiyon bulundu..";
                   Task.Factory.StartNew(new Action(() =>
                   {
                       guncelle();
                   }));
                   
                }
                else
                {
                    Task.Factory.StartNew(new Action(() =>
                    {
                        Thread.Sleep(3000);
                        Process.Start(@".\PRL\MEYPAK.PRL.exe");
                        this.Invoke(new Action(() => { this.Close(); }));
                    }));
                    
                }

          
           
        }

        private  async void  guncelle()
        {
           
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
                this.Invoke(new Action(() => { labelStatus.Text = "Yeni versiyon indiriliyor.."; 
                    }));
                  clientt.DownloadFileAsync(new Uri("https://elizmeypak.com.tr/Guncelleme/MEYPAK.PRL.zip"), Application.StartupPath + @"/MEYPAK.PRL.zip");
             
               


                 
                
            }
            catch (Exception ex)
            {

                this.Invoke(new Action(() => {
                    MessageBox.Show(ex.Message);
                    this.Close(); }));
                //  Process.Start("MEYPAK.PRL.exe");
            }
        }

        private   void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string zipPath = @"./MEYPAK.PRL.zip";
            string extractPath = @".\PRL\";
            this.Invoke(new Action(() => { labelStatus.Text = "Dosyalar açılıyor.."; }));
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            Thread.Sleep(3000);
            File.Delete(@".\MEYPAK.PRL.zip");
            this.Invoke(new Action(() => { labelStatus.Text = "Güncelleme işlemi tamamlandı.."; }));
            Thread.Sleep(1000);
            StreamWriter st = new StreamWriter(@".\Version.txt");
            st.WriteLine(Content);
            st.Close();
            Process.Start(@".\PRL\MEYPAK.PRL.exe");
            Thread.Sleep(500);
            this.Invoke(new Action(() => { this.Close(); }));
        }

        private   void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                labelStatus.Text = $"Yeni versiyon indiriliyor.. %{e.ProgressPercentage}";
            }));
        }

        private void peLogo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}