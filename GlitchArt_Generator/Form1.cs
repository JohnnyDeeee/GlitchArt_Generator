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

        // TODO: Create a stop button

        public Form1()
        {
            InitializeComponent();

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
                newImage = RandomizePixelColors((Bitmap)image);

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
            newImage = TijmenGlitch.ApplyNoise((Bitmap)picture_original.Image);

            // Show new image in picturebox
            picture_new.Image = newImage;

            PostStart();
        }

        // Randomize pixel colors
        // TODO: Optimize (clusters are hogging the application around +40 chance)
        // TODO: Let this run on a different thread
        private Bitmap RandomizePixelColors(Bitmap oldImage)
        {
            Random rand = new Random();
            int randomizeChance = (int)numeric_randomPixelChance.Value;
            int clusterChance = (int)numeric_clusterChance.Value;
            int currentStep = 0;
            int nextStep = (oldImage.Width * oldImage.Height) / 100;
            Bitmap finalImage = new Bitmap(oldImage.Width, oldImage.Height);
            List<KeyValuePair<Color, List<KeyValuePair<int, int>>>> clusters = new List<KeyValuePair<Color, List<KeyValuePair<int, int>>>>();
            for (int x = 0; x < oldImage.Width; x++)
            {
                for (int y = 0; y < oldImage.Height; y++)
                {
                    Color pixelColor = oldImage.GetPixel(x, y);
                    Color newColor = pixelColor;

                    // Create a random colored pixel
                    if (rand.Next(0, 101) < randomizeChance &&
                        clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Equals(new KeyValuePair<Color, List<KeyValuePair<int,int>>>()))
                    {
                        newColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));

                        // Check cluster chance
                        if (rand.Next(0, 101) < clusterChance)
                        {
                            // Create cluster
                            Color clusterColor = newColor;
                            int clusterSize = (int)numeric_clusterSize.Value;

                            // Randomize cluster size
                            if (check_randomClustersize.Checked)
                                clusterSize = rand.Next((int)numeric_randClustersize_min.Value, (int)numeric_randClustersize_max.Value);

                            // 'Mark' pixels as cluster pixels
                            List<KeyValuePair<int, int>> clusterPixels = new List<KeyValuePair<int, int>>();
                            for (int _x = x; _x < (x + clusterSize); _x++)
                            {
                                for (int _y = y; _y < (y + clusterSize); _y++)
                                {
                                    clusterPixels.Add(new KeyValuePair<int, int>(_x, _y));
                                }
                            }

                            clusters.Add(new KeyValuePair<Color, List<KeyValuePair<int, int>>>(clusterColor, clusterPixels));
                        }
                    }
                    else if (!clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Equals(new KeyValuePair<Color, List<KeyValuePair<int,int>>>()))
                        newColor = clusters.Find(_x => _x.Value.Contains(new KeyValuePair<int, int>(x, y))).Key;
                    else
                        newColor = oldImage.GetPixel(x, y);

                    // Save the new pixel to the new bitmap
                    finalImage.SetPixel(x, y, newColor);

                    currentStep++;

                    // Increment progressbar on every nextStep
                    if (currentStep % nextStep == 0)
                        progressBar.Increment(1);
                }
            }

            return finalImage;
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
