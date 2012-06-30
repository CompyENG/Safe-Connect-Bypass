using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SCBypass
{
    public partial class Form1 : Form
    {
        private delegate void ThreadDelegate(int progress);
        private delegate void ThreadDelegate2(String status);
        private ThreadDelegate threadDelegate1;
        private ThreadDelegate2 threadDelegate2;
        public Properties.Settings settings;
        private Boolean keyHandled;
        //private const string USER_AGENT = "Mozilla/5.0 (X11; U; Linux x86_64; en_US; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8";
        public Form1()
        {
            settings = new Properties.Settings();
            settings.Reload();
            InitializeComponent();
            edtUsername.Text = settings.username;
            edtPassword.Text = settings.password;
            threadDelegate1 = new ThreadDelegate(updateProgress);
            threadDelegate2 = new ThreadDelegate2(updateStatus);
            keyHandled = false;
            this.KeyDown += Form1_KeyDown;
            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.W)
            {
                keyHandled = true;
                Application.Exit();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHandled == true)
            {
                e.Handled = true;
                keyHandled = false;
            }
        }

        private void updateStatus(String status)
        {
            lblStatus.Text = status;
        }

        private void updateProgress(int progress)
        {
            progressBar1.Value = progress;
        }

        private void btnSaveCred_Click(object sender, EventArgs e)
        {
            settings.username = edtUsername.Text;
            settings.password = edtPassword.Text;
            settings.Save();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Array data = Array.CreateInstance(typeof(String), 2);
            data.SetValue(edtUsername.Text, 0);
            data.SetValue(edtPassword.Text, 1);
            Thread th = new Thread(doLogin);
            th.IsBackground = true;
            th.Start(data);
        }

        private void doLogin(object data)
        {
            String username = (string)((Array)data).GetValue(0);
            String password = (string)((Array)data).GetValue(1);

            progressBar1.Invoke(threadDelegate1, new object[] { (int)0 });
            lblStatus.Invoke(threadDelegate2, new object[] { "Checking if login need..." });
            
            string checkResponse = SimpleWebRequest(settings.retryPage, settings.userAgent);

            if (!checkResponse.Contains(settings.needLoginCheck))
            {
                progressBar1.Invoke(threadDelegate1, new object[] { (int)100 });
                lblStatus.Invoke(threadDelegate2, new object[] { "No login needed!" });
                return;
            }

            progressBar1.Invoke(threadDelegate1, new object[] { (int)33 });
            lblStatus.Invoke(threadDelegate2, new object[] { "Logging in..." });

            // This SHOULD be the same for every SafeConnect system... so it doesn't need to be a setting
            string loginData = "userId=" + Uri.EscapeDataString(username) + "&pass=" + Uri.EscapeDataString(password);
            string loginResponse = SimpleWebRequest("http://auth.impulse.com:8008/authenticate.!^", settings.userAgent, loginData);

            if (!loginResponse.Contains(settings.retryFailPageContains))
            {
                progressBar1.Invoke(threadDelegate1, new object[] { (int)0 });
                lblStatus.Invoke(threadDelegate2, new object[] { "Failed to login!" });
                return;
            }

            progressBar1.Invoke(threadDelegate1, new object[] { (int)66 });
            lblStatus.Invoke(threadDelegate2, new object[] { "Checking login..." });

            Thread.Sleep(settings.pauseBetween);
            string redirectResponse = SimpleWebRequest(settings.retryPage, settings.userAgent);
            int i = 1;

            while (redirectResponse.Contains(settings.retryFailPageContains))
            {
                lblStatus.Invoke(threadDelegate2, new object[] { "Still redirecting... try #"+i });
                Thread.Sleep(settings.pauseBetween);
                redirectResponse = SimpleWebRequest(settings.retryPage, settings.userAgent);
                i++;
            }

            progressBar1.Invoke(threadDelegate1, new object[] { (int)100 });
            lblStatus.Invoke(threadDelegate2, new object[] { "Logged in!" });
        }

        private String SimpleWebRequest(string uri, string UserAgent, string postData=null)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
            req.UserAgent = UserAgent;
            if (postData != null)
            {
                req.Method = "POST";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = byteArray.Length;
                Stream reqStream = req.GetRequestStream();
                reqStream.Write(byteArray, 0, byteArray.Length);
                reqStream.Close();
            }
            try
            {
                WebResponse response = req.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string serverResponse = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                return serverResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something's wrong in SimpleWebRequest!");
                Console.WriteLine(e.ToString());
                Console.WriteLine("----------");
                return ""; // null could be bad... just return an empty string.
            }
        }

        private void btnAdvSettings_Click(object sender, EventArgs e)
        {
            FormSettings frmSettings = new FormSettings(settings);
            frmSettings.ShowDialog(this);
        }
    }
}
