namespace SCBypass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveCred = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdvSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // edtUsername
            // 
            this.edtUsername.Location = new System.Drawing.Point(78, 13);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(117, 20);
            this.edtUsername.TabIndex = 2;
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(78, 39);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(117, 20);
            this.edtPassword.TabIndex = 3;
            this.edtPassword.UseSystemPasswordChar = true;
            // 
            // btnSaveCred
            // 
            this.btnSaveCred.Location = new System.Drawing.Point(16, 65);
            this.btnSaveCred.Name = "btnSaveCred";
            this.btnSaveCred.Size = new System.Drawing.Size(179, 48);
            this.btnSaveCred.TabIndex = 4;
            this.btnSaveCred.Text = "Save Credentials";
            this.btnSaveCred.UseVisualStyleBackColor = true;
            this.btnSaveCred.Click += new System.EventHandler(this.btnSaveCred_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(16, 120);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(13, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(182, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Enter credentials and click \"Login\"";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdvSettings
            // 
            this.btnAdvSettings.Location = new System.Drawing.Point(16, 229);
            this.btnAdvSettings.Name = "btnAdvSettings";
            this.btnAdvSettings.Size = new System.Drawing.Size(179, 23);
            this.btnAdvSettings.TabIndex = 8;
            this.btnAdvSettings.Text = "Advanced Settings";
            this.btnAdvSettings.UseVisualStyleBackColor = true;
            this.btnAdvSettings.Click += new System.EventHandler(this.btnAdvSettings_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 265);
            this.Controls.Add(this.btnAdvSettings);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSaveCred);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SC Bypass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtUsername;
        private System.Windows.Forms.MaskedTextBox edtPassword;
        private System.Windows.Forms.Button btnSaveCred;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAdvSettings;
    }
}

