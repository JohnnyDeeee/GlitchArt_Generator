using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlitchArt_Generator
{
    public partial class Form1 : Form
    {
        private OpenFileDialog fileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private Bitmap newImage;
        public ProgressBar progress;

        // TODO: Create a stop button

        public Form1()
        {
            InitializeComponent();

            // Initialize Glitch class
            Glitch.main = this;
            this.progress = progressBar;

            // Initialize fileDialog
            fileDialog.Filter = "Image|*.bmp"; // Only allow bmp files
            fileDialog.Multiselect = false;
            fileDialog.Title = "Select an image file";

            // Initialize saveFileDialog
            saveFileDialog.Filter = "Image|*.bmp";
            saveFileDialog.Title = "Choose a save location for the image";

            // Initialize pictureboxes
            picture_original.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_new.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Browse button
        private void button_browse_Click(object sender, EventArgs e)
        {
            PreStart();

            // Show file dialog
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set saveFileDialog initial directory to selected directory
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(fileDialog.FileName);
                saveFileDialog.FileName = Path.GetFileName(fileDialog.FileName);

                // Show selected image in picturebox
                Image image = Image.FromFile(fileDialog.FileName);
                picture_original.Image = image;

                // Randomize pixels
      //          if(check_randomClustersize.Checked)
      //              newImage = Glitch.RandomizePixelColors((Bitmap)image, (int)numeric_randomPixelChance.Value, (int)numeric_clusterChance.Value, (int)numeric_clusterSize.Value, check_randomClustersize.Checked, (int)numeric_randClustersize_min.Value, (int)numeric_randClustersize_max.Value);
      //          else
     //               newImage = Glitch.RandomizePixelColors((Bitmap)image, (int)numeric_randomPixelChance.Value, (int)numeric_clusterChance.Value, (int)numeric_clusterSize.Value);

                newImage = ArtMaker.Tear((Bitmap)picture_original.Image);

                // Show new image in picturebox
                picture_new.Image = newImage;

                PostStart();
            }

            PostStart(false);
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
            label_randClustersize_max.Enabled = check.Checked;
            label_randClustersize_min.Enabled = check.Checked;
            numeric_randClustersize_max.Enabled = check.Checked;
            numeric_randClustersize_min.Enabled = check.Checked;

            if (check.Checked)
            {
                label_clustersize.Enabled = false;
                numeric_clusterSize.Enabled = false;
            }
            else
            {
                label_clustersize.Enabled = true;
                numeric_clusterSize.Enabled = true;
            }
        }

        // Restart button
        private void button_restart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Disable button
            button.Enabled = false;

            PreStart();

            // Randomize pixels
     //       if(check_randomClustersize.Checked)
     //           newImage = Glitch.RandomizePixelColors((Bitmap)picture_original.Image, (int)numeric_randomPixelChance.Value, (int)numeric_clusterChance.Value, (int)numeric_clusterSize.Value, check_randomClustersize.Checked, (int)numeric_randClustersize_min.Value, (int)numeric_randClustersize_max.Value);
   //         else
    //            newImage = Glitch.RandomizePixelColors((Bitmap)picture_original.Image, (int)numeric_randomPixelChance.Value, (int)numeric_clusterChance.Value, (int)numeric_clusterSize.Value);

            newImage = ArtMaker.Tear((Bitmap)picture_original.Image);
            // Show new image in picturebox
            picture_new.Image = newImage;

            PostStart();
        }

        // Setup interface stuff before starting randomizing proces
        private void PreStart()
        {
            // Disable browse button
            button_browse.Enabled = false;

            // Disable restart button
            button_restart.Enabled = false;

            // Reset progressbar
            progressBar.Value = 0;

            // Disable save button
            button_save.Enabled = false;
        }

        // Setup interface stuff after starting randomizing proces
        private void PostStart(bool choseFile = true)
        {
            if (choseFile)
            {
                button_restart.Enabled = true;
                button_save.Enabled = true;
            }

            // Enable browse button
            button_browse.Enabled = true;
        }
    }
}
