namespace simofinal
{
    partial class Service_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service_Client));
            this.button1 = new System.Windows.Forms.Button();
            this.client_idsearch = new System.Windows.Forms.TextBox();
            this.Id_quartiersear = new System.Windows.Forms.Label();
            this.servicedv = new System.Windows.Forms.DataGridView();
            this.date_demande = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.description_demande = new System.Windows.Forms.TextBox();
            this.Id_service = new System.Windows.Forms.TextBox();
            this.nompatient = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statut = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_client = new System.Windows.Forms.TextBox();
            this.client_id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idserviceclient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accueil = new System.Windows.Forms.Button();
            this.lit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.rendezvous = new System.Windows.Forms.Button();
            this.medicaux = new System.Windows.Forms.Button();
            this.facture = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicedv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1317, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 302;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // client_idsearch
            // 
            this.client_idsearch.Location = new System.Drawing.Point(1166, 577);
            this.client_idsearch.Multiline = true;
            this.client_idsearch.Name = "client_idsearch";
            this.client_idsearch.Size = new System.Drawing.Size(121, 35);
            this.client_idsearch.TabIndex = 301;
            this.client_idsearch.TextChanged += new System.EventHandler(this.client_idsearch_TextChanged);
            // 
            // Id_quartiersear
            // 
            this.Id_quartiersear.AutoSize = true;
            this.Id_quartiersear.BackColor = System.Drawing.Color.Transparent;
            this.Id_quartiersear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_quartiersear.Location = new System.Drawing.Point(994, 582);
            this.Id_quartiersear.Name = "Id_quartiersear";
            this.Id_quartiersear.Size = new System.Drawing.Size(154, 25);
            this.Id_quartiersear.TabIndex = 300;
            this.Id_quartiersear.Text = "Search id center";
            this.Id_quartiersear.Click += new System.EventHandler(this.Id_quartiersear_Click);
            // 
            // servicedv
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.servicedv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.servicedv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicedv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.servicedv.BackgroundColor = System.Drawing.Color.White;
            this.servicedv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicedv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.servicedv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicedv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.servicedv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servicedv.DefaultCellStyle = dataGridViewCellStyle9;
            this.servicedv.Location = new System.Drawing.Point(201, 649);
            this.servicedv.Name = "servicedv";
            this.servicedv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.servicedv.RowTemplate.Height = 24;
            this.servicedv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.servicedv.Size = new System.Drawing.Size(1251, 366);
            this.servicedv.TabIndex = 303;
            this.servicedv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicedv_CellClick);
            this.servicedv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.quartiersDGV_CellContentClick);
            // 
            // date_demande
            // 
            this.date_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_demande.Location = new System.Drawing.Point(716, 243);
            this.date_demande.Name = "date_demande";
            this.date_demande.Size = new System.Drawing.Size(364, 30);
            this.date_demande.TabIndex = 328;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1139, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 32);
            this.label2.TabIndex = 327;
            this.label2.Text = "Historique_médical ";
            // 
            // description_demande
            // 
            this.description_demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_demande.Location = new System.Drawing.Point(1156, 208);
            this.description_demande.Multiline = true;
            this.description_demande.Name = "description_demande";
            this.description_demande.Size = new System.Drawing.Size(315, 261);
            this.description_demande.TabIndex = 326;
            // 
            // Id_service
            // 
            this.Id_service.Enabled = false;
            this.Id_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_service.Location = new System.Drawing.Point(319, 236);
            this.Id_service.Multiline = true;
            this.Id_service.Name = "Id_service";
            this.Id_service.Size = new System.Drawing.Size(248, 37);
            this.Id_service.TabIndex = 325;
            this.Id_service.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id_service.TextChanged += new System.EventHandler(this.Id_service_TextChanged);
            // 
            // nompatient
            // 
            this.nompatient.AutoSize = true;
            this.nompatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nompatient.Location = new System.Drawing.Point(666, 189);
            this.nompatient.Name = "nompatient";
            this.nompatient.Size = new System.Drawing.Size(198, 32);
            this.nompatient.TabIndex = 324;
            this.nompatient.Text = "Date_creation ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 32);
            this.label9.TabIndex = 323;
            this.label9.Text = "ID_dossier_Médical ";
            // 
            // statut
            // 
            this.statut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut.FormattingEnabled = true;
            this.statut.Items.AddRange(new object[] {
            "payée",
            "en attente"});
            this.statut.Location = new System.Drawing.Point(292, 366);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(241, 33);
            this.statut.TabIndex = 332;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 32);
            this.label3.TabIndex = 331;
            this.label3.Text = "Méthode_paiement ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 32);
            this.label4.TabIndex = 336;
            this.label4.Text = "Nom_patient";
            // 
            // name_client
            // 
            this.name_client.Location = new System.Drawing.Point(920, 352);
            this.name_client.Multiline = true;
            this.name_client.Name = "name_client";
            this.name_client.Size = new System.Drawing.Size(209, 38);
            this.name_client.TabIndex = 335;
            this.name_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // client_id
            // 
            this.client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_id.FormattingEnabled = true;
            this.client_id.Location = new System.Drawing.Point(627, 366);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(212, 33);
            this.client_id.TabIndex = 334;
            this.client_id.SelectedIndexChanged += new System.EventHandler(this.client_id_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 333;
            this.label5.Text = "ID_Patient ";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(988, 429);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 62);
            this.button7.TabIndex = 341;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(814, 429);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 62);
            this.button6.TabIndex = 340;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(653, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 62);
            this.button5.TabIndex = 339;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CadetBlue;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(323, 429);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 62);
            this.button8.TabIndex = 338;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Highlight;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(492, 429);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(77, 62);
            this.button10.TabIndex = 337;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(758, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 344;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idserviceclient
            // 
            this.idserviceclient.Location = new System.Drawing.Point(607, 581);
            this.idserviceclient.Multiline = true;
            this.idserviceclient.Name = "idserviceclient";
            this.idserviceclient.Size = new System.Drawing.Size(121, 35);
            this.idserviceclient.TabIndex = 343;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 342;
            this.label6.Text = "Search id center";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 42);
            this.label1.TabIndex = 345;
            this.label1.Text = "Gestion Service Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1161, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 346;
            this.label7.Text = "Filter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 42);
            this.label8.TabIndex = 347;
            this.label8.Text = "List Of Service Client";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.accueil);
            this.panel2.Controls.Add(this.lit);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.rendezvous);
            this.panel2.Controls.Add(this.medicaux);
            this.panel2.Controls.Add(this.facture);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 1005);
            this.panel2.TabIndex = 348;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(40, 788);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 60);
            this.button3.TabIndex = 185;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.lit.Location = new System.Drawing.Point(39, 423);
            this.lit.Name = "lit";
            this.lit.Size = new System.Drawing.Size(68, 60);
            this.lit.TabIndex = 113;
            this.lit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lit.UseVisualStyleBackColor = false;
            this.lit.Click += new System.EventHandler(this.lit_Click);
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
            this.button4.Location = new System.Drawing.Point(39, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 60);
            this.button4.TabIndex = 114;
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
            this.button9.Location = new System.Drawing.Point(39, 257);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 60);
            this.button9.TabIndex = 115;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.button11.Click += new System.EventHandler(this.button11_Click);
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
            this.facture.Click += new System.EventHandler(this.facture_Click);
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
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 39);
            this.panel1.TabIndex = 349;
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
            // Service_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1599, 1057);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idserviceclient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_client);
            this.Controls.Add(this.client_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_demande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description_demande);
            this.Controls.Add(this.Id_service);
            this.Controls.Add(this.nompatient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.servicedv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_idsearch);
            this.Controls.Add(this.Id_quartiersear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Service_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service_Client";
            this.Load += new System.EventHandler(this.Service_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicedv)).EndInit();
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
        private System.Windows.Forms.Label Id_quartiersear;
        private System.Windows.Forms.DataGridView servicedv;
        private System.Windows.Forms.DateTimePicker date_demande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description_demande;
        private System.Windows.Forms.TextBox Id_service;
        private System.Windows.Forms.Label nompatient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_client;
        private System.Windows.Forms.ComboBox client_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idserviceclient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button lit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
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