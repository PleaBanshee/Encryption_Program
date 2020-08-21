namespace EncryptAllFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTipBrowse = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEncrypt = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDecrypt = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPlainPath = new System.Windows.Forms.TextBox();
            this.txtEncryptPath = new System.Windows.Forms.TextBox();
            this.txtDecryptPath = new System.Windows.Forms.TextBox();
            this.btnViewEncrypted = new System.Windows.Forms.Button();
            this.btnViewDecrypted = new System.Windows.Forms.Button();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.btnBrowseContent = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipViewEncrypted = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(27, 107);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(565, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(653, 98);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 42);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEncrypt.ForeColor = System.Drawing.Color.Lime;
            this.rbtnEncrypt.Location = new System.Drawing.Point(191, 146);
            this.rbtnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(101, 21);
            this.rbtnEncrypt.TabIndex = 3;
            this.rbtnEncrypt.TabStop = true;
            this.rbtnEncrypt.Text = "ENCRYPT";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            this.rbtnEncrypt.CheckedChanged += new System.EventHandler(this.rbtnEncrypt_CheckedChanged);
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDecrypt.ForeColor = System.Drawing.Color.Lime;
            this.rbtnDecrypt.Location = new System.Drawing.Point(309, 146);
            this.rbtnDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(101, 21);
            this.rbtnDecrypt.TabIndex = 4;
            this.rbtnDecrypt.TabStop = true;
            this.rbtnDecrypt.Text = "DECRYPT";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            this.rbtnDecrypt.CheckedChanged += new System.EventHandler(this.rbtnDecrypt_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(27, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 194);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(459, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(27, 241);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(725, 95);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(291, 566);
            this.txtEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncrypt.Size = new System.Drawing.Size(193, 153);
            this.txtEncrypt.TabIndex = 8;
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(24, 566);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlain.Size = new System.Drawing.Size(193, 153);
            this.txtPlain.TabIndex = 9;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(556, 566);
            this.txtDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecrypt.Size = new System.Drawing.Size(193, 153);
            this.txtDecrypt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(24, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(115, 421);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(618, 22);
            this.txtPass.TabIndex = 13;
            this.txtPass.Text = "The quick red fox jumped over the sleeping dog";
            // 
            // txtPlainPath
            // 
            this.txtPlainPath.Location = new System.Drawing.Point(24, 527);
            this.txtPlainPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlainPath.Name = "txtPlainPath";
            this.txtPlainPath.Size = new System.Drawing.Size(193, 22);
            this.txtPlainPath.TabIndex = 17;
            // 
            // txtEncryptPath
            // 
            this.txtEncryptPath.Location = new System.Drawing.Point(291, 527);
            this.txtEncryptPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEncryptPath.Name = "txtEncryptPath";
            this.txtEncryptPath.Size = new System.Drawing.Size(193, 22);
            this.txtEncryptPath.TabIndex = 18;
            // 
            // txtDecryptPath
            // 
            this.txtDecryptPath.Location = new System.Drawing.Point(556, 527);
            this.txtDecryptPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecryptPath.Name = "txtDecryptPath";
            this.txtDecryptPath.Size = new System.Drawing.Size(193, 22);
            this.txtDecryptPath.TabIndex = 19;
            // 
            // btnViewEncrypted
            // 
            this.btnViewEncrypted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEncrypted.Location = new System.Drawing.Point(291, 470);
            this.btnViewEncrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewEncrypted.Name = "btnViewEncrypted";
            this.btnViewEncrypted.Size = new System.Drawing.Size(195, 50);
            this.btnViewEncrypted.TabIndex = 20;
            this.btnViewEncrypted.Text = "Save Encrypted Content";
            this.btnViewEncrypted.UseVisualStyleBackColor = false;
            this.btnViewEncrypted.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnViewDecrypted
            // 
            this.btnViewDecrypted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDecrypted.Location = new System.Drawing.Point(556, 470);
            this.btnViewDecrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDecrypted.Name = "btnViewDecrypted";
            this.btnViewDecrypted.Size = new System.Drawing.Size(195, 50);
            this.btnViewDecrypted.TabIndex = 21;
            this.btnViewDecrypted.Text = "Save Decrypted Content";
            this.btnViewDecrypted.UseVisualStyleBackColor = false;
            this.btnViewDecrypted.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.ForeColor = System.Drawing.Color.Lime;
            this.lblHeading1.Location = new System.Drawing.Point(184, 11);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(540, 32);
            this.lblHeading1.TabIndex = 22;
            this.lblHeading1.Text = "ENCRYPT DIRECTLY TO DIRECTORY";
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading2.ForeColor = System.Drawing.Color.Lime;
            this.lblHeading2.Location = new System.Drawing.Point(261, 375);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(288, 29);
            this.lblHeading2.TabIndex = 23;
            this.lblHeading2.Text = "VIEW FILE CONTENTS";
            // 
            // btnBrowseContent
            // 
            this.btnBrowseContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBrowseContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseContent.Location = new System.Drawing.Point(24, 470);
            this.btnBrowseContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseContent.Name = "btnBrowseContent";
            this.btnBrowseContent.Size = new System.Drawing.Size(195, 50);
            this.btnBrowseContent.TabIndex = 24;
            this.btnBrowseContent.Text = "Browse for file to encrypt";
            this.btnBrowseContent.UseVisualStyleBackColor = false;
            this.btnBrowseContent.Click += new System.EventHandler(this.btnBrowseContent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(734, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 46);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 768);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBrowseContent);
            this.Controls.Add(this.lblHeading2);
            this.Controls.Add(this.lblHeading1);
            this.Controls.Add(this.btnViewDecrypted);
            this.Controls.Add(this.btnViewEncrypted);
            this.Controls.Add(this.txtDecryptPath);
            this.Controls.Add(this.txtEncryptPath);
            this.Controls.Add(this.txtPlainPath);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnDecrypt);
            this.Controls.Add(this.rbtnEncrypt);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "File Encrypt & Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTipBrowse;
        private System.Windows.Forms.ToolTip toolTipEncrypt;
        private System.Windows.Forms.ToolTip toolTipDecrypt;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.ToolTip toolTipStart;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPlainPath;
        private System.Windows.Forms.TextBox txtEncryptPath;
        private System.Windows.Forms.TextBox txtDecryptPath;
        private System.Windows.Forms.Button btnViewEncrypted;
        private System.Windows.Forms.Button btnViewDecrypted;
        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Button btnBrowseContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipViewEncrypted;
    }
}

