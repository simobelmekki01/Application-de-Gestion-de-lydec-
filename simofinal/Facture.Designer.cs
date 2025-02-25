namespace simofinal
{
    partial class Facture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.facturedv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.IdCompteurSearch = new System.Windows.Forms.TextBox();
            this.Id_quartiersear = new System.Windows.Forms.Label();
            this.Id_compteur = new System.Windows.Forms.ComboBox();
            this.statut_paiement = new System.Windows.Forms.ComboBox();
            this.date_facturation = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.montant = new System.Windows.Forms.TextBox();
            this.Id_facture = new System.Windows.Forms.TextBox();
            this.nompatient = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.ID_Facturesearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.type_service = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accueil = new System.Windows.Forms.Button();
            this.lit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.rendezvous = new System.Windows.Forms.Button();
            this.medicaux = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturedv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facturedv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.facturedv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.facturedv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturedv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.facturedv.BackgroundColor = System.Drawing.Color.White;
            this.facturedv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facturedv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.facturedv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facturedv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.facturedv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facturedv.DefaultCellStyle = dataGridViewCellStyle3;
            this.facturedv.Location = new System.Drawing.Point(187, 628);
            this.facturedv.Name = "facturedv";
            this.facturedv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.facturedv.RowTemplate.Height = 24;
            this.facturedv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.facturedv.Size = new System.Drawing.Size(1306, 396);
            this.facturedv.TabIndex = 310;
            this.facturedv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.facturedv_CellClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1365, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 309;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdCompteurSearch
            // 
            this.IdCompteurSearch.Location = new System.Drawing.Point(1216, 572);
            this.IdCompteurSearch.Multiline = true;
            this.IdCompteurSearch.Name = "IdCompteurSearch";
            this.IdCompteurSearch.Size = new System.Drawing.Size(121, 35);
            this.IdCompteurSearch.TabIndex = 308;
            this.IdCompteurSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id_quartiersear
            // 
            this.Id_quartiersear.AutoSize = true;
            this.Id_quartiersear.BackColor = System.Drawing.Color.Transparent;
            this.Id_quartiersear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_quartiersear.Location = new System.Drawing.Point(1044, 577);
            this.Id_quartiersear.Name = "Id_quartiersear";
            this.Id_quartiersear.Size = new System.Drawing.Size(154, 25);
            this.Id_quartiersear.TabIndex = 307;
            this.Id_quartiersear.Text = "Search id center";
            // 
            // Id_compteur
            // 
            this.Id_compteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_compteur.FormattingEnabled = true;
            this.Id_compteur.Location = new System.Drawing.Point(1021, 330);
            this.Id_compteur.Name = "Id_compteur";
            this.Id_compteur.Size = new System.Drawing.Size(184, 33);
            this.Id_compteur.TabIndex = 339;
            // 
            // statut_paiement
            // 
            this.statut_paiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut_paiement.FormattingEnabled = true;
            this.statut_paiement.Items.AddRange(new object[] {
            "payée",
            "en attente"});
            this.statut_paiement.Location = new System.Drawing.Point(539, 332);
            this.statut_paiement.Name = "statut_paiement";
            this.statut_paiement.Size = new System.Drawing.Size(184, 33);
            this.statut_paiement.TabIndex = 338;
            // 
            // date_facturation
            // 
            this.date_facturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_facturation.Location = new System.Drawing.Point(737, 177);
            this.date_facturation.Name = "date_facturation";
            this.date_facturation.Size = new System.Drawing.Size(282, 30);
            this.date_facturation.TabIndex = 337;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1015, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 336;
            this.label1.Text = "Id Compteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 335;
            this.label3.Text = "Satut Paiement";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1132, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 60);
            this.button7.TabIndex = 334;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(986, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 60);
            this.button6.TabIndex = 333;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1030, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 332;
            this.label2.Text = "Montant_total ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(838, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 60);
            this.button5.TabIndex = 331;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CadetBlue;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(539, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 60);
            this.button8.TabIndex = 330;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Highlight;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(686, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 60);
            this.button10.TabIndex = 329;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // montant
            // 
            this.montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant.Location = new System.Drawing.Point(1098, 167);
            this.montant.Multiline = true;
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(300, 54);
            this.montant.TabIndex = 328;
            this.montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id_facture
            // 
            this.Id_facture.Enabled = false;
            this.Id_facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_facture.Location = new System.Drawing.Point(394, 167);
            this.Id_facture.Multiline = true;
            this.Id_facture.Name = "Id_facture";
            this.Id_facture.Size = new System.Drawing.Size(251, 41);
            this.Id_facture.TabIndex = 327;
            this.Id_facture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nompatient
            // 
            this.nompatient.AutoSize = true;
            this.nompatient.BackColor = System.Drawing.Color.Transparent;
            this.nompatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nompatient.Location = new System.Drawing.Point(702, 109);
            this.nompatient.Name = "nompatient";
            this.nompatient.Size = new System.Drawing.Size(183, 32);
            this.nompatient.TabIndex = 326;
            this.nompatient.Text = "Date_facture ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 325;
            this.label9.Text = "ID_Facture ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 42);
            this.label8.TabIndex = 324;
            this.label8.Text = "Gestion De Facture";
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(782, 573);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 34);
            this.button12.TabIndex = 345;
            this.button12.Text = "Reset";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(690, 573);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 34);
            this.button11.TabIndex = 344;
            this.button11.Text = "Search";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ID_Facturesearch
            // 
            this.ID_Facturesearch.Location = new System.Drawing.Point(556, 572);
            this.ID_Facturesearch.Multiline = true;
            this.ID_Facturesearch.Name = "ID_Facturesearch";
            this.ID_Facturesearch.Size = new System.Drawing.Size(121, 35);
            this.ID_Facturesearch.TabIndex = 343;
            this.ID_Facturesearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 342;
            this.label6.Text = "Search id Facturation ";
            // 
            // type_service
            // 
            this.type_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_service.FormattingEnabled = true;
            this.type_service.Items.AddRange(new object[] {
            "payée",
            "en attente"});
            this.type_service.Location = new System.Drawing.Point(796, 332);
            this.type_service.Name = "type_service";
            this.type_service.Size = new System.Drawing.Size(184, 33);
            this.type_service.TabIndex = 347;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 346;
            this.label5.Text = "Type Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 42);
            this.label7.TabIndex = 348;
            this.label7.Text = "List Of Facture";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1232, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 349;
            this.label10.Text = "Filter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.accueil);
            this.panel2.Controls.Add(this.lit);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.rendezvous);
            this.panel2.Controls.Add(this.medicaux);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 1021);
            this.panel2.TabIndex = 350;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
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
            this.lit.Location = new System.Drawing.Point(39, 432);
            this.lit.Name = "lit";
            this.lit.Size = new System.Drawing.Size(68, 60);
            this.lit.TabIndex = 113;
            this.lit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lit.UseVisualStyleBackColor = false;
            this.lit.Click += new System.EventHandler(this.lit_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(39, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 60);
            this.button3.TabIndex = 114;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(39, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 60);
            this.button4.TabIndex = 115;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button9.Location = new System.Drawing.Point(40, 523);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 60);
            this.button9.TabIndex = 116;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.rendezvous.Click += new System.EventHandler(this.rendezvous_Click);
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
            this.medicaux.Click += new System.EventHandler(this.medicaux_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.Location = new System.Drawing.Point(40, 867);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 60);
            this.button13.TabIndex = 120;
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
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
            this.logout.Location = new System.Drawing.Point(40, 950);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(68, 60);
            this.logout.TabIndex = 122;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 39);
            this.panel1.TabIndex = 351;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Control;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button14.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button14.Location = new System.Drawing.Point(1411, -3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(44, 39);
            this.button14.TabIndex = 150;
            this.button14.Text = "_";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(1461, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 39);
            this.close.TabIndex = 149;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1505, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.type_service);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ID_Facturesearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Id_compteur);
            this.Controls.Add(this.statut_paiement);
            this.Controls.Add(this.date_facturation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.Id_facture);
            this.Controls.Add(this.nompatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.facturedv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdCompteurSearch);
            this.Controls.Add(this.Id_quartiersear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturedv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView facturedv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdCompteurSearch;
        private System.Windows.Forms.Label Id_quartiersear;
        private System.Windows.Forms.ComboBox Id_compteur;
        private System.Windows.Forms.ComboBox statut_paiement;
        private System.Windows.Forms.DateTimePicker date_facturation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.TextBox Id_facture;
        private System.Windows.Forms.Label nompatient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox ID_Facturesearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox type_service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button lit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button rendezvous;
        private System.Windows.Forms.Button medicaux;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button close;
    }
}