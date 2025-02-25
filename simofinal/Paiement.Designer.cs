namespace simofinal
{
    partial class Paiement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paiement));
            this.button1 = new System.Windows.Forms.Button();
            this.client_idsearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FactureId = new System.Windows.Forms.TextBox();
            this.paimentdv = new System.Windows.Forms.DataGridView();
            this.idfacturesearch = new System.Windows.Forms.Button();
            this.ID_paiementsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idFactureComboBox = new System.Windows.Forms.ComboBox();
            this.modePaiementComboBox = new System.Windows.Forms.ComboBox();
            this.datePaiementPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.montantPaiementTextBox = new System.Windows.Forms.TextBox();
            this.idPaiementTextBox = new System.Windows.Forms.TextBox();
            this.nompatient = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accueil = new System.Windows.Forms.Button();
            this.lit = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.rendezvous = new System.Windows.Forms.Button();
            this.medicaux = new System.Windows.Forms.Button();
            this.facture = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paimentdv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(465, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 306;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // client_idsearch
            // 
            this.client_idsearch.Location = new System.Drawing.Point(314, 685);
            this.client_idsearch.Multiline = true;
            this.client_idsearch.Name = "client_idsearch";
            this.client_idsearch.Size = new System.Drawing.Size(121, 35);
            this.client_idsearch.TabIndex = 305;
            this.client_idsearch.TextChanged += new System.EventHandler(this.client_idsearch_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1357, 565);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 34);
            this.button3.TabIndex = 360;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FactureId
            // 
            this.FactureId.Location = new System.Drawing.Point(1223, 564);
            this.FactureId.Multiline = true;
            this.FactureId.Name = "FactureId";
            this.FactureId.Size = new System.Drawing.Size(121, 35);
            this.FactureId.TabIndex = 359;
            this.FactureId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paimentdv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.paimentdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.paimentdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paimentdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.paimentdv.BackgroundColor = System.Drawing.Color.White;
            this.paimentdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.paimentdv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paimentdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.paimentdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paimentdv.DefaultCellStyle = dataGridViewCellStyle9;
            this.paimentdv.Location = new System.Drawing.Point(223, 623);
            this.paimentdv.Name = "paimentdv";
            this.paimentdv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.paimentdv.RowTemplate.Height = 24;
            this.paimentdv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.paimentdv.Size = new System.Drawing.Size(1268, 391);
            this.paimentdv.TabIndex = 358;
            this.paimentdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paimentdv_CellClick);
            // 
            // idfacturesearch
            // 
            this.idfacturesearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idfacturesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idfacturesearch.Location = new System.Drawing.Point(593, 574);
            this.idfacturesearch.Name = "idfacturesearch";
            this.idfacturesearch.Size = new System.Drawing.Size(86, 34);
            this.idfacturesearch.TabIndex = 356;
            this.idfacturesearch.Text = "Search";
            this.idfacturesearch.UseVisualStyleBackColor = true;
            this.idfacturesearch.Click += new System.EventHandler(this.button11_Click);
            // 
            // ID_paiementsearch
            // 
            this.ID_paiementsearch.Location = new System.Drawing.Point(459, 573);
            this.ID_paiementsearch.Multiline = true;
            this.ID_paiementsearch.Name = "ID_paiementsearch";
            this.ID_paiementsearch.Size = new System.Drawing.Size(121, 35);
            this.ID_paiementsearch.TabIndex = 355;
            this.ID_paiementsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1028, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 354;
            this.label5.Text = "Search id Facture ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 38);
            this.label4.TabIndex = 352;
            this.label4.Text = "List Of Paiement";
            // 
            // idFactureComboBox
            // 
            this.idFactureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFactureComboBox.FormattingEnabled = true;
            this.idFactureComboBox.Location = new System.Drawing.Point(810, 343);
            this.idFactureComboBox.Name = "idFactureComboBox";
            this.idFactureComboBox.Size = new System.Drawing.Size(241, 28);
            this.idFactureComboBox.TabIndex = 351;
            // 
            // modePaiementComboBox
            // 
            this.modePaiementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modePaiementComboBox.FormattingEnabled = true;
            this.modePaiementComboBox.Items.AddRange(new object[] {
            "payée",
            "en attente"});
            this.modePaiementComboBox.Location = new System.Drawing.Point(459, 343);
            this.modePaiementComboBox.Name = "modePaiementComboBox";
            this.modePaiementComboBox.Size = new System.Drawing.Size(241, 28);
            this.modePaiementComboBox.TabIndex = 350;
            // 
            // datePaiementPicker
            // 
            this.datePaiementPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePaiementPicker.Location = new System.Drawing.Point(757, 209);
            this.datePaiementPicker.Name = "datePaiementPicker";
            this.datePaiementPicker.Size = new System.Drawing.Size(338, 30);
            this.datePaiementPicker.TabIndex = 349;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 348;
            this.label1.Text = "ID_facture ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 347;
            this.label3.Text = "Mode_paiement ";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1103, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 65);
            this.button7.TabIndex = 346;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(951, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 65);
            this.button6.TabIndex = 345;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1064, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 32);
            this.label2.TabIndex = 344;
            this.label2.Text = "Montant_paiement ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(786, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 65);
            this.button4.TabIndex = 343;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(488, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 65);
            this.button5.TabIndex = 342;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(622, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 65);
            this.button8.TabIndex = 341;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // montantPaiementTextBox
            // 
            this.montantPaiementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantPaiementTextBox.Location = new System.Drawing.Point(1191, 196);
            this.montantPaiementTextBox.Multiline = true;
            this.montantPaiementTextBox.Name = "montantPaiementTextBox";
            this.montantPaiementTextBox.Size = new System.Drawing.Size(278, 50);
            this.montantPaiementTextBox.TabIndex = 340;
            this.montantPaiementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idPaiementTextBox
            // 
            this.idPaiementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPaiementTextBox.Enabled = false;
            this.idPaiementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPaiementTextBox.Location = new System.Drawing.Point(325, 211);
            this.idPaiementTextBox.Multiline = true;
            this.idPaiementTextBox.Name = "idPaiementTextBox";
            this.idPaiementTextBox.Size = new System.Drawing.Size(243, 35);
            this.idPaiementTextBox.TabIndex = 339;
            this.idPaiementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nompatient
            // 
            this.nompatient.AutoSize = true;
            this.nompatient.BackColor = System.Drawing.Color.Transparent;
            this.nompatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nompatient.Location = new System.Drawing.Point(717, 145);
            this.nompatient.Name = "nompatient";
            this.nompatient.Size = new System.Drawing.Size(214, 32);
            this.nompatient.TabIndex = 338;
            this.nompatient.Text = "Date_paiement ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 32);
            this.label9.TabIndex = 337;
            this.label9.Text = "ID_paiement ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 42);
            this.label8.TabIndex = 336;
            this.label8.Text = "Gestion Paiement ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1230, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 361;
            this.label6.Text = "Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 362;
            this.label7.Text = "Search id Paiement ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.accueil);
            this.panel2.Controls.Add(this.lit);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.rendezvous);
            this.panel2.Controls.Add(this.medicaux);
            this.panel2.Controls.Add(this.facture);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Location = new System.Drawing.Point(-3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 1005);
            this.panel2.TabIndex = 363;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(40, 788);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 60);
            this.button2.TabIndex = 185;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // accueil
            // 
            this.accueil.AutoSize = true;
            this.accueil.BackColor = System.Drawing.Color.Transparent;
            this.accueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accueil.BackgroundImage")));
            this.accueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accueil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil.ForeColor = System.Drawing.Color.Black;
            this.accueil.Location = new System.Drawing.Point(39, 170);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(68, 60);
            this.accueil.TabIndex = 112;
            this.accueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueil.UseVisualStyleBackColor = false;
            // 
            // lit
            // 
            this.lit.AutoSize = true;
            this.lit.BackColor = System.Drawing.Color.Transparent;
            this.lit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lit.BackgroundImage")));
            this.lit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lit.ForeColor = System.Drawing.Color.Black;
            this.lit.Location = new System.Drawing.Point(39, 423);
            this.lit.Name = "lit";
            this.lit.Size = new System.Drawing.Size(68, 60);
            this.lit.TabIndex = 113;
            this.lit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lit.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(39, 333);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 60);
            this.button9.TabIndex = 114;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(39, 257);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 60);
            this.button10.TabIndex = 115;
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(40, 523);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 60);
            this.button11.TabIndex = 116;
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // rendezvous
            // 
            this.rendezvous.AutoSize = true;
            this.rendezvous.BackColor = System.Drawing.Color.Transparent;
            this.rendezvous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rendezvous.BackgroundImage")));
            this.rendezvous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rendezvous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rendezvous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendezvous.ForeColor = System.Drawing.Color.Black;
            this.rendezvous.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rendezvous.Location = new System.Drawing.Point(39, 619);
            this.rendezvous.Name = "rendezvous";
            this.rendezvous.Size = new System.Drawing.Size(68, 60);
            this.rendezvous.TabIndex = 117;
            this.rendezvous.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rendezvous.UseVisualStyleBackColor = false;
            // 
            // medicaux
            // 
            this.medicaux.AutoSize = true;
            this.medicaux.BackColor = System.Drawing.Color.Transparent;
            this.medicaux.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("medicaux.BackgroundImage")));
            this.medicaux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.medicaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicaux.ForeColor = System.Drawing.Color.Black;
            this.medicaux.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medicaux.Location = new System.Drawing.Point(40, 710);
            this.medicaux.Name = "medicaux";
            this.medicaux.Size = new System.Drawing.Size(68, 60);
            this.medicaux.TabIndex = 118;
            this.medicaux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicaux.UseVisualStyleBackColor = false;
            // 
            // facture
            // 
            this.facture.AutoSize = true;
            this.facture.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.facture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facture.BackgroundImage")));
            this.facture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facture.ForeColor = System.Drawing.Color.Black;
            this.facture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.facture.Location = new System.Drawing.Point(40, 867);
            this.facture.Name = "facture";
            this.facture.Size = new System.Drawing.Size(68, 60);
            this.facture.TabIndex = 120;
            this.facture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facture.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.Location = new System.Drawing.Point(40, 951);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(68, 46);
            this.logout.TabIndex = 122;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 39);
            this.panel1.TabIndex = 364;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Control;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button13.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button13.Location = new System.Drawing.Point(1500, -3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(44, 39);
            this.button13.TabIndex = 150;
            this.button13.Text = "_";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(1550, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 39);
            this.close.TabIndex = 149;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1594, 1042);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FactureId);
            this.Controls.Add(this.paimentdv);
            this.Controls.Add(this.idfacturesearch);
            this.Controls.Add(this.ID_paiementsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idFactureComboBox);
            this.Controls.Add(this.modePaiementComboBox);
            this.Controls.Add(this.datePaiementPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.montantPaiementTextBox);
            this.Controls.Add(this.idPaiementTextBox);
            this.Controls.Add(this.nompatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_idsearch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paiement";
            ((System.ComponentModel.ISupportInitialize)(this.paimentdv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox client_idsearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox FactureId;
        private System.Windows.Forms.DataGridView paimentdv;
        private System.Windows.Forms.Button idfacturesearch;
        private System.Windows.Forms.TextBox ID_paiementsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox idFactureComboBox;
        private System.Windows.Forms.ComboBox modePaiementComboBox;
        private System.Windows.Forms.DateTimePicker datePaiementPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox montantPaiementTextBox;
        private System.Windows.Forms.TextBox idPaiementTextBox;
        private System.Windows.Forms.Label nompatient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button lit;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button rendezvous;
        private System.Windows.Forms.Button medicaux;
        private System.Windows.Forms.Button facture;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button close;
    }
}