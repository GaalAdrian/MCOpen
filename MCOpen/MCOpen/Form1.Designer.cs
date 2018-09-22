namespace MCOpen
{
    partial class MCOPENLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCOPENLauncher));
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.launcherText = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.btnServerO = new System.Windows.Forms.Button();
            this.serverBtnT = new System.Windows.Forms.Button();
            this.serverBtnTT = new System.Windows.Forms.Button();
            this.serverO = new System.Windows.Forms.Label();
            this.serverS = new System.Windows.Forms.Label();
            this.serverT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.White;
            this.txtBoxUsername.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsername.Location = new System.Drawing.Point(12, 207);
            this.txtBoxUsername.MaxLength = 16;
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(240, 25);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(6, 167);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(248, 36);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "FELHASZNÁLÓNÉV";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(9, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(243, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "BEJELENTKEZÉS";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(12, 411);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(78, 23);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "InfoText";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // launcherText
            // 
            this.launcherText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launcherText.AutoSize = true;
            this.launcherText.BackColor = System.Drawing.Color.Transparent;
            this.launcherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launcherText.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.launcherText.ForeColor = System.Drawing.Color.White;
            this.launcherText.Location = new System.Drawing.Point(12, 84);
            this.launcherText.Name = "launcherText";
            this.launcherText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.launcherText.Size = new System.Drawing.Size(164, 33);
            this.launcherText.TabIndex = 8;
            this.launcherText.Text = "launcherText";
            this.launcherText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.BackColor = System.Drawing.Color.Transparent;
            this.versionText.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(8, 518);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(105, 23);
            this.versionText.TabIndex = 14;
            this.versionText.Text = "versionText";
            this.versionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnServerO
            // 
            this.btnServerO.BackColor = System.Drawing.Color.Transparent;
            this.btnServerO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnServerO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnServerO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnServerO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerO.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnServerO.ForeColor = System.Drawing.Color.White;
            this.btnServerO.Location = new System.Drawing.Point(304, 469);
            this.btnServerO.Name = "btnServerO";
            this.btnServerO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServerO.Size = new System.Drawing.Size(178, 50);
            this.btnServerO.TabIndex = 15;
            this.btnServerO.Text = "PLAY";
            this.btnServerO.UseVisualStyleBackColor = false;
            this.btnServerO.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // serverBtnT
            // 
            this.serverBtnT.BackColor = System.Drawing.Color.Transparent;
            this.serverBtnT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.serverBtnT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.serverBtnT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.serverBtnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBtnT.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverBtnT.ForeColor = System.Drawing.Color.White;
            this.serverBtnT.Location = new System.Drawing.Point(540, 469);
            this.serverBtnT.Name = "serverBtnT";
            this.serverBtnT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverBtnT.Size = new System.Drawing.Size(178, 50);
            this.serverBtnT.TabIndex = 16;
            this.serverBtnT.Text = "PLAY";
            this.serverBtnT.UseVisualStyleBackColor = false;
            this.serverBtnT.Click += new System.EventHandler(this.serverBtnT_Click);
            // 
            // serverBtnTT
            // 
            this.serverBtnTT.BackColor = System.Drawing.Color.Transparent;
            this.serverBtnTT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.serverBtnTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.serverBtnTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.serverBtnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverBtnTT.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverBtnTT.ForeColor = System.Drawing.Color.White;
            this.serverBtnTT.Location = new System.Drawing.Point(770, 469);
            this.serverBtnTT.Name = "serverBtnTT";
            this.serverBtnTT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverBtnTT.Size = new System.Drawing.Size(178, 50);
            this.serverBtnTT.TabIndex = 17;
            this.serverBtnTT.Text = "PLAY";
            this.serverBtnTT.UseVisualStyleBackColor = false;
            this.serverBtnTT.Click += new System.EventHandler(this.serverBtnTT_Click);
            // 
            // serverO
            // 
            this.serverO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverO.AutoSize = true;
            this.serverO.BackColor = System.Drawing.Color.Transparent;
            this.serverO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverO.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverO.ForeColor = System.Drawing.Color.White;
            this.serverO.Location = new System.Drawing.Point(312, 269);
            this.serverO.Name = "serverO";
            this.serverO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverO.Size = new System.Drawing.Size(106, 33);
            this.serverO.TabIndex = 18;
            this.serverO.Text = "serverO";
            this.serverO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverS
            // 
            this.serverS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverS.AutoSize = true;
            this.serverS.BackColor = System.Drawing.Color.Transparent;
            this.serverS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverS.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverS.ForeColor = System.Drawing.Color.White;
            this.serverS.Location = new System.Drawing.Point(546, 269);
            this.serverS.Name = "serverS";
            this.serverS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverS.Size = new System.Drawing.Size(101, 33);
            this.serverS.TabIndex = 19;
            this.serverS.Text = "serverS";
            this.serverS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverT
            // 
            this.serverT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverT.AutoSize = true;
            this.serverT.BackColor = System.Drawing.Color.Transparent;
            this.serverT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverT.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverT.ForeColor = System.Drawing.Color.White;
            this.serverT.Location = new System.Drawing.Point(773, 271);
            this.serverT.Name = "serverT";
            this.serverT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverT.Size = new System.Drawing.Size(101, 33);
            this.serverT.TabIndex = 20;
            this.serverT.Text = "serverT";
            this.serverT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MCOPENLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.serverT);
            this.Controls.Add(this.serverS);
            this.Controls.Add(this.serverO);
            this.Controls.Add(this.serverBtnTT);
            this.Controls.Add(this.serverBtnT);
            this.Controls.Add(this.btnServerO);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.launcherText);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MCOPENLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCOPEN - 0.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label launcherText;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Button btnServerO;
        private System.Windows.Forms.Button serverBtnT;
        private System.Windows.Forms.Button serverBtnTT;
        private System.Windows.Forms.Label serverO;
        private System.Windows.Forms.Label serverS;
        private System.Windows.Forms.Label serverT;
    }
}

