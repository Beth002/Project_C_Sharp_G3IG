namespace GESTION_ADHESION_GROUP6
{
    partial class frmAdhesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdhesion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateAdhesion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNoms = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalite = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnActualiser = new Guna.UI2.WinForms.Guna2Button();
            this.dgMembres = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnationalite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgphoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listMembres = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbNoms = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSexe = new System.Windows.Forms.Label();
            this.lbNationalite = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbDateNow = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembres)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.DateAdhesion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cbSexe);
            this.groupBox1.Controls.Add(this.txtNoms);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtNationalite);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnPhoto);
            this.groupBox1.Controls.Add(this.pbPhoto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEMBRES";
            // 
            // DateAdhesion
            // 
            this.DateAdhesion.BackColor = System.Drawing.Color.Transparent;
            this.DateAdhesion.BorderRadius = 5;
            this.DateAdhesion.Checked = true;
            this.DateAdhesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateAdhesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateAdhesion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateAdhesion.Location = new System.Drawing.Point(138, 311);
            this.DateAdhesion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateAdhesion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateAdhesion.Name = "DateAdhesion";
            this.DateAdhesion.Size = new System.Drawing.Size(239, 35);
            this.DateAdhesion.TabIndex = 25;
            this.DateAdhesion.Value = new System.DateTime(2023, 3, 10, 13, 43, 11, 897);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date Adhésion";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Transparent;
            this.txtId.BorderRadius = 5;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.Enabled = false;
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(106, 29);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(101, 27);
            this.txtId.TabIndex = 23;
            // 
            // cbSexe
            // 
            this.cbSexe.BackColor = System.Drawing.Color.Transparent;
            this.cbSexe.BorderRadius = 5;
            this.cbSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSexe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSexe.ItemHeight = 30;
            this.cbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.cbSexe.Location = new System.Drawing.Point(106, 142);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(140, 36);
            this.cbSexe.TabIndex = 22;
            // 
            // txtNoms
            // 
            this.txtNoms.BackColor = System.Drawing.Color.Transparent;
            this.txtNoms.BorderRadius = 5;
            this.txtNoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoms.DefaultText = "";
            this.txtNoms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoms.Location = new System.Drawing.Point(106, 66);
            this.txtNoms.Name = "txtNoms";
            this.txtNoms.PasswordChar = '\0';
            this.txtNoms.PlaceholderText = "";
            this.txtNoms.SelectedText = "";
            this.txtNoms.Size = new System.Drawing.Size(271, 27);
            this.txtNoms.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 5;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(106, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(271, 27);
            this.txtPhone.TabIndex = 20;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.Color.Transparent;
            this.txtAdresse.BorderRadius = 5;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.DefaultText = "";
            this.txtAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.Location = new System.Drawing.Point(106, 278);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.PlaceholderText = "";
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(271, 27);
            this.txtAdresse.TabIndex = 19;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BorderRadius = 5;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(106, 236);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(271, 27);
            this.txtMail.TabIndex = 18;
            // 
            // txtNationalite
            // 
            this.txtNationalite.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalite.BorderRadius = 5;
            this.txtNationalite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalite.DefaultText = "";
            this.txtNationalite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalite.Location = new System.Drawing.Point(106, 194);
            this.txtNationalite.Name = "txtNationalite";
            this.txtNationalite.PasswordChar = '\0';
            this.txtNationalite.PlaceholderText = "";
            this.txtNationalite.SelectedText = "";
            this.txtNationalite.Size = new System.Drawing.Size(271, 27);
            this.txtNationalite.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.Location = new System.Drawing.Point(213, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Rechercher ici";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(164, 26);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnPhoto.BorderRadius = 10;
            this.btnPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhoto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.ForeColor = System.Drawing.Color.White;
            this.btnPhoto.Location = new System.Drawing.Point(425, 163);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(132, 41);
            this.btnPhoto.TabIndex = 15;
            this.btnPhoto.Text = "Choisissez une photo";
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbPhoto.Image")));
            this.pbPhoto.Location = new System.Drawing.Point(425, 25);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(132, 132);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 14;
            this.pbPhoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nationalité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Noms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BorderRadius = 10;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjouter.Location = new System.Drawing.Point(14, 402);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 37);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Enregistrer";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Transparent;
            this.btnModifier.BorderRadius = 10;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModifier.Location = new System.Drawing.Point(161, 402);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 37);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BorderRadius = 10;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupprimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupprimer.Location = new System.Drawing.Point(310, 402);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(127, 37);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.Transparent;
            this.btnActualiser.BorderRadius = 10;
            this.btnActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualiser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualiser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualiser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualiser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualiser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiser.Image")));
            this.btnActualiser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnActualiser.Location = new System.Drawing.Point(459, 402);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(127, 37);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // dgMembres
            // 
            this.dgMembres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgnoms,
            this.dgphone,
            this.dgsexe,
            this.dgnationalite,
            this.dgmail,
            this.dgadresse,
            this.dgdate,
            this.dgphoto});
            this.dgMembres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgMembres.Location = new System.Drawing.Point(14, 446);
            this.dgMembres.Name = "dgMembres";
            this.dgMembres.Size = new System.Drawing.Size(988, 212);
            this.dgMembres.TabIndex = 5;
            this.dgMembres.DoubleClick += new System.EventHandler(this.dgMembres_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "Id";
            this.dgid.HeaderText = "CODE";
            this.dgid.Name = "dgid";
            // 
            // dgnoms
            // 
            this.dgnoms.DataPropertyName = "Noms";
            this.dgnoms.HeaderText = "NOMS";
            this.dgnoms.Name = "dgnoms";
            // 
            // dgphone
            // 
            this.dgphone.DataPropertyName = "Telephone";
            this.dgphone.HeaderText = "TELEPHONE";
            this.dgphone.Name = "dgphone";
            // 
            // dgsexe
            // 
            this.dgsexe.DataPropertyName = "Sexe";
            this.dgsexe.HeaderText = "SEXE";
            this.dgsexe.Name = "dgsexe";
            // 
            // dgnationalite
            // 
            this.dgnationalite.DataPropertyName = "Nationalite";
            this.dgnationalite.HeaderText = "NATIONALITE";
            this.dgnationalite.Name = "dgnationalite";
            // 
            // dgmail
            // 
            this.dgmail.DataPropertyName = "Mail";
            this.dgmail.HeaderText = "MAIL";
            this.dgmail.Name = "dgmail";
            // 
            // dgadresse
            // 
            this.dgadresse.DataPropertyName = "Adresse";
            this.dgadresse.HeaderText = "ADRESSE";
            this.dgadresse.Name = "dgadresse";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "DateAdhesion";
            this.dgdate.HeaderText = "DATE ADHESION";
            this.dgdate.Name = "dgdate";
            // 
            // dgphoto
            // 
            this.dgphoto.DataPropertyName = "Photo";
            this.dgphoto.HeaderText = "PHOTO";
            this.dgphoto.Name = "dgphoto";
            // 
            // listMembres
            // 
            this.listMembres.Location = new System.Drawing.Point(591, 12);
            this.listMembres.Name = "listMembres";
            this.listMembres.Size = new System.Drawing.Size(411, 427);
            this.listMembres.TabIndex = 6;
            this.listMembres.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("28 Days Later", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 42);
            this.label9.TabIndex = 7;
            this.label9.Text = "ADHESION GROUPE 6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(592, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(409, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "===================================================================";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(592, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(409, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "===================================================================";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(592, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(409, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "===================================================================";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(595, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(403, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tout droit réservé au Groupe 6 | +243 974 177 011 © G3IG-Mars 2023";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(610, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Date Adhésion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(610, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Adresse      :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(610, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 19);
            this.label16.TabIndex = 31;
            this.label16.Text = "Mail         :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(610, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 19);
            this.label17.TabIndex = 30;
            this.label17.Text = "Nationalité  :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(610, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 19);
            this.label18.TabIndex = 29;
            this.label18.Text = "Sexe         :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(610, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 19);
            this.label19.TabIndex = 28;
            this.label19.Text = "Téléphone    :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(610, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 19);
            this.label20.TabIndex = 27;
            this.label20.Text = "Noms         :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(610, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 19);
            this.label21.TabIndex = 26;
            this.label21.Text = "Code         :";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.BackColor = System.Drawing.SystemColors.Control;
            this.lbCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(751, 87);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 19);
            this.lbCode.TabIndex = 34;
            // 
            // lbNoms
            // 
            this.lbNoms.AutoSize = true;
            this.lbNoms.BackColor = System.Drawing.SystemColors.Control;
            this.lbNoms.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoms.Location = new System.Drawing.Point(751, 116);
            this.lbNoms.Name = "lbNoms";
            this.lbNoms.Size = new System.Drawing.Size(0, 19);
            this.lbNoms.TabIndex = 35;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lbPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(751, 151);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 19);
            this.lbPhone.TabIndex = 36;
            // 
            // lbSexe
            // 
            this.lbSexe.AutoSize = true;
            this.lbSexe.BackColor = System.Drawing.SystemColors.Control;
            this.lbSexe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexe.Location = new System.Drawing.Point(751, 185);
            this.lbSexe.Name = "lbSexe";
            this.lbSexe.Size = new System.Drawing.Size(0, 19);
            this.lbSexe.TabIndex = 37;
            // 
            // lbNationalite
            // 
            this.lbNationalite.AutoSize = true;
            this.lbNationalite.BackColor = System.Drawing.SystemColors.Control;
            this.lbNationalite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalite.Location = new System.Drawing.Point(751, 221);
            this.lbNationalite.Name = "lbNationalite";
            this.lbNationalite.Size = new System.Drawing.Size(0, 19);
            this.lbNationalite.TabIndex = 38;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.BackColor = System.Drawing.SystemColors.Control;
            this.lbMail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(751, 257);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(0, 19);
            this.lbMail.TabIndex = 39;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.lbAdresse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(751, 299);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(0, 19);
            this.lbAdresse.TabIndex = 40;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(751, 331);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 19);
            this.lbDate.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(752, 372);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Fait à Goma, Le";
            // 
            // lbDateNow
            // 
            this.lbDateNow.AutoSize = true;
            this.lbDateNow.BackColor = System.Drawing.Color.White;
            this.lbDateNow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateNow.Location = new System.Drawing.Point(849, 372);
            this.lbDateNow.Name = "lbDateNow";
            this.lbDateNow.Size = new System.Drawing.Size(0, 13);
            this.lbDateNow.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(752, 385);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Par El-Bethel KAMI";
            // 
            // frmAdhesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 667);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lbDateNow);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbNationalite);
            this.Controls.Add(this.lbSexe);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbNoms);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listMembres);
            this.Controls.Add(this.dgMembres);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdhesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADHESION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdhesion_FormClosing);
            this.Load += new System.EventHandler(this.frmAdhesion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2Button btnPhoto;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnActualiser;
        private System.Windows.Forms.DataGridView dgMembres;
        private System.Windows.Forms.ListView listMembres;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2ComboBox cbSexe;
        private Guna.UI2.WinForms.Guna2TextBox txtNoms;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAdresse;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalite;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateAdhesion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbNoms;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbSexe;
        private System.Windows.Forms.Label lbNationalite;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDateNow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnationalite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgphoto;
    }
}