using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlitchArt_Generator
{
    public partial class Form1 : Form
    {
        public OpenFileDialog fileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private Bitmap newImage;

        // TODO: Create a stop button

        public Form1()
        {
            InitializeComponent();

            // Initialize Glitch class
            Glitch.main = this;

            // Initialize fileDialog
            // TODO: Change filters in something right
            //fileDialog.Filter = "Image|*.bmp"; // Only allow bmp files
            fileDialog.Multiselect = false;
            fileDialog.Title = "Select an image file";

            // Initialize saveFileDialog
            // TODO: Change filters in something right
            saveFileDialog.Filter = "Image|*.bmp";
            saveFileDialog.Title = "Choose a save location for the image";

            // Initialize pictureboxes
            picture_original.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_new.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Browse button
        private void button_browse_Click(object sender, EventArgs e)
        {
            // Show file dialog
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set saveFileDialog initial directory to selected directory
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(fileDialog.FileName);
                saveFileDialog.FileName = Path.GetFileName(fileDialog.FileName);
                textbox_selectedFile.Text = Path.GetFileName(fileDialog.FileName);

                // Show selected image in picturebox
                Image image = Image.FromFile(fileDialog.FileName);
                picture_original.Image = image;

                // Enable start button
                button_start.Enabled = true;
            }
            else
            {
                // Disable start button
                button_start.Enabled = false;
            }
        }

        // Save button
        private void button_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                newImage.Save(saveFileDialog.FileName);
        }

        // Random cluster size checkbox
        private void check_randomClustersize_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            // Enable/Disable necessary controls
            RPC_label_randClustersize_max.Enabled = check.Checked;
            RPC_label_randClustersize_min.Enabled = check.Checked;
            RPC_numeric_randClustersize_max.Enabled = check.Checked;
            RPC_numeric_randClustersize_min.Enabled = check.Checked;

            if (check.Checked)
            {
                RPC_label_clustersize.Enabled = false;
                RPC_numeric_clusterSize.Enabled = false;
            }
            else
            {
                RPC_label_clustersize.Enabled = true;
                RPC_numeric_clusterSize.Enabled = true;
            }
        }

        // Start button
        private void button_start_Click(object sender, EventArgs e)
        {
            PreStart();

            StartSelectedGlitchMethod();

            PostStart();
        }

        // Setup interface stuff before starting randomizing proces
        private void PreStart()
        {
            // Disable browse button
            button_browse.Enabled = false;

            // Disable start button
            button_start.Enabled = false;

            // Reset progressbar
            progressBar.Value = 0;

            // Disable save button
            button_save.Enabled = false;
        }

        // Setup interface stuff after starting randomizing proces
        private void PostStart()
        {
            button_start.Enabled = true;
            button_save.Enabled = true;

            // Enable browse button
            button_browse.Enabled = true;
        }

        // Call function that is part of selected settings tab
        private void StartSelectedGlitchMethod()
        {
            // Call function that is supplied by the 'tag' attribute of the selected tab
            string method = tabcontrol_glitchMethods.SelectedTab.Tag.ToString();
            MethodInfo actualMethod = (typeof(Glitch)).GetMethod(method);
            actualMethod.Invoke(this, null);
        }
    }
}
