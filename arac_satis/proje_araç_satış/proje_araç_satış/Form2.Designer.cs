namespace proje_araç_satış
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.ileri_geri = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.araç_satışDataSet = new proje_araç_satış.araç_satışDataSet();
            this.markaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fKMotorModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKModelMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.fKRenkMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markaTableAdapter = new proje_araç_satış.araç_satışDataSetTableAdapters.MarkaTableAdapter();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new proje_araç_satış.araç_satışDataSetTableAdapters.ModelTableAdapter();
            this.motorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motorTableAdapter = new proje_araç_satış.araç_satışDataSetTableAdapters.MotorTableAdapter();
            this.renkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.renkTableAdapter = new proje_araç_satış.araç_satışDataSetTableAdapters.RenkTableAdapter();
            this.markaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKMotorModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araç_satışDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMotorModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRenkMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMotorModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageKey = "sol_okk.png";
            this.button1.ImageList = this.ileri_geri;
            this.button1.Location = new System.Drawing.Point(846, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ileri_geri
            // 
            this.ileri_geri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ileri_geri.ImageStream")));
            this.ileri_geri.TransparentColor = System.Drawing.Color.Transparent;
            this.ileri_geri.Images.SetKeyName(0, "sağ_okk.png");
            this.ileri_geri.Images.SetKeyName(1, "sol_okk.png");
            this.ileri_geri.Images.SetKeyName(2, "çıkış.png");
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.ImageKey = "çıkış.png";
            this.button2.ImageList = this.ileri_geri;
            this.button2.Location = new System.Drawing.Point(892, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.markaBindingSource;
            this.comboBox1.DisplayMember = "ArabaMarka";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.araç_satışDataSet;
            this.markaBindingSource.CurrentChanged += new System.EventHandler(this.markaBindingSource_CurrentChanged);
            // 
            // araç_satışDataSet
            // 
            this.araç_satışDataSet.DataSetName = "araç_satışDataSet";
            this.araç_satışDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource2
            // 
            this.markaBindingSource2.DataMember = "Marka";
            this.markaBindingSource2.DataSource = this.araç_satışDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.fKMotorModelBindingSource1;
            this.comboBox2.DisplayMember = "ArabaMotor";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(84, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // fKMotorModelBindingSource1
            // 
            this.fKMotorModelBindingSource1.DataMember = "FK_Motor_Model";
            this.fKMotorModelBindingSource1.DataSource = this.fKModelMarkaBindingSource;
            // 
            // fKModelMarkaBindingSource
            // 
            this.fKModelMarkaBindingSource.DataMember = "FK_Model_Marka";
            this.fKModelMarkaBindingSource.DataSource = this.markaBindingSource;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.fKModelMarkaBindingSource;
            this.comboBox3.DisplayMember = "ArabaModel";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(84, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.fKRenkMarkaBindingSource;
            this.comboBox4.DisplayMember = "ArabaRenk";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(84, 173);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // fKRenkMarkaBindingSource
            // 
            this.fKRenkMarkaBindingSource.DataMember = "FK_Renk_Marka";
            this.fKRenkMarkaBindingSource.DataSource = this.markaBindingSource;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.araç_satışDataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // motorBindingSource
            // 
            this.motorBindingSource.DataMember = "Motor";
            this.motorBindingSource.DataSource = this.araç_satışDataSet;
            // 
            // motorTableAdapter
            // 
            this.motorTableAdapter.ClearBeforeFill = true;
            // 
            // renkBindingSource
            // 
            this.renkBindingSource.DataMember = "Renk";
            this.renkBindingSource.DataSource = this.araç_satışDataSet;
            // 
            // renkTableAdapter
            // 
            this.renkTableAdapter.ClearBeforeFill = true;
            // 
            // markaBindingSource1
            // 
            this.markaBindingSource1.DataMember = "Marka";
            this.markaBindingSource1.DataSource = this.araç_satışDataSet;
            // 
            // fKMotorModelBindingSource
            // 
            this.fKMotorModelBindingSource.DataMember = "FK_Motor_Model";
            this.fKMotorModelBindingSource.DataSource = this.modelBindingSource;
            // 
            // markaBindingSource3
            // 
            this.markaBindingSource3.DataMember = "Marka";
            this.markaBindingSource3.DataSource = this.araç_satışDataSet;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(576, 166);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(132, 17);
            this.checkBox9.TabIndex = 22;
            this.checkBox9.Text = "Elektrikli Ayna +500TL";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(576, 143);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(118, 17);
            this.checkBox8.TabIndex = 21;
            this.checkBox8.Text = "Çelik Jant +2000TL";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(576, 120);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(168, 17);
            this.checkBox7.TabIndex = 20;
            this.checkBox7.Text = "Geri Görüş Kamerası +1000TL";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(576, 97);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(170, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Sürüş Yardım Sistemi +5000TL";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(359, 187);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(136, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Isıtmalı Koltuk +2000TL";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(359, 164);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(126, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Ses Sistemi +1000TL";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(359, 141);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Cam Tavan +2000TL";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(359, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Deri Koltuk +1000TL";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(359, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "10\' Dokunmatik Ekran  +1500TL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(573, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dış Aksesuar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "İç Aksesuar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(354, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aracınız için aksesuarları seçiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Araç Modellerimiz";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(750, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kaydet";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Marka:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(842, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 36);
            this.button4.TabIndex = 30;
            this.button4.Text = "Satın Al";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(750, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 198);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(27, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Audi.png");
            this.ımageList1.Images.SetKeyName(1, "Renault.png");
            this.ımageList1.Images.SetKeyName(2, "volkswagen.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Renk:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 342);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Galeri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araç_satışDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMotorModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRenkMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMotorModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ileri_geri;
        private araç_satışDataSet araç_satışDataSet;
        private araç_satışDataSetTableAdapters.MarkaTableAdapter markaTableAdapter;
        private araç_satışDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private araç_satışDataSetTableAdapters.MotorTableAdapter motorTableAdapter;
        private araç_satışDataSetTableAdapters.RenkTableAdapter renkTableAdapter;
        private System.Windows.Forms.BindingSource fKMotorModelBindingSource;
        private System.Windows.Forms.BindingSource fKModelMarkaBindingSource;
        private System.Windows.Forms.BindingSource markaBindingSource1;
        private System.Windows.Forms.BindingSource fKMotorModelBindingSource1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource markaBindingSource2;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource markaBindingSource3;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBox9;
        public System.Windows.Forms.CheckBox checkBox8;
        public System.Windows.Forms.CheckBox checkBox7;
        public System.Windows.Forms.CheckBox checkBox6;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.BindingSource markaBindingSource;
        public System.Windows.Forms.BindingSource modelBindingSource;
        public System.Windows.Forms.BindingSource motorBindingSource;
        public System.Windows.Forms.BindingSource renkBindingSource;
        public System.Windows.Forms.BindingSource fKRenkMarkaBindingSource;
    }
}