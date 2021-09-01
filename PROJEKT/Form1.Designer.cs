namespace PROJEKT
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
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHighScores = new System.Windows.Forms.Panel();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panelMainGame = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelcounter = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panelHighScores.SuspendLayout();
            this.panelMainGame.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation10;
            this.bunifuTransition1.Interval = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::PROJEKT.Properties.Resources.kkk;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelHighScores);
            this.panel1.Controls.Add(this.panelMainGame);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 683);
            this.panel1.TabIndex = 0;
            // 
            // panelHighScores
            // 
            this.panelHighScores.BackColor = System.Drawing.Color.White;
            this.panelHighScores.BackgroundImage = global::PROJEKT.Properties.Resources._46380112_1563031440509767_6473130556820291584_n;
            this.panelHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHighScores.Controls.Add(this.listBoxScores);
            this.panelHighScores.Controls.Add(this.button6);
            this.bunifuTransition1.SetDecoration(this.panelHighScores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelHighScores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelHighScores, BunifuAnimatorNS.DecorationType.None);
            this.panelHighScores.Location = new System.Drawing.Point(0, 0);
            this.panelHighScores.Name = "panelHighScores";
            this.panelHighScores.Size = new System.Drawing.Size(1265, 683);
            this.panelHighScores.TabIndex = 5;
            this.panelHighScores.Visible = false;
            this.panelHighScores.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHighScores_Paint);
            // 
            // listBoxScores
            // 
            this.listBoxScores.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition2.SetDecoration(this.listBoxScores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.listBoxScores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.listBoxScores, BunifuAnimatorNS.DecorationType.None);
            this.listBoxScores.Enabled = false;
            this.listBoxScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxScores.ForeColor = System.Drawing.Color.Black;
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.ItemHeight = 25;
            this.listBoxScores.Location = new System.Drawing.Point(294, 41);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(690, 500);
            this.listBoxScores.TabIndex = 1;
            this.listBoxScores.SelectedIndexChanged += new System.EventHandler(this.listBoxScores_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(578, 597);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Zamknij mnie ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelMainGame
            // 
            this.panelMainGame.BackColor = System.Drawing.Color.White;
            this.panelMainGame.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panelMainGame, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panelMainGame, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panelMainGame, BunifuAnimatorNS.DecorationType.None);
            this.panelMainGame.Location = new System.Drawing.Point(0, 0);
            this.panelMainGame.Name = "panelMainGame";
            this.panelMainGame.Size = new System.Drawing.Size(1265, 683);
            this.panelMainGame.TabIndex = 4;
            this.panelMainGame.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.labelcounter);
            this.panel3.Controls.Add(this.labelPoints);
            this.panel3.Controls.Add(this.textBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 101);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(21, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 67);
            this.button4.TabIndex = 2;
            this.button4.Text = "WYJDŹ Z GRY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.bunifuTransition3.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(188, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 67);
            this.button5.TabIndex = 3;
            this.button5.Text = "ZAKOŃCZ PRÓBĘ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PROJEKT.Properties.Resources.lumberjack_logo_4DD6F7F9C8_seeklogo_com;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition3.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(1132, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 101);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelcounter
            // 
            this.labelcounter.AutoSize = true;
            this.bunifuTransition3.SetDecoration(this.labelcounter, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.labelcounter, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.labelcounter, BunifuAnimatorNS.DecorationType.None);
            this.labelcounter.Font = new System.Drawing.Font("Buxton Sketch", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelcounter.Location = new System.Drawing.Point(907, 58);
            this.labelcounter.Name = "labelcounter";
            this.labelcounter.Size = new System.Drawing.Size(34, 39);
            this.labelcounter.TabIndex = 2;
            this.labelcounter.Text = "0";
            this.labelcounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.bunifuTransition3.SetDecoration(this.labelPoints, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.labelPoints, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.labelPoints, BunifuAnimatorNS.DecorationType.None);
            this.labelPoints.Font = new System.Drawing.Font("Buxton Sketch", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(670, 58);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(34, 39);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "0";
            this.labelPoints.Click += new System.EventHandler(this.labelPoints_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition3.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Font = new System.Drawing.Font("Buxton Sketch", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(612, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WYNIK";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PROJEKT.Properties.Resources.saw_transparent_lumberjack_4;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(717, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = global::PROJEKT.Properties.Resources.victorian_1801497__340;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Font = new System.Drawing.Font("Buxton Sketch", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(200, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "WYJDŹ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::PROJEKT.Properties.Resources.victorian_1801497__340;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Font = new System.Drawing.Font("Buxton Sketch", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(200, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "WYNIKI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::PROJEKT.Properties.Resources.victorian_1801497__340;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition3.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Buxton Sketch", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(200, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "GRAJ!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation11;
            this.bunifuTransition2.Interval = 30;
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition3.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 1F;
            this.bunifuTransition3.DefaultAnimation = animation12;
            this.bunifuTransition3.Interval = 30;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition3.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.Font = new System.Drawing.Font("Buxton Sketch", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(872, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 60);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "CZAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelHighScores.ResumeLayout(false);
            this.panelMainGame.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Panel panelMainGame;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Panel panelHighScores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBoxScores;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelcounter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

