namespace Scanning_Project
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanal = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkChangeSaveFile = new System.Windows.Forms.LinkLabel();
            this.lkOpenSaveFile = new System.Windows.Forms.LinkLabel();
            this.tbSaveFolder = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.cbScanners = new System.Windows.Forms.ComboBox();
            this.lkLoadDevices = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbScannedFile = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLastImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.mainPanal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScannedFile)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanal
            // 
            this.mainPanal.Controls.Add(this.groupBox1);
            this.mainPanal.Controls.Add(this.btnScan);
            this.mainPanal.Controls.Add(this.cbScanners);
            this.mainPanal.Controls.Add(this.lkLoadDevices);
            this.mainPanal.Controls.Add(this.label1);
            this.mainPanal.Controls.Add(this.pictureBox1);
            this.mainPanal.Controls.Add(this.lbLogo);
            this.mainPanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanal.Location = new System.Drawing.Point(0, 0);
            this.mainPanal.Name = "mainPanal";
            this.mainPanal.Padding = new System.Windows.Forms.Padding(10);
            this.mainPanal.Size = new System.Drawing.Size(200, 461);
            this.mainPanal.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkChangeSaveFile);
            this.groupBox1.Controls.Add(this.lkOpenSaveFile);
            this.groupBox1.Controls.Add(this.tbSaveFolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(180, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speicherort";
            // 
            // lkChangeSaveFile
            // 
            this.lkChangeSaveFile.AutoSize = true;
            this.lkChangeSaveFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lkChangeSaveFile.Location = new System.Drawing.Point(112, 64);
            this.lkChangeSaveFile.Name = "lkChangeSaveFile";
            this.lkChangeSaveFile.Size = new System.Drawing.Size(60, 19);
            this.lkChangeSaveFile.TabIndex = 2;
            this.lkChangeSaveFile.TabStop = true;
            this.lkChangeSaveFile.Text = "Ändern";
            this.lkChangeSaveFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkChangeSaveFile_LinkClicked);
            // 
            // lkOpenSaveFile
            // 
            this.lkOpenSaveFile.AutoSize = true;
            this.lkOpenSaveFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lkOpenSaveFile.Location = new System.Drawing.Point(8, 64);
            this.lkOpenSaveFile.Name = "lkOpenSaveFile";
            this.lkOpenSaveFile.Size = new System.Drawing.Size(56, 19);
            this.lkOpenSaveFile.TabIndex = 1;
            this.lkOpenSaveFile.TabStop = true;
            this.lkOpenSaveFile.Text = "Öffnen";
            this.lkOpenSaveFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkOpenSaveFile_LinkClicked);
            // 
            // tbSaveFolder
            // 
            this.tbSaveFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSaveFolder.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbSaveFolder.Location = new System.Drawing.Point(8, 34);
            this.tbSaveFolder.Name = "tbSaveFolder";
            this.tbSaveFolder.ReadOnly = true;
            this.tbSaveFolder.Size = new System.Drawing.Size(164, 27);
            this.tbSaveFolder.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnScan.Location = new System.Drawing.Point(10, 411);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(180, 40);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scannen";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cbScanners
            // 
            this.cbScanners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScanners.FormattingEnabled = true;
            this.cbScanners.Location = new System.Drawing.Point(7, 171);
            this.cbScanners.Name = "cbScanners";
            this.cbScanners.Size = new System.Drawing.Size(187, 21);
            this.cbScanners.TabIndex = 4;
            // 
            // lkLoadDevices
            // 
            this.lkLoadDevices.AutoSize = true;
            this.lkLoadDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoadDevices.Location = new System.Drawing.Point(110, 143);
            this.lkLoadDevices.Name = "lkLoadDevices";
            this.lkLoadDevices.Size = new System.Drawing.Size(84, 16);
            this.lkLoadDevices.TabIndex = 3;
            this.lkLoadDevices.TabStop = true;
            this.lkLoadDevices.Text = "Aktualisieren";
            this.lkLoadDevices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLoadDevices_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerät:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Scanning_Project.Properties.Resources.logoImage;
            this.pictureBox1.Location = new System.Drawing.Point(100, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbLogo
            // 
            this.lbLogo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbLogo.Location = new System.Drawing.Point(3, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(91, 72);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Scanning Project";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Image = global::Scanning_Project.Properties.Resources.loading_7528_512;
            this.pbLoading.Location = new System.Drawing.Point(417, 155);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(150, 150);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 2;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pbScannedFile
            // 
            this.pbScannedFile.BackColor = System.Drawing.Color.White;
            this.pbScannedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbScannedFile.Location = new System.Drawing.Point(200, 0);
            this.pbScannedFile.Name = "pbScannedFile";
            this.pbScannedFile.Size = new System.Drawing.Size(584, 461);
            this.pbScannedFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScannedFile.TabIndex = 1;
            this.pbScannedFile.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::Scanning_Project.Properties.Resources.diskette;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(732, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLastImage
            // 
            this.btnLastImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastImage.BackgroundImage = global::Scanning_Project.Properties.Resources.arrow_left;
            this.btnLastImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastImage.Enabled = false;
            this.btnLastImage.Location = new System.Drawing.Point(206, 205);
            this.btnLastImage.Name = "btnLastImage";
            this.btnLastImage.Size = new System.Drawing.Size(50, 50);
            this.btnLastImage.TabIndex = 7;
            this.btnLastImage.UseVisualStyleBackColor = true;
            this.btnLastImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.BackgroundImage = global::Scanning_Project.Properties.Resources.arrow_right;
            this.btnNextImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextImage.Enabled = false;
            this.btnNextImage.Location = new System.Drawing.Point(722, 205);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(50, 50);
            this.btnNextImage.TabIndex = 8;
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnLastImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbScannedFile);
            this.Controls.Add(this.mainPanal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "mainForm";
            this.Text = "Scanning Project";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainPanal.ResumeLayout(false);
            this.mainPanal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScannedFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.ComboBox cbScanners;
        private System.Windows.Forms.LinkLabel lkLoadDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pbScannedFile;
        private System.Windows.Forms.TextBox tbSaveFolder;
        private System.Windows.Forms.LinkLabel lkChangeSaveFile;
        private System.Windows.Forms.LinkLabel lkOpenSaveFile;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLastImage;
        private System.Windows.Forms.Button btnNextImage;
    }
}

