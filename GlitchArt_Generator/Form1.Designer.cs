namespace GlitchArt_Generator
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
            this.button_browse = new System.Windows.Forms.Button();
            this.picture_original = new System.Windows.Forms.PictureBox();
            this.picture_new = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_randomPixelChance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_clusterChance = new System.Windows.Forms.NumericUpDown();
            this.label_randClustersize_max = new System.Windows.Forms.Label();
            this.numeric_randClustersize_max = new System.Windows.Forms.NumericUpDown();
            this.label_randClustersize_min = new System.Windows.Forms.Label();
            this.numeric_randClustersize_min = new System.Windows.Forms.NumericUpDown();
            this.check_randomClustersize = new System.Windows.Forms.CheckBox();
            this.label_clustersize = new System.Windows.Forms.Label();
            this.numeric_clusterSize = new System.Windows.Forms.NumericUpDown();
            this.button_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_new)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randomPixelChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clusterChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randClustersize_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randClustersize_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clusterSize)).BeginInit();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(25, 184);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // picture_original
            // 
            this.picture_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_original.Location = new System.Drawing.Point(25, 213);
            this.picture_original.Name = "picture_original";
            this.picture_original.Size = new System.Drawing.Size(439, 455);
            this.picture_original.TabIndex = 1;
            this.picture_original.TabStop = false;
            // 
            // picture_new
            // 
            this.picture_new.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_new.Location = new System.Drawing.Point(633, 213);
            this.picture_new.Name = "picture_new";
            this.picture_new.Size = new System.Drawing.Size(439, 455);
            this.picture_new.TabIndex = 2;
            this.picture_new.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(25, 674);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1047, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(633, 184);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numeric_randomPixelChance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numeric_clusterChance);
            this.groupBox1.Controls.Add(this.label_randClustersize_max);
            this.groupBox1.Controls.Add(this.numeric_randClustersize_max);
            this.groupBox1.Controls.Add(this.label_randClustersize_min);
            this.groupBox1.Controls.Add(this.numeric_randClustersize_min);
            this.groupBox1.Controls.Add(this.check_randomClustersize);
            this.groupBox1.Controls.Add(this.label_clustersize);
            this.groupBox1.Controls.Add(this.numeric_clusterSize);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 104);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Random pixel chance: ";
            // 
            // numeric_randomPixelChance
            // 
            this.numeric_randomPixelChance.Location = new System.Drawing.Point(128, 20);
            this.numeric_randomPixelChance.Name = "numeric_randomPixelChance";
            this.numeric_randomPixelChance.Size = new System.Drawing.Size(62, 20);
            this.numeric_randomPixelChance.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cluster chance:";
            // 
            // numeric_clusterChance
            // 
            this.numeric_clusterChance.Location = new System.Drawing.Point(371, 20);
            this.numeric_clusterChance.Name = "numeric_clusterChance";
            this.numeric_clusterChance.Size = new System.Drawing.Size(62, 20);
            this.numeric_clusterChance.TabIndex = 7;
            // 
            // label_randClustersize_max
            // 
            this.label_randClustersize_max.AutoSize = true;
            this.label_randClustersize_max.Enabled = false;
            this.label_randClustersize_max.Location = new System.Drawing.Point(389, 97);
            this.label_randClustersize_max.Name = "label_randClustersize_max";
            this.label_randClustersize_max.Size = new System.Drawing.Size(30, 13);
            this.label_randClustersize_max.TabIndex = 6;
            this.label_randClustersize_max.Text = "Max:";
            // 
            // numeric_randClustersize_max
            // 
            this.numeric_randClustersize_max.Enabled = false;
            this.numeric_randClustersize_max.Location = new System.Drawing.Point(422, 95);
            this.numeric_randClustersize_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_randClustersize_max.Name = "numeric_randClustersize_max";
            this.numeric_randClustersize_max.Size = new System.Drawing.Size(62, 20);
            this.numeric_randClustersize_max.TabIndex = 5;
            // 
            // label_randClustersize_min
            // 
            this.label_randClustersize_min.AutoSize = true;
            this.label_randClustersize_min.Enabled = false;
            this.label_randClustersize_min.Location = new System.Drawing.Point(284, 97);
            this.label_randClustersize_min.Name = "label_randClustersize_min";
            this.label_randClustersize_min.Size = new System.Drawing.Size(27, 13);
            this.label_randClustersize_min.TabIndex = 4;
            this.label_randClustersize_min.Text = "Min:";
            // 
            // numeric_randClustersize_min
            // 
            this.numeric_randClustersize_min.Enabled = false;
            this.numeric_randClustersize_min.Location = new System.Drawing.Point(317, 95);
            this.numeric_randClustersize_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_randClustersize_min.Name = "numeric_randClustersize_min";
            this.numeric_randClustersize_min.Size = new System.Drawing.Size(62, 20);
            this.numeric_randClustersize_min.TabIndex = 3;
            // 
            // check_randomClustersize
            // 
            this.check_randomClustersize.AutoSize = true;
            this.check_randomClustersize.Location = new System.Drawing.Point(284, 72);
            this.check_randomClustersize.Name = "check_randomClustersize";
            this.check_randomClustersize.Size = new System.Drawing.Size(121, 17);
            this.check_randomClustersize.TabIndex = 2;
            this.check_randomClustersize.Text = "Random cluster size";
            this.check_randomClustersize.UseVisualStyleBackColor = true;
            this.check_randomClustersize.CheckedChanged += new System.EventHandler(this.check_randomClustersize_CheckedChanged);
            // 
            // label_clustersize
            // 
            this.label_clustersize.AutoSize = true;
            this.label_clustersize.Location = new System.Drawing.Point(284, 48);
            this.label_clustersize.Name = "label_clustersize";
            this.label_clustersize.Size = new System.Drawing.Size(63, 13);
            this.label_clustersize.TabIndex = 1;
            this.label_clustersize.Text = "Cluster size:";
            // 
            // numeric_clusterSize
            // 
            this.numeric_clusterSize.Location = new System.Drawing.Point(371, 46);
            this.numeric_clusterSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_clusterSize.Name = "numeric_clusterSize";
            this.numeric_clusterSize.Size = new System.Drawing.Size(62, 20);
            this.numeric_clusterSize.TabIndex = 0;
            // 
            // button_restart
            // 
            this.button_restart.Enabled = false;
            this.button_restart.Location = new System.Drawing.Point(106, 184);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 7;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 709);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.picture_new);
            this.Controls.Add(this.picture_original);
            this.Controls.Add(this.button_browse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Glitch-Art Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picture_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_new)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randomPixelChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clusterChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randClustersize_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_randClustersize_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clusterSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.PictureBox picture_original;
        private System.Windows.Forms.PictureBox picture_new;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_clustersize;
        private System.Windows.Forms.NumericUpDown numeric_clusterSize;
        private System.Windows.Forms.Label label_randClustersize_max;
        private System.Windows.Forms.NumericUpDown numeric_randClustersize_max;
        private System.Windows.Forms.Label label_randClustersize_min;
        private System.Windows.Forms.NumericUpDown numeric_randClustersize_min;
        private System.Windows.Forms.CheckBox check_randomClustersize;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_clusterChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_randomPixelChance;
        private System.Windows.Forms.Label label3;
    }
}

