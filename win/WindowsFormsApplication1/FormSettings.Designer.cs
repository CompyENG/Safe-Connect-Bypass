namespace SCBypass
{
    partial class FormSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtUserAgent = new System.Windows.Forms.TextBox();
            this.edtRetryPage = new System.Windows.Forms.TextBox();
            this.edtNeedLoginCheck = new System.Windows.Forms.TextBox();
            this.edtRetryFailPageContains = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPause = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page to try grabbing:";
            this.toolTip1.SetToolTip(this.label1, "Page to grab to check if login is needed.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User-Agent to Login as:";
            this.toolTip1.SetToolTip(this.label2, "Sent as the User-Agent on all HTTP requests");
            // 
            // edtUserAgent
            // 
            this.edtUserAgent.Location = new System.Drawing.Point(137, 10);
            this.edtUserAgent.Name = "edtUserAgent";
            this.edtUserAgent.Size = new System.Drawing.Size(237, 20);
            this.edtUserAgent.TabIndex = 2;
            // 
            // edtRetryPage
            // 
            this.edtRetryPage.Location = new System.Drawing.Point(137, 36);
            this.edtRetryPage.Name = "edtRetryPage";
            this.edtRetryPage.Size = new System.Drawing.Size(237, 20);
            this.edtRetryPage.TabIndex = 3;
            // 
            // edtNeedLoginCheck
            // 
            this.edtNeedLoginCheck.Location = new System.Drawing.Point(137, 62);
            this.edtNeedLoginCheck.Name = "edtNeedLoginCheck";
            this.edtNeedLoginCheck.Size = new System.Drawing.Size(237, 20);
            this.edtNeedLoginCheck.TabIndex = 4;
            // 
            // edtRetryFailPageContains
            // 
            this.edtRetryFailPageContains.Location = new System.Drawing.Point(137, 88);
            this.edtRetryFailPageContains.Name = "edtRetryFailPageContains";
            this.edtRetryFailPageContains.Size = new System.Drawing.Size(237, 20);
            this.edtRetryFailPageContains.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text if login needed:";
            this.toolTip1.SetToolTip(this.label3, "Text to search for in page source if login is needed (some unique string from the" +
                    " login page)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text if redirecting:";
            this.toolTip1.SetToolTip(this.label4, "Text in source code to search for if login is redirecting (some unique string in " +
                    "page you\'re redirected to)");
            // 
            // numPause
            // 
            this.numPause.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPause.Location = new System.Drawing.Point(137, 114);
            this.numPause.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPause.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPause.Name = "numPause";
            this.numPause.Size = new System.Drawing.Size(68, 20);
            this.numPause.TabIndex = 8;
            this.numPause.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Help;
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pause between retries:";
            this.toolTip1.SetToolTip(this.label5, "Pause in milliseconds between \"stop redirecting\" retries.");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(194, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ms";
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(386, 175);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtRetryFailPageContains);
            this.Controls.Add(this.edtNeedLoginCheck);
            this.Controls.Add(this.edtRetryPage);
            this.Controls.Add(this.edtUserAgent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SC Bypass Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtUserAgent;
        private System.Windows.Forms.TextBox edtRetryPage;
        private System.Windows.Forms.TextBox edtNeedLoginCheck;
        private System.Windows.Forms.TextBox edtRetryFailPageContains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}