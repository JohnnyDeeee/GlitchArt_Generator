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
            this.RPC_label_author = new System.Windows.Forms.Label();
            this.RPC_label3 = new System.Windows.Forms.Label();
            this.RPC_label2 = new System.Windows.Forms.Label();
            this.RPC_numeric_randomPixelChance = new System.Windows.Forms.NumericUpDown();
            this.RPC_label1 = new System.Windows.Forms.Label();
            this.RPC_numeric_clusterChance = new System.Windows.Forms.NumericUpDown();
            this.RPC_label_randClustersize_max = new System.Windows.Forms.Label();
            this.RPC_numeric_randClustersize_max = new System.Windows.Forms.NumericUpDown();
            this.RPC_label_randClustersize_min = new System.Windows.Forms.Label();
            this.RPC_numeric_randClustersize_min = new System.Windows.Forms.NumericUpDown();
            this.RPC_check_randomClustersize = new System.Windows.Forms.CheckBox();
            this.RPC_label_clustersize = new System.Windows.Forms.Label();
            this.RPC_numeric_clusterSize = new System.Windows.Forms.NumericUpDown();
            this.tabcontrol_glitchMethods = new System.Windows.Forms.TabControl();
            this.tabl_randomizePixelColors = new System.Windows.Forms.TabPage();
            this.tabl_newRandomizePixelColors = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NRPC_label4 = new System.Windows.Forms.Label();
            this.tab_dragOutPixels = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DOP_label6 = new System.Windows.Forms.Label();
            this.tab_applyNoise = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AN_label_clusterSize = new System.Windows.Forms.Label();
            this.AN_numeric_clusterSize = new System.Windows.Forms.NumericUpDown();
            this.AN_label5 = new System.Windows.Forms.Label();
            this.tab_bitMosh = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BM_label7 = new System.Windows.Forms.Label();
            this.tab_tearing = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.T_label8 = new System.Windows.Forms.Label();
            this.textbox_selectedFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.AN_label_randomChange = new System.Windows.Forms.Label();
            this.AN_numeric_randomChange = new System.Windows.Forms.NumericUpDown();
            this.BM_label_randomChange = new System.Windows.Forms.Label();
            this.BM_numeric_randomChange = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picture_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_new)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randomPixelChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_clusterChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randClustersize_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randClustersize_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_clusterSize)).BeginInit();
            this.tabcontrol_glitchMethods.SuspendLayout();
            this.tabl_randomizePixelColors.SuspendLayout();
            this.tabl_newRandomizePixelColors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_dragOutPixels.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_applyNoise.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_numeric_clusterSize)).BeginInit();
            this.tab_bitMosh.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tab_tearing.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_numeric_randomChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM_numeric_randomChange)).BeginInit();
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
            this.progressBar.Location = new System.Drawing.Point(25, 677);
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
            this.groupBox1.Controls.Add(this.RPC_label_author);
            this.groupBox1.Controls.Add(this.RPC_label3);
            this.groupBox1.Controls.Add(this.RPC_label2);
            this.groupBox1.Controls.Add(this.RPC_numeric_randomPixelChance);
            this.groupBox1.Controls.Add(this.RPC_label1);
            this.groupBox1.Controls.Add(this.RPC_numeric_clusterChance);
            this.groupBox1.Controls.Add(this.RPC_label_randClustersize_max);
            this.groupBox1.Controls.Add(this.RPC_numeric_randClustersize_max);
            this.groupBox1.Controls.Add(this.RPC_label_randClustersize_min);
            this.groupBox1.Controls.Add(this.RPC_numeric_randClustersize_min);
            this.groupBox1.Controls.Add(this.RPC_check_randomClustersize);
            this.groupBox1.Controls.Add(this.RPC_label_clustersize);
            this.groupBox1.Controls.Add(this.RPC_numeric_clusterSize);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // RPC_label_author
            // 
            this.RPC_label_author.AutoSize = true;
            this.RPC_label_author.ForeColor = System.Drawing.Color.Blue;
            this.RPC_label_author.Location = new System.Drawing.Point(951, 118);
            this.RPC_label_author.Name = "RPC_label_author";
            this.RPC_label_author.Size = new System.Drawing.Size(79, 13);
            this.RPC_label_author.TabIndex = 10;
            this.RPC_label_author.Text = "Author: Gerben";
            // 
            // RPC_label3
            // 
            this.RPC_label3.AutoSize = true;
            this.RPC_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPC_label3.ForeColor = System.Drawing.Color.Red;
            this.RPC_label3.Location = new System.Drawing.Point(763, 11);
            this.RPC_label3.Name = "RPC_label3";
            this.RPC_label3.Size = new System.Drawing.Size(261, 104);
            this.RPC_label3.TabIndex = 11;
            this.RPC_label3.Text = resources.GetString("RPC_label3.Text");
            // 
            // RPC_label2
            // 
            this.RPC_label2.AutoSize = true;
            this.RPC_label2.Location = new System.Drawing.Point(6, 22);
            this.RPC_label2.Name = "RPC_label2";
            this.RPC_label2.Size = new System.Drawing.Size(116, 13);
            this.RPC_label2.TabIndex = 10;
            this.RPC_label2.Text = "Random pixel chance: ";
            // 
            // RPC_numeric_randomPixelChance
            // 
            this.RPC_numeric_randomPixelChance.Location = new System.Drawing.Point(128, 20);
            this.RPC_numeric_randomPixelChance.Name = "RPC_numeric_randomPixelChance";
            this.RPC_numeric_randomPixelChance.Size = new System.Drawing.Size(62, 20);
            this.RPC_numeric_randomPixelChance.TabIndex = 9;
            // 
            // RPC_label1
            // 
            this.RPC_label1.AutoSize = true;
            this.RPC_label1.Location = new System.Drawing.Point(214, 22);
            this.RPC_label1.Name = "RPC_label1";
            this.RPC_label1.Size = new System.Drawing.Size(81, 13);
            this.RPC_label1.TabIndex = 8;
            this.RPC_label1.Text = "Cluster chance:";
            // 
            // RPC_numeric_clusterChance
            // 
            this.RPC_numeric_clusterChance.Location = new System.Drawing.Point(301, 20);
            this.RPC_numeric_clusterChance.Name = "RPC_numeric_clusterChance";
            this.RPC_numeric_clusterChance.Size = new System.Drawing.Size(62, 20);
            this.RPC_numeric_clusterChance.TabIndex = 7;
            // 
            // RPC_label_randClustersize_max
            // 
            this.RPC_label_randClustersize_max.AutoSize = true;
            this.RPC_label_randClustersize_max.Enabled = false;
            this.RPC_label_randClustersize_max.Location = new System.Drawing.Point(319, 97);
            this.RPC_label_randClustersize_max.Name = "RPC_label_randClustersize_max";
            this.RPC_label_randClustersize_max.Size = new System.Drawing.Size(30, 13);
            this.RPC_label_randClustersize_max.TabIndex = 6;
            this.RPC_label_randClustersize_max.Text = "Max:";
            // 
            // RPC_numeric_randClustersize_max
            // 
            this.RPC_numeric_randClustersize_max.Enabled = false;
            this.RPC_numeric_randClustersize_max.Location = new System.Drawing.Point(352, 95);
            this.RPC_numeric_randClustersize_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RPC_numeric_randClustersize_max.Name = "RPC_numeric_randClustersize_max";
            this.RPC_numeric_randClustersize_max.Size = new System.Drawing.Size(62, 20);
            this.RPC_numeric_randClustersize_max.TabIndex = 5;
            // 
            // RPC_label_randClustersize_min
            // 
            this.RPC_label_randClustersize_min.AutoSize = true;
            this.RPC_label_randClustersize_min.Enabled = false;
            this.RPC_label_randClustersize_min.Location = new System.Drawing.Point(214, 97);
            this.RPC_label_randClustersize_min.Name = "RPC_label_randClustersize_min";
            this.RPC_label_randClustersize_min.Size = new System.Drawing.Size(27, 13);
            this.RPC_label_randClustersize_min.TabIndex = 4;
            this.RPC_label_randClustersize_min.Text = "Min:";
            // 
            // RPC_numeric_randClustersize_min
            // 
            this.RPC_numeric_randClustersize_min.Enabled = false;
            this.RPC_numeric_randClustersize_min.Location = new System.Drawing.Point(247, 95);
            this.RPC_numeric_randClustersize_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RPC_numeric_randClustersize_min.Name = "RPC_numeric_randClustersize_min";
            this.RPC_numeric_randClustersize_min.Size = new System.Drawing.Size(62, 20);
            this.RPC_numeric_randClustersize_min.TabIndex = 3;
            // 
            // RPC_check_randomClustersize
            // 
            this.RPC_check_randomClustersize.AutoSize = true;
            this.RPC_check_randomClustersize.Location = new System.Drawing.Point(214, 72);
            this.RPC_check_randomClustersize.Name = "RPC_check_randomClustersize";
            this.RPC_check_randomClustersize.Size = new System.Drawing.Size(121, 17);
            this.RPC_check_randomClustersize.TabIndex = 2;
            this.RPC_check_randomClustersize.Text = "Random cluster size";
            this.RPC_check_randomClustersize.UseVisualStyleBackColor = true;
            this.RPC_check_randomClustersize.CheckedChanged += new System.EventHandler(this.check_randomClustersize_CheckedChanged);
            // 
            // RPC_label_clustersize
            // 
            this.RPC_label_clustersize.AutoSize = true;
            this.RPC_label_clustersize.Location = new System.Drawing.Point(214, 48);
            this.RPC_label_clustersize.Name = "RPC_label_clustersize";
            this.RPC_label_clustersize.Size = new System.Drawing.Size(63, 13);
            this.RPC_label_clustersize.TabIndex = 1;
            this.RPC_label_clustersize.Text = "Cluster size:";
            // 
            // RPC_numeric_clusterSize
            // 
            this.RPC_numeric_clusterSize.Location = new System.Drawing.Point(301, 46);
            this.RPC_numeric_clusterSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RPC_numeric_clusterSize.Name = "RPC_numeric_clusterSize";
            this.RPC_numeric_clusterSize.Size = new System.Drawing.Size(62, 20);
            this.RPC_numeric_clusterSize.TabIndex = 0;
            // 
            // tabcontrol_glitchMethods
            // 
            this.tabcontrol_glitchMethods.Controls.Add(this.tabl_randomizePixelColors);
            this.tabcontrol_glitchMethods.Controls.Add(this.tabl_newRandomizePixelColors);
            this.tabcontrol_glitchMethods.Controls.Add(this.tab_dragOutPixels);
            this.tabcontrol_glitchMethods.Controls.Add(this.tab_applyNoise);
            this.tabcontrol_glitchMethods.Controls.Add(this.tab_bitMosh);
            this.tabcontrol_glitchMethods.Controls.Add(this.tab_tearing);
            this.tabcontrol_glitchMethods.Location = new System.Drawing.Point(25, 12);
            this.tabcontrol_glitchMethods.Name = "tabcontrol_glitchMethods";
            this.tabcontrol_glitchMethods.SelectedIndex = 0;
            this.tabcontrol_glitchMethods.Size = new System.Drawing.Size(1047, 166);
            this.tabcontrol_glitchMethods.TabIndex = 9;
            // 
            // tabl_randomizePixelColors
            // 
            this.tabl_randomizePixelColors.Controls.Add(this.groupBox1);
            this.tabl_randomizePixelColors.Location = new System.Drawing.Point(4, 22);
            this.tabl_randomizePixelColors.Name = "tabl_randomizePixelColors";
            this.tabl_randomizePixelColors.Padding = new System.Windows.Forms.Padding(3);
            this.tabl_randomizePixelColors.Size = new System.Drawing.Size(1039, 140);
            this.tabl_randomizePixelColors.TabIndex = 0;
            this.tabl_randomizePixelColors.Tag = "RandomizePixelColors";
            this.tabl_randomizePixelColors.Text = "Randomize Pixel Colors";
            this.tabl_randomizePixelColors.UseVisualStyleBackColor = true;
            // 
            // tabl_newRandomizePixelColors
            // 
            this.tabl_newRandomizePixelColors.Controls.Add(this.groupBox2);
            this.tabl_newRandomizePixelColors.Location = new System.Drawing.Point(4, 22);
            this.tabl_newRandomizePixelColors.Name = "tabl_newRandomizePixelColors";
            this.tabl_newRandomizePixelColors.Padding = new System.Windows.Forms.Padding(3);
            this.tabl_newRandomizePixelColors.Size = new System.Drawing.Size(1039, 140);
            this.tabl_newRandomizePixelColors.TabIndex = 1;
            this.tabl_newRandomizePixelColors.Tag = "NewRandomColorPixels";
            this.tabl_newRandomizePixelColors.Text = "New Randomize Pixel Colors";
            this.tabl_newRandomizePixelColors.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NRPC_label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // NRPC_label4
            // 
            this.NRPC_label4.AutoSize = true;
            this.NRPC_label4.ForeColor = System.Drawing.Color.Blue;
            this.NRPC_label4.Location = new System.Drawing.Point(951, 118);
            this.NRPC_label4.Name = "NRPC_label4";
            this.NRPC_label4.Size = new System.Drawing.Size(79, 13);
            this.NRPC_label4.TabIndex = 11;
            this.NRPC_label4.Text = "Author: Gerben";
            // 
            // tab_dragOutPixels
            // 
            this.tab_dragOutPixels.Controls.Add(this.groupBox3);
            this.tab_dragOutPixels.Location = new System.Drawing.Point(4, 22);
            this.tab_dragOutPixels.Name = "tab_dragOutPixels";
            this.tab_dragOutPixels.Size = new System.Drawing.Size(1039, 140);
            this.tab_dragOutPixels.TabIndex = 2;
            this.tab_dragOutPixels.Tag = "DragOutPixels";
            this.tab_dragOutPixels.Text = "Drag out Pixels";
            this.tab_dragOutPixels.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DOP_label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1030, 134);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // DOP_label6
            // 
            this.DOP_label6.AutoSize = true;
            this.DOP_label6.ForeColor = System.Drawing.Color.Blue;
            this.DOP_label6.Location = new System.Drawing.Point(951, 118);
            this.DOP_label6.Name = "DOP_label6";
            this.DOP_label6.Size = new System.Drawing.Size(79, 13);
            this.DOP_label6.TabIndex = 11;
            this.DOP_label6.Text = "Author: Gerben";
            // 
            // tab_applyNoise
            // 
            this.tab_applyNoise.Controls.Add(this.groupBox4);
            this.tab_applyNoise.Location = new System.Drawing.Point(4, 22);
            this.tab_applyNoise.Name = "tab_applyNoise";
            this.tab_applyNoise.Size = new System.Drawing.Size(1039, 140);
            this.tab_applyNoise.TabIndex = 3;
            this.tab_applyNoise.Tag = "ApplyNoise";
            this.tab_applyNoise.Text = "Apply Noise";
            this.tab_applyNoise.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AN_label_randomChange);
            this.groupBox4.Controls.Add(this.AN_numeric_randomChange);
            this.groupBox4.Controls.Add(this.AN_label_clusterSize);
            this.groupBox4.Controls.Add(this.AN_numeric_clusterSize);
            this.groupBox4.Controls.Add(this.AN_label5);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1030, 134);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // AN_label_clusterSize
            // 
            this.AN_label_clusterSize.AutoSize = true;
            this.AN_label_clusterSize.Location = new System.Drawing.Point(6, 29);
            this.AN_label_clusterSize.Name = "AN_label_clusterSize";
            this.AN_label_clusterSize.Size = new System.Drawing.Size(63, 13);
            this.AN_label_clusterSize.TabIndex = 14;
            this.AN_label_clusterSize.Text = "Cluster size:";
            // 
            // AN_numeric_clusterSize
            // 
            this.AN_numeric_clusterSize.Location = new System.Drawing.Point(104, 27);
            this.AN_numeric_clusterSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AN_numeric_clusterSize.Name = "AN_numeric_clusterSize";
            this.AN_numeric_clusterSize.Size = new System.Drawing.Size(62, 20);
            this.AN_numeric_clusterSize.TabIndex = 13;
            // 
            // AN_label5
            // 
            this.AN_label5.AutoSize = true;
            this.AN_label5.ForeColor = System.Drawing.Color.Blue;
            this.AN_label5.Location = new System.Drawing.Point(951, 118);
            this.AN_label5.Name = "AN_label5";
            this.AN_label5.Size = new System.Drawing.Size(75, 13);
            this.AN_label5.TabIndex = 11;
            this.AN_label5.Text = "Author: Tijmen";
            // 
            // tab_bitMosh
            // 
            this.tab_bitMosh.Controls.Add(this.groupBox5);
            this.tab_bitMosh.Location = new System.Drawing.Point(4, 22);
            this.tab_bitMosh.Name = "tab_bitMosh";
            this.tab_bitMosh.Size = new System.Drawing.Size(1039, 140);
            this.tab_bitMosh.TabIndex = 4;
            this.tab_bitMosh.Tag = "BitMosh";
            this.tab_bitMosh.Text = "Bit Mosh";
            this.tab_bitMosh.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BM_label_randomChange);
            this.groupBox5.Controls.Add(this.BM_label7);
            this.groupBox5.Controls.Add(this.BM_numeric_randomChange);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1030, 134);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // BM_label7
            // 
            this.BM_label7.AutoSize = true;
            this.BM_label7.ForeColor = System.Drawing.Color.Blue;
            this.BM_label7.Location = new System.Drawing.Point(951, 118);
            this.BM_label7.Name = "BM_label7";
            this.BM_label7.Size = new System.Drawing.Size(75, 13);
            this.BM_label7.TabIndex = 11;
            this.BM_label7.Text = "Author: Tijmen";
            // 
            // tab_tearing
            // 
            this.tab_tearing.Controls.Add(this.groupBox6);
            this.tab_tearing.Location = new System.Drawing.Point(4, 22);
            this.tab_tearing.Name = "tab_tearing";
            this.tab_tearing.Size = new System.Drawing.Size(1039, 140);
            this.tab_tearing.TabIndex = 5;
            this.tab_tearing.Tag = "Tear";
            this.tab_tearing.Text = "Tearing";
            this.tab_tearing.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.T_label8);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1030, 134);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // T_label8
            // 
            this.T_label8.AutoSize = true;
            this.T_label8.ForeColor = System.Drawing.Color.Blue;
            this.T_label8.Location = new System.Drawing.Point(951, 118);
            this.T_label8.Name = "T_label8";
            this.T_label8.Size = new System.Drawing.Size(76, 13);
            this.T_label8.TabIndex = 11;
            this.T_label8.Text = "Author: Freddy";
            // 
            // textbox_selectedFile
            // 
            this.textbox_selectedFile.Location = new System.Drawing.Point(178, 186);
            this.textbox_selectedFile.Name = "textbox_selectedFile";
            this.textbox_selectedFile.ReadOnly = true;
            this.textbox_selectedFile.Size = new System.Drawing.Size(122, 20);
            this.textbox_selectedFile.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Selected file: ";
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(389, 184);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 12;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // AN_label_randomChange
            // 
            this.AN_label_randomChange.AutoSize = true;
            this.AN_label_randomChange.Location = new System.Drawing.Point(6, 59);
            this.AN_label_randomChange.Name = "AN_label_randomChange";
            this.AN_label_randomChange.Size = new System.Drawing.Size(92, 13);
            this.AN_label_randomChange.TabIndex = 16;
            this.AN_label_randomChange.Text = "Random change: ";
            // 
            // AN_numeric_randomChange
            // 
            this.AN_numeric_randomChange.Location = new System.Drawing.Point(104, 57);
            this.AN_numeric_randomChange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AN_numeric_randomChange.Name = "AN_numeric_randomChange";
            this.AN_numeric_randomChange.Size = new System.Drawing.Size(62, 20);
            this.AN_numeric_randomChange.TabIndex = 15;
            // 
            // BM_label_randomChange
            // 
            this.BM_label_randomChange.AutoSize = true;
            this.BM_label_randomChange.Location = new System.Drawing.Point(6, 33);
            this.BM_label_randomChange.Name = "BM_label_randomChange";
            this.BM_label_randomChange.Size = new System.Drawing.Size(92, 13);
            this.BM_label_randomChange.TabIndex = 18;
            this.BM_label_randomChange.Text = "Random change: ";
            // 
            // BM_numeric_randomChange
            // 
            this.BM_numeric_randomChange.Location = new System.Drawing.Point(104, 31);
            this.BM_numeric_randomChange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BM_numeric_randomChange.Name = "BM_numeric_randomChange";
            this.BM_numeric_randomChange.Size = new System.Drawing.Size(62, 20);
            this.BM_numeric_randomChange.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 709);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textbox_selectedFile);
            this.Controls.Add(this.tabcontrol_glitchMethods);
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
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randomPixelChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_clusterChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randClustersize_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_randClustersize_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPC_numeric_clusterSize)).EndInit();
            this.tabcontrol_glitchMethods.ResumeLayout(false);
            this.tabl_randomizePixelColors.ResumeLayout(false);
            this.tabl_newRandomizePixelColors.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_dragOutPixels.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_applyNoise.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_numeric_clusterSize)).EndInit();
            this.tab_bitMosh.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab_tearing.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AN_numeric_randomChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM_numeric_randomChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RPC_label_clustersize;
        private System.Windows.Forms.Label RPC_label_randClustersize_max;
        private System.Windows.Forms.Label RPC_label_randClustersize_min;
        private System.Windows.Forms.Label RPC_label1;
        private System.Windows.Forms.Label RPC_label2;
        private System.Windows.Forms.Label RPC_label3;
        private System.Windows.Forms.TabControl tabcontrol_glitchMethods;
        private System.Windows.Forms.TabPage tabl_randomizePixelColors;
        private System.Windows.Forms.TabPage tabl_newRandomizePixelColors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tab_dragOutPixels;
        private System.Windows.Forms.TabPage tab_applyNoise;
        private System.Windows.Forms.TabPage tab_bitMosh;
        private System.Windows.Forms.TabPage tab_tearing;
        private System.Windows.Forms.Label RPC_label_author;
        private System.Windows.Forms.Label NRPC_label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label DOP_label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label AN_label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label BM_label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label T_label8;
        private System.Windows.Forms.TextBox textbox_selectedFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_start;
        public System.Windows.Forms.NumericUpDown RPC_numeric_clusterSize;
        public System.Windows.Forms.NumericUpDown RPC_numeric_randClustersize_max;
        public System.Windows.Forms.NumericUpDown RPC_numeric_randClustersize_min;
        public System.Windows.Forms.CheckBox RPC_check_randomClustersize;
        public System.Windows.Forms.NumericUpDown RPC_numeric_clusterChance;
        public System.Windows.Forms.NumericUpDown RPC_numeric_randomPixelChance;
        public System.Windows.Forms.PictureBox picture_original;
        public System.Windows.Forms.PictureBox picture_new;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label AN_label_clusterSize;
        public System.Windows.Forms.NumericUpDown AN_numeric_clusterSize;
        private System.Windows.Forms.Label AN_label_randomChange;
        public System.Windows.Forms.NumericUpDown AN_numeric_randomChange;
        private System.Windows.Forms.Label BM_label_randomChange;
        public System.Windows.Forms.NumericUpDown BM_numeric_randomChange;
    }
}

