using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Scanning_Project
{
    public partial class mainForm : Form
    {
        List<Image> images = new List<Image>();

        private int currentImage = -1;

        public int CurrentImage
        {
            get { return currentImage; }
            set
            {
                currentImage = value;

                btnLastImage.Enabled = currentImage != 0;

                btnNextImage.Enabled = currentImage != images.Count - 1;
            }
        }


        public mainForm()
        {
            InitializeComponent();
        }

        private void addItemInList(System.Drawing.Image image)
        {
            images.Add(image);
            if (images.Count > 1)
            {
                btnLastImage.Enabled = true;
            }
            pbScannedFile.Image = image;
            CurrentImage++;
        }
        private async void ScannerSystemMainScreen_Load(object sender, EventArgs e)
        {
            await LoadDevices();
            tbSaveFolder.Text = Properties.Settings.Default.LocationPath;

        }
        private async void lkLoadDevices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadDevices();
        }


        private async Task LoadDevices()
        {
            pbLoading.Visible = true;
            cbScanners.DataSource = await ScannerHelper.GetAllScanners();
            pbLoading.Visible = false;
        }

        private void lkOpenSaveFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(tbSaveFolder.Text))
                Process.Start(tbSaveFolder.Text);
        }

        private void lkChangeSaveFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.Description = "Wählen Sie den Speicherordner";


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LocationPath = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                tbSaveFolder.Text = Properties.Settings.Default.LocationPath;
            }
        }

        private async void takeImage()
        {
            pbLoading.Show();

            if (!string.IsNullOrEmpty(cbScanners.SelectedItem.ToString()))
            {
                Image newImage = await ScannerHelper.ScanAsImageAsycn(cbScanners.SelectedItem.ToString());


                addItemInList(newImage);

            }
            else
            {
                MessageBox.Show("Das ausgewählte Gerät existiert nicht", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pbLoading.Hide();

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            takeImage();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastImage_Click(object sender, EventArgs e)
        {
            CurrentImage--;
            if (CurrentImage < 0)
                return;

            pbScannedFile.Image = images[CurrentImage];
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbSaveFolder.Text + ".pdf";
            ScannerHelper.SaveImagesAsPdf(images, outputFilePath);
        }
        private async void mainForm_Load(object sender, EventArgs e)
        {
            await LoadDevices();

            if(String.IsNullOrEmpty(Properties.Settings.Default.LocationPath))
                Properties.Settings.Default.LocationPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            tbSaveFolder.Text = Properties.Settings.Default.LocationPath;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (images == null || images.Count == 0)
            {
                MessageBox.Show("Es gibt kein Dokument!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(tbSaveFolder.Text))
            {
                MessageBox.Show("Bitte wählen Sie einen Speicherort!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputFilePath = Path.Combine(tbSaveFolder.Text, Guid.NewGuid().ToString() + ".pdf");
            if (!ScannerHelper.SaveImagesAsPdf(images, outputFilePath))
            {
                MessageBox.Show("Etwas ist schiefgelaufen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(outputFilePath); // Open the saved PDF
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentImage--;
            if (CurrentImage < 0)
                return;

            pbScannedFile.Image = images[CurrentImage];
        }

        private void btnNextImage_Click_1(object sender, EventArgs e)
        {
            CurrentImage++;
            if (CurrentImage > images.Count)
                return;

            pbScannedFile.Image = images[CurrentImage];
        }
    }
}
