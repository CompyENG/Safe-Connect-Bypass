using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCBypass
{
    public partial class FormSettings : Form
    {
        public Properties.Settings settings {
            get;
            set;
        }
        public FormSettings(Properties.Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            edtNeedLoginCheck.Text = settings.needLoginCheck;
            edtRetryFailPageContains.Text = settings.retryFailPageContains;
            edtRetryPage.Text = settings.retryPage;
            edtUserAgent.Text = settings.userAgent;
            numPause.Value = settings.pauseBetween;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.needLoginCheck = edtNeedLoginCheck.Text;
            settings.retryFailPageContains = edtRetryFailPageContains.Text;
            settings.retryPage = edtRetryPage.Text;
            settings.userAgent = edtUserAgent.Text;
            settings.pauseBetween = (int)numPause.Value;
            settings.Save();
            this.Close();
        }
    }
}
