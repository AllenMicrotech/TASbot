namespace TasBot_Software
{
    partial class StartupForm
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerStartup = new System.Windows.Forms.Timer(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.panelFirstLaunch = new System.Windows.Forms.Panel();
            this.buttonConfigSkip = new System.Windows.Forms.Button();
            this.buttonConfigYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFirstLaunch = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFirstLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(249, 70);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(44, 20);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "0.1b";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelLoading.Location = new System.Drawing.Point(9, 107);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(82, 20);
            this.labelLoading.TabIndex = 2;
            this.labelLoading.Text = "Loading....";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 4);
            this.panel1.TabIndex = 3;
            // 
            // timerStartup
            // 
            this.timerStartup.Tick += new System.EventHandler(this.timerStartup_Tick);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelX.Location = new System.Drawing.Point(284, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // panelFirstLaunch
            // 
            this.panelFirstLaunch.Controls.Add(this.buttonConfigSkip);
            this.panelFirstLaunch.Controls.Add(this.buttonConfigYes);
            this.panelFirstLaunch.Controls.Add(this.label2);
            this.panelFirstLaunch.Controls.Add(this.labelFirstLaunch);
            this.panelFirstLaunch.Location = new System.Drawing.Point(4, 152);
            this.panelFirstLaunch.Name = "panelFirstLaunch";
            this.panelFirstLaunch.Size = new System.Drawing.Size(287, 116);
            this.panelFirstLaunch.TabIndex = 6;
            this.panelFirstLaunch.Visible = false;
            // 
            // buttonConfigSkip
            // 
            this.buttonConfigSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConfigSkip.Location = new System.Drawing.Point(153, 81);
            this.buttonConfigSkip.Name = "buttonConfigSkip";
            this.buttonConfigSkip.Size = new System.Drawing.Size(125, 23);
            this.buttonConfigSkip.TabIndex = 3;
            this.buttonConfigSkip.Text = "Skip";
            this.buttonConfigSkip.UseVisualStyleBackColor = true;
            this.buttonConfigSkip.Click += new System.EventHandler(this.buttonConfigSkip_Click);
            // 
            // buttonConfigYes
            // 
            this.buttonConfigYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConfigYes.Location = new System.Drawing.Point(9, 81);
            this.buttonConfigYes.Name = "buttonConfigYes";
            this.buttonConfigYes.Size = new System.Drawing.Size(125, 23);
            this.buttonConfigYes.TabIndex = 2;
            this.buttonConfigYes.Text = "Yes";
            this.buttonConfigYes.UseVisualStyleBackColor = true;
            this.buttonConfigYes.Click += new System.EventHandler(this.buttonConfigYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Run Configuration Wizard?";
            // 
            // labelFirstLaunch
            // 
            this.labelFirstLaunch.AutoSize = true;
            this.labelFirstLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelFirstLaunch.Location = new System.Drawing.Point(4, 4);
            this.labelFirstLaunch.Name = "labelFirstLaunch";
            this.labelFirstLaunch.Size = new System.Drawing.Size(275, 40);
            this.labelFirstLaunch.TabIndex = 0;
            this.labelFirstLaunch.Text = "It looks like this is your first time using \r\nthe TASbot Software.";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(293, 8);
            this.panelTop.TabIndex = 7;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TasBot_Software.Properties.Resources.TasbotLogo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(297, 278);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFirstLaunch);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartupForm";
            this.Opacity = 0.1D;
            this.Text = "StartupForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.panelFirstLaunch.ResumeLayout(false);
            this.panelFirstLaunch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelVersion;
        public System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerStartup;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panelFirstLaunch;
        private System.Windows.Forms.Label labelFirstLaunch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonConfigSkip;
        private System.Windows.Forms.Button buttonConfigYes;
    }
}