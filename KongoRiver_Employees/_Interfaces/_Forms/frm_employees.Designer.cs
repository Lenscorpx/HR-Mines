namespace KongoRiver_Employees._Interfaces._Forms
{
    partial class frm_employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_coy_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_first_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_lastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_given_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_birthplace = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_province = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_territory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_sect_chef = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_district = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_village = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dt_date_birthday = new MetroFramework.Controls.MetroDateTime();
            this.cbx_etat_civil = new MetroFramework.Controls.MetroComboBox();
            this.cbx_sexe = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nationality = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_dependents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_vsr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_contract = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_driving_license = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_medical_infos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_visa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_resident_card = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_passport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_bank_details = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_nationalID = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informations about employees";
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 494);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 191);
            this.bunifuCustomDataGrid2.TabIndex = 263;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // txt_coy_ID
            // 
            this.txt_coy_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_coy_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_coy_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_coy_ID.ForeColor = System.Drawing.Color.White;
            this.txt_coy_ID.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_coy_ID.HintText = "Coy. ID";
            this.txt_coy_ID.isPassword = false;
            this.txt_coy_ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_coy_ID.LineIdleColor = System.Drawing.Color.White;
            this.txt_coy_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_coy_ID.LineThickness = 4;
            this.txt_coy_ID.Location = new System.Drawing.Point(245, 57);
            this.txt_coy_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coy_ID.Name = "txt_coy_ID";
            this.txt_coy_ID.Size = new System.Drawing.Size(256, 44);
            this.txt_coy_ID.TabIndex = 272;
            this.txt_coy_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_coy_ID.OnValueChanged += new System.EventHandler(this.txt_coy_ID_OnValueChanged);
            // 
            // txt_first_name
            // 
            this.txt_first_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_first_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_first_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_first_name.ForeColor = System.Drawing.Color.White;
            this.txt_first_name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_first_name.HintText = "Enter Firstname here";
            this.txt_first_name.isPassword = false;
            this.txt_first_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_first_name.LineIdleColor = System.Drawing.Color.White;
            this.txt_first_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_first_name.LineThickness = 4;
            this.txt_first_name.Location = new System.Drawing.Point(245, 109);
            this.txt_first_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(256, 44);
            this.txt_first_name.TabIndex = 273;
            this.txt_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_first_name.OnValueChanged += new System.EventHandler(this.txt_first_name_OnValueChanged);
            // 
            // txt_lastname
            // 
            this.txt_lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lastname.ForeColor = System.Drawing.Color.White;
            this.txt_lastname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_lastname.HintText = "Enter Last name here";
            this.txt_lastname.isPassword = false;
            this.txt_lastname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_lastname.LineIdleColor = System.Drawing.Color.White;
            this.txt_lastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_lastname.LineThickness = 4;
            this.txt_lastname.Location = new System.Drawing.Point(245, 161);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(256, 44);
            this.txt_lastname.TabIndex = 274;
            this.txt_lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_lastname.OnValueChanged += new System.EventHandler(this.txt_lastname_OnValueChanged);
            // 
            // txt_given_name
            // 
            this.txt_given_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_given_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_given_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_given_name.ForeColor = System.Drawing.Color.White;
            this.txt_given_name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_given_name.HintText = "Enter Given name here";
            this.txt_given_name.isPassword = false;
            this.txt_given_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_given_name.LineIdleColor = System.Drawing.Color.White;
            this.txt_given_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_given_name.LineThickness = 4;
            this.txt_given_name.Location = new System.Drawing.Point(245, 213);
            this.txt_given_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_given_name.Name = "txt_given_name";
            this.txt_given_name.Size = new System.Drawing.Size(256, 44);
            this.txt_given_name.TabIndex = 275;
            this.txt_given_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_given_name.OnValueChanged += new System.EventHandler(this.txt_given_name_OnValueChanged);
            // 
            // txt_birthplace
            // 
            this.txt_birthplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_birthplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_birthplace.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_birthplace.ForeColor = System.Drawing.Color.White;
            this.txt_birthplace.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_birthplace.HintText = "Enter birth place";
            this.txt_birthplace.isPassword = false;
            this.txt_birthplace.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_birthplace.LineIdleColor = System.Drawing.Color.White;
            this.txt_birthplace.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_birthplace.LineThickness = 4;
            this.txt_birthplace.Location = new System.Drawing.Point(526, 57);
            this.txt_birthplace.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthplace.Name = "txt_birthplace";
            this.txt_birthplace.Size = new System.Drawing.Size(260, 44);
            this.txt_birthplace.TabIndex = 276;
            this.txt_birthplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_province
            // 
            this.txt_province.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_province.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_province.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_province.ForeColor = System.Drawing.Color.White;
            this.txt_province.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_province.HintText = "Province";
            this.txt_province.isPassword = false;
            this.txt_province.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_province.LineIdleColor = System.Drawing.Color.White;
            this.txt_province.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_province.LineThickness = 4;
            this.txt_province.Location = new System.Drawing.Point(806, 213);
            this.txt_province.Margin = new System.Windows.Forms.Padding(4);
            this.txt_province.Name = "txt_province";
            this.txt_province.Size = new System.Drawing.Size(256, 44);
            this.txt_province.TabIndex = 277;
            this.txt_province.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_territory
            // 
            this.txt_territory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_territory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_territory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_territory.ForeColor = System.Drawing.Color.White;
            this.txt_territory.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_territory.HintText = "Territory";
            this.txt_territory.isPassword = false;
            this.txt_territory.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_territory.LineIdleColor = System.Drawing.Color.White;
            this.txt_territory.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_territory.LineThickness = 4;
            this.txt_territory.Location = new System.Drawing.Point(806, 161);
            this.txt_territory.Margin = new System.Windows.Forms.Padding(4);
            this.txt_territory.Name = "txt_territory";
            this.txt_territory.Size = new System.Drawing.Size(256, 44);
            this.txt_territory.TabIndex = 278;
            this.txt_territory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_sect_chef
            // 
            this.txt_sect_chef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_sect_chef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sect_chef.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sect_chef.ForeColor = System.Drawing.Color.White;
            this.txt_sect_chef.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sect_chef.HintText = "Sect/Cheff.";
            this.txt_sect_chef.isPassword = false;
            this.txt_sect_chef.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_sect_chef.LineIdleColor = System.Drawing.Color.White;
            this.txt_sect_chef.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_sect_chef.LineThickness = 4;
            this.txt_sect_chef.Location = new System.Drawing.Point(806, 57);
            this.txt_sect_chef.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sect_chef.Name = "txt_sect_chef";
            this.txt_sect_chef.Size = new System.Drawing.Size(256, 44);
            this.txt_sect_chef.TabIndex = 279;
            this.txt_sect_chef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_district
            // 
            this.txt_district.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_district.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_district.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_district.ForeColor = System.Drawing.Color.White;
            this.txt_district.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_district.HintText = "Enter District here";
            this.txt_district.isPassword = false;
            this.txt_district.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_district.LineIdleColor = System.Drawing.Color.White;
            this.txt_district.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_district.LineThickness = 4;
            this.txt_district.Location = new System.Drawing.Point(806, 109);
            this.txt_district.Margin = new System.Windows.Forms.Padding(4);
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(256, 44);
            this.txt_district.TabIndex = 280;
            this.txt_district.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_village
            // 
            this.txt_village.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_village.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_village.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_village.ForeColor = System.Drawing.Color.White;
            this.txt_village.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_village.HintText = "Enter Village details here";
            this.txt_village.isPassword = false;
            this.txt_village.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_village.LineIdleColor = System.Drawing.Color.White;
            this.txt_village.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_village.LineThickness = 4;
            this.txt_village.Location = new System.Drawing.Point(526, 265);
            this.txt_village.Margin = new System.Windows.Forms.Padding(4);
            this.txt_village.Name = "txt_village";
            this.txt_village.Size = new System.Drawing.Size(256, 44);
            this.txt_village.TabIndex = 281;
            this.txt_village.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dt_date_birthday
            // 
            this.dt_date_birthday.Location = new System.Drawing.Point(592, 118);
            this.dt_date_birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_birthday.Name = "dt_date_birthday";
            this.dt_date_birthday.Size = new System.Drawing.Size(194, 29);
            this.dt_date_birthday.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_birthday.TabIndex = 283;
            this.dt_date_birthday.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_etat_civil
            // 
            this.cbx_etat_civil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_etat_civil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_etat_civil.ForeColor = System.Drawing.Color.White;
            this.cbx_etat_civil.FormattingEnabled = true;
            this.cbx_etat_civil.ItemHeight = 23;
            this.cbx_etat_civil.Location = new System.Drawing.Point(588, 176);
            this.cbx_etat_civil.Name = "cbx_etat_civil";
            this.cbx_etat_civil.PromptText = "Civil Status";
            this.cbx_etat_civil.Size = new System.Drawing.Size(194, 29);
            this.cbx_etat_civil.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_etat_civil.TabIndex = 282;
            this.cbx_etat_civil.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_etat_civil.UseSelectable = true;
            // 
            // cbx_sexe
            // 
            this.cbx_sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_sexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_sexe.ForeColor = System.Drawing.Color.White;
            this.cbx_sexe.FormattingEnabled = true;
            this.cbx_sexe.ItemHeight = 23;
            this.cbx_sexe.Items.AddRange(new object[] {
            "Feminin",
            "Masculin"});
            this.cbx_sexe.Location = new System.Drawing.Point(588, 228);
            this.cbx_sexe.Name = "cbx_sexe";
            this.cbx_sexe.PromptText = "Choose gender here";
            this.cbx_sexe.Size = new System.Drawing.Size(194, 29);
            this.cbx_sexe.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_sexe.TabIndex = 284;
            this.cbx_sexe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_sexe.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 285;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(523, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 286;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(523, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 287;
            this.label4.Text = "C. St";
            // 
            // txt_nationality
            // 
            this.txt_nationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nationality.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nationality.ForeColor = System.Drawing.Color.White;
            this.txt_nationality.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nationality.HintText = "Enter Nationality here";
            this.txt_nationality.isPassword = false;
            this.txt_nationality.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nationality.LineIdleColor = System.Drawing.Color.White;
            this.txt_nationality.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_nationality.LineThickness = 4;
            this.txt_nationality.Location = new System.Drawing.Point(245, 265);
            this.txt_nationality.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nationality.Name = "txt_nationality";
            this.txt_nationality.Size = new System.Drawing.Size(256, 44);
            this.txt_nationality.TabIndex = 302;
            this.txt_nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_dependents
            // 
            this.txt_dependents.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_dependents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dependents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_dependents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_dependents.BorderRadius = 0;
            this.txt_dependents.ButtonText = "     Dependents";
            this.txt_dependents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_dependents.DisabledColor = System.Drawing.Color.Gray;
            this.txt_dependents.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dependents.ForeColor = System.Drawing.Color.White;
            this.txt_dependents.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_dependents.Iconimage = global::KongoRiver_Employees.Properties.Resources.dependants;
            this.txt_dependents.Iconimage_right = null;
            this.txt_dependents.Iconimage_right_Selected = null;
            this.txt_dependents.Iconimage_Selected = null;
            this.txt_dependents.IconMarginLeft = 0;
            this.txt_dependents.IconMarginRight = 0;
            this.txt_dependents.IconRightVisible = true;
            this.txt_dependents.IconRightZoom = 0D;
            this.txt_dependents.IconVisible = true;
            this.txt_dependents.IconZoom = 50D;
            this.txt_dependents.IsTab = true;
            this.txt_dependents.Location = new System.Drawing.Point(1098, 248);
            this.txt_dependents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_dependents.Name = "txt_dependents";
            this.txt_dependents.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_dependents.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_dependents.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_dependents.selected = false;
            this.txt_dependents.Size = new System.Drawing.Size(196, 40);
            this.txt_dependents.TabIndex = 301;
            this.txt_dependents.Text = "     Dependents";
            this.txt_dependents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_dependents.Textcolor = System.Drawing.Color.White;
            this.txt_dependents.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_vsr
            // 
            this.txt_vsr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_vsr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_vsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_vsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_vsr.BorderRadius = 0;
            this.txt_vsr.ButtonText = "     VSR";
            this.txt_vsr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_vsr.DisabledColor = System.Drawing.Color.Gray;
            this.txt_vsr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vsr.ForeColor = System.Drawing.Color.White;
            this.txt_vsr.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_vsr.Iconimage = global::KongoRiver_Employees.Properties.Resources.no_cash_104px;
            this.txt_vsr.Iconimage_right = null;
            this.txt_vsr.Iconimage_right_Selected = null;
            this.txt_vsr.Iconimage_Selected = null;
            this.txt_vsr.IconMarginLeft = 0;
            this.txt_vsr.IconMarginRight = 0;
            this.txt_vsr.IconRightVisible = true;
            this.txt_vsr.IconRightZoom = 0D;
            this.txt_vsr.IconVisible = true;
            this.txt_vsr.IconZoom = 50D;
            this.txt_vsr.IsTab = true;
            this.txt_vsr.Location = new System.Drawing.Point(1098, 443);
            this.txt_vsr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_vsr.Name = "txt_vsr";
            this.txt_vsr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_vsr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_vsr.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_vsr.selected = false;
            this.txt_vsr.Size = new System.Drawing.Size(196, 40);
            this.txt_vsr.TabIndex = 300;
            this.txt_vsr.Text = "     VSR";
            this.txt_vsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_vsr.Textcolor = System.Drawing.Color.White;
            this.txt_vsr.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_contract
            // 
            this.txt_contract.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_contract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_contract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_contract.BorderRadius = 0;
            this.txt_contract.ButtonText = "     Contracts";
            this.txt_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_contract.DisabledColor = System.Drawing.Color.Gray;
            this.txt_contract.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contract.ForeColor = System.Drawing.Color.White;
            this.txt_contract.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_contract.Iconimage = global::KongoRiver_Employees.Properties.Resources.agreement_104px;
            this.txt_contract.Iconimage_right = null;
            this.txt_contract.Iconimage_right_Selected = null;
            this.txt_contract.Iconimage_Selected = null;
            this.txt_contract.IconMarginLeft = 0;
            this.txt_contract.IconMarginRight = 0;
            this.txt_contract.IconRightVisible = true;
            this.txt_contract.IconRightZoom = 0D;
            this.txt_contract.IconVisible = true;
            this.txt_contract.IconZoom = 50D;
            this.txt_contract.IsTab = true;
            this.txt_contract.Location = new System.Drawing.Point(1098, 209);
            this.txt_contract.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_contract.Name = "txt_contract";
            this.txt_contract.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_contract.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_contract.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_contract.selected = false;
            this.txt_contract.Size = new System.Drawing.Size(196, 40);
            this.txt_contract.TabIndex = 299;
            this.txt_contract.Text = "     Contracts";
            this.txt_contract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_contract.Textcolor = System.Drawing.Color.White;
            this.txt_contract.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "     Medical Care";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::KongoRiver_Employees.Properties.Resources.medical_info;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 50D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(1098, 404);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(196, 40);
            this.bunifuFlatButton5.TabIndex = 298;
            this.bunifuFlatButton5.Text = "     Medical Care";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_driving_license
            // 
            this.txt_driving_license.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_driving_license.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_driving_license.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_driving_license.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_driving_license.BorderRadius = 0;
            this.txt_driving_license.ButtonText = "     Driving License";
            this.txt_driving_license.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_driving_license.DisabledColor = System.Drawing.Color.Gray;
            this.txt_driving_license.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_driving_license.ForeColor = System.Drawing.Color.White;
            this.txt_driving_license.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_driving_license.Iconimage = global::KongoRiver_Employees.Properties.Resources.driving_license;
            this.txt_driving_license.Iconimage_right = null;
            this.txt_driving_license.Iconimage_right_Selected = null;
            this.txt_driving_license.Iconimage_Selected = null;
            this.txt_driving_license.IconMarginLeft = 0;
            this.txt_driving_license.IconMarginRight = 0;
            this.txt_driving_license.IconRightVisible = true;
            this.txt_driving_license.IconRightZoom = 0D;
            this.txt_driving_license.IconVisible = true;
            this.txt_driving_license.IconZoom = 50D;
            this.txt_driving_license.IsTab = true;
            this.txt_driving_license.Location = new System.Drawing.Point(1098, 170);
            this.txt_driving_license.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_driving_license.Name = "txt_driving_license";
            this.txt_driving_license.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_driving_license.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_driving_license.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_driving_license.selected = false;
            this.txt_driving_license.Size = new System.Drawing.Size(196, 40);
            this.txt_driving_license.TabIndex = 297;
            this.txt_driving_license.Text = "     Driving License";
            this.txt_driving_license.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_driving_license.Textcolor = System.Drawing.Color.White;
            this.txt_driving_license.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_medical_infos
            // 
            this.txt_medical_infos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_medical_infos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_medical_infos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_medical_infos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_medical_infos.BorderRadius = 0;
            this.txt_medical_infos.ButtonText = "     Medical controls";
            this.txt_medical_infos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_medical_infos.DisabledColor = System.Drawing.Color.Gray;
            this.txt_medical_infos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medical_infos.ForeColor = System.Drawing.Color.White;
            this.txt_medical_infos.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_medical_infos.Iconimage = global::KongoRiver_Employees.Properties.Resources.medical_infos2;
            this.txt_medical_infos.Iconimage_right = null;
            this.txt_medical_infos.Iconimage_right_Selected = null;
            this.txt_medical_infos.Iconimage_Selected = null;
            this.txt_medical_infos.IconMarginLeft = 0;
            this.txt_medical_infos.IconMarginRight = 0;
            this.txt_medical_infos.IconRightVisible = true;
            this.txt_medical_infos.IconRightZoom = 0D;
            this.txt_medical_infos.IconVisible = true;
            this.txt_medical_infos.IconZoom = 50D;
            this.txt_medical_infos.IsTab = true;
            this.txt_medical_infos.Location = new System.Drawing.Point(1098, 365);
            this.txt_medical_infos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_medical_infos.Name = "txt_medical_infos";
            this.txt_medical_infos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_medical_infos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_medical_infos.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_medical_infos.selected = false;
            this.txt_medical_infos.Size = new System.Drawing.Size(196, 40);
            this.txt_medical_infos.TabIndex = 296;
            this.txt_medical_infos.Text = "     Medical controls";
            this.txt_medical_infos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_medical_infos.Textcolor = System.Drawing.Color.White;
            this.txt_medical_infos.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_visa
            // 
            this.txt_visa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_visa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_visa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_visa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_visa.BorderRadius = 0;
            this.txt_visa.ButtonText = "     Visas";
            this.txt_visa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_visa.DisabledColor = System.Drawing.Color.Gray;
            this.txt_visa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visa.ForeColor = System.Drawing.Color.White;
            this.txt_visa.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_visa.Iconimage = global::KongoRiver_Employees.Properties.Resources.visa_104px;
            this.txt_visa.Iconimage_right = null;
            this.txt_visa.Iconimage_right_Selected = null;
            this.txt_visa.Iconimage_Selected = null;
            this.txt_visa.IconMarginLeft = 0;
            this.txt_visa.IconMarginRight = 0;
            this.txt_visa.IconRightVisible = true;
            this.txt_visa.IconRightZoom = 0D;
            this.txt_visa.IconVisible = true;
            this.txt_visa.IconZoom = 50D;
            this.txt_visa.IsTab = true;
            this.txt_visa.Location = new System.Drawing.Point(1098, 131);
            this.txt_visa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_visa.Name = "txt_visa";
            this.txt_visa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_visa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_visa.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_visa.selected = false;
            this.txt_visa.Size = new System.Drawing.Size(196, 40);
            this.txt_visa.TabIndex = 295;
            this.txt_visa.Text = "     Visas";
            this.txt_visa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_visa.Textcolor = System.Drawing.Color.White;
            this.txt_visa.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visa.Click += new System.EventHandler(this.txt_visa_Click);
            // 
            // txt_resident_card
            // 
            this.txt_resident_card.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_resident_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_resident_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_resident_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_resident_card.BorderRadius = 0;
            this.txt_resident_card.ButtonText = "     Resident Cards";
            this.txt_resident_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_resident_card.DisabledColor = System.Drawing.Color.Gray;
            this.txt_resident_card.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resident_card.ForeColor = System.Drawing.Color.White;
            this.txt_resident_card.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_resident_card.Iconimage = global::KongoRiver_Employees.Properties.Resources.membership_card_104px;
            this.txt_resident_card.Iconimage_right = null;
            this.txt_resident_card.Iconimage_right_Selected = null;
            this.txt_resident_card.Iconimage_Selected = null;
            this.txt_resident_card.IconMarginLeft = 0;
            this.txt_resident_card.IconMarginRight = 0;
            this.txt_resident_card.IconRightVisible = true;
            this.txt_resident_card.IconRightZoom = 0D;
            this.txt_resident_card.IconVisible = true;
            this.txt_resident_card.IconZoom = 50D;
            this.txt_resident_card.IsTab = true;
            this.txt_resident_card.Location = new System.Drawing.Point(1098, 326);
            this.txt_resident_card.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_resident_card.Name = "txt_resident_card";
            this.txt_resident_card.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_resident_card.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_resident_card.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_resident_card.selected = false;
            this.txt_resident_card.Size = new System.Drawing.Size(196, 40);
            this.txt_resident_card.TabIndex = 294;
            this.txt_resident_card.Text = "     Resident Cards";
            this.txt_resident_card.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_resident_card.Textcolor = System.Drawing.Color.White;
            this.txt_resident_card.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_passport
            // 
            this.txt_passport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_passport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_passport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_passport.BorderRadius = 0;
            this.txt_passport.ButtonText = "     Passport";
            this.txt_passport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_passport.DisabledColor = System.Drawing.Color.Gray;
            this.txt_passport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passport.ForeColor = System.Drawing.Color.White;
            this.txt_passport.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_passport.Iconimage = global::KongoRiver_Employees.Properties.Resources.passport_104px;
            this.txt_passport.Iconimage_right = null;
            this.txt_passport.Iconimage_right_Selected = null;
            this.txt_passport.Iconimage_Selected = null;
            this.txt_passport.IconMarginLeft = 0;
            this.txt_passport.IconMarginRight = 0;
            this.txt_passport.IconRightVisible = true;
            this.txt_passport.IconRightZoom = 0D;
            this.txt_passport.IconVisible = true;
            this.txt_passport.IconZoom = 50D;
            this.txt_passport.IsTab = true;
            this.txt_passport.Location = new System.Drawing.Point(1098, 93);
            this.txt_passport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_passport.Name = "txt_passport";
            this.txt_passport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_passport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_passport.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_passport.selected = false;
            this.txt_passport.Size = new System.Drawing.Size(196, 40);
            this.txt_passport.TabIndex = 293;
            this.txt_passport.Text = "     Passport";
            this.txt_passport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_passport.Textcolor = System.Drawing.Color.White;
            this.txt_passport.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_update
            // 
            this.btn_update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.BorderRadius = 0;
            this.btn_update.ButtonText = "Update";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update.Iconimage = global::KongoRiver_Employees.Properties.Resources.add_database_104px;
            this.btn_update.Iconimage_right = null;
            this.btn_update.Iconimage_right_Selected = null;
            this.btn_update.Iconimage_Selected = null;
            this.btn_update.IconMarginLeft = 0;
            this.btn_update.IconMarginRight = 0;
            this.btn_update.IconRightVisible = true;
            this.btn_update.IconRightZoom = 0D;
            this.btn_update.IconVisible = true;
            this.btn_update.IconZoom = 50D;
            this.btn_update.IsTab = true;
            this.btn_update.Location = new System.Drawing.Point(39, 370);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update.selected = false;
            this.btn_update.Size = new System.Drawing.Size(169, 40);
            this.btn_update.TabIndex = 292;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.Textcolor = System.Drawing.Color.White;
            this.btn_update.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supprimer.BorderRadius = 0;
            this.btn_supprimer.ButtonText = "Delete";
            this.btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_supprimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_supprimer.Iconimage = global::KongoRiver_Employees.Properties.Resources.add_trash_96px;
            this.btn_supprimer.Iconimage_right = null;
            this.btn_supprimer.Iconimage_right_Selected = null;
            this.btn_supprimer.Iconimage_Selected = null;
            this.btn_supprimer.IconMarginLeft = 0;
            this.btn_supprimer.IconMarginRight = 0;
            this.btn_supprimer.IconRightVisible = true;
            this.btn_supprimer.IconRightZoom = 0D;
            this.btn_supprimer.IconVisible = true;
            this.btn_supprimer.IconZoom = 50D;
            this.btn_supprimer.IsTab = true;
            this.btn_supprimer.Location = new System.Drawing.Point(650, 370);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(169, 40);
            this.btn_supprimer.TabIndex = 291;
            this.btn_supprimer.Text = "Delete";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enregistrer.BorderRadius = 0;
            this.btn_enregistrer.ButtonText = "Save";
            this.btn_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enregistrer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_enregistrer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_enregistrer.Iconimage = global::KongoRiver_Employees.Properties.Resources.add_96px;
            this.btn_enregistrer.Iconimage_right = null;
            this.btn_enregistrer.Iconimage_right_Selected = null;
            this.btn_enregistrer.Iconimage_Selected = null;
            this.btn_enregistrer.IconMarginLeft = 0;
            this.btn_enregistrer.IconMarginRight = 0;
            this.btn_enregistrer.IconRightVisible = true;
            this.btn_enregistrer.IconRightZoom = 0D;
            this.btn_enregistrer.IconVisible = true;
            this.btn_enregistrer.IconZoom = 50D;
            this.btn_enregistrer.IsTab = true;
            this.btn_enregistrer.Location = new System.Drawing.Point(471, 370);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(169, 40);
            this.btn_enregistrer.TabIndex = 290;
            this.btn_enregistrer.Text = "Save";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // txt_bank_details
            // 
            this.txt_bank_details.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_bank_details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_bank_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_bank_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_bank_details.BorderRadius = 0;
            this.txt_bank_details.ButtonText = "     Bank Details";
            this.txt_bank_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_bank_details.DisabledColor = System.Drawing.Color.Gray;
            this.txt_bank_details.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bank_details.ForeColor = System.Drawing.Color.White;
            this.txt_bank_details.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_bank_details.Iconimage = global::KongoRiver_Employees.Properties.Resources.bank_cards_104px;
            this.txt_bank_details.Iconimage_right = null;
            this.txt_bank_details.Iconimage_right_Selected = null;
            this.txt_bank_details.Iconimage_Selected = null;
            this.txt_bank_details.IconMarginLeft = 0;
            this.txt_bank_details.IconMarginRight = 0;
            this.txt_bank_details.IconRightVisible = true;
            this.txt_bank_details.IconRightZoom = 0D;
            this.txt_bank_details.IconVisible = true;
            this.txt_bank_details.IconZoom = 50D;
            this.txt_bank_details.IsTab = true;
            this.txt_bank_details.Location = new System.Drawing.Point(1098, 287);
            this.txt_bank_details.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_bank_details.Name = "txt_bank_details";
            this.txt_bank_details.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_bank_details.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_bank_details.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_bank_details.selected = false;
            this.txt_bank_details.Size = new System.Drawing.Size(196, 40);
            this.txt_bank_details.TabIndex = 289;
            this.txt_bank_details.Text = "     Bank Details";
            this.txt_bank_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_bank_details.Textcolor = System.Drawing.Color.White;
            this.txt_bank_details.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_nationalID
            // 
            this.txt_nationalID.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nationalID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nationalID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_nationalID.BorderRadius = 0;
            this.txt_nationalID.ButtonText = "     National ID";
            this.txt_nationalID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_nationalID.DisabledColor = System.Drawing.Color.Gray;
            this.txt_nationalID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nationalID.ForeColor = System.Drawing.Color.White;
            this.txt_nationalID.Iconcolor = System.Drawing.Color.Transparent;
            this.txt_nationalID.Iconimage = global::KongoRiver_Employees.Properties.Resources.identity_card;
            this.txt_nationalID.Iconimage_right = null;
            this.txt_nationalID.Iconimage_right_Selected = null;
            this.txt_nationalID.Iconimage_Selected = null;
            this.txt_nationalID.IconMarginLeft = 0;
            this.txt_nationalID.IconMarginRight = 0;
            this.txt_nationalID.IconRightVisible = true;
            this.txt_nationalID.IconRightZoom = 0D;
            this.txt_nationalID.IconVisible = true;
            this.txt_nationalID.IconZoom = 50D;
            this.txt_nationalID.IsTab = true;
            this.txt_nationalID.Location = new System.Drawing.Point(1098, 54);
            this.txt_nationalID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_nationalID.Name = "txt_nationalID";
            this.txt_nationalID.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_nationalID.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_nationalID.OnHoverTextColor = System.Drawing.Color.White;
            this.txt_nationalID.selected = false;
            this.txt_nationalID.Size = new System.Drawing.Size(196, 40);
            this.txt_nationalID.TabIndex = 288;
            this.txt_nationalID.Text = "     National ID";
            this.txt_nationalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_nationalID.Textcolor = System.Drawing.Color.White;
            this.txt_nationalID.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::KongoRiver_Employees.Properties.Resources.add_user_male_104px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 271;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::KongoRiver_Employees.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1248, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frm_employees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 685);
            this.Controls.Add(this.txt_nationality);
            this.Controls.Add(this.txt_dependents);
            this.Controls.Add(this.txt_vsr);
            this.Controls.Add(this.txt_contract);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.txt_driving_license);
            this.Controls.Add(this.txt_medical_infos);
            this.Controls.Add(this.txt_visa);
            this.Controls.Add(this.txt_resident_card);
            this.Controls.Add(this.txt_passport);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.txt_bank_details);
            this.Controls.Add(this.txt_nationalID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_sexe);
            this.Controls.Add(this.dt_date_birthday);
            this.Controls.Add(this.cbx_etat_civil);
            this.Controls.Add(this.txt_village);
            this.Controls.Add(this.txt_district);
            this.Controls.Add(this.txt_sect_chef);
            this.Controls.Add(this.txt_territory);
            this.Controls.Add(this.txt_province);
            this.Controls.Add(this.txt_birthplace);
            this.Controls.Add(this.txt_given_name);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_first_name);
            this.Controls.Add(this.txt_coy_ID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_coy_ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_first_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_lastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_given_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_birthplace;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_province;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_territory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sect_chef;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_district;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_village;
        private MetroFramework.Controls.MetroDateTime dt_date_birthday;
        private MetroFramework.Controls.MetroComboBox cbx_etat_civil;
        private MetroFramework.Controls.MetroComboBox cbx_sexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        private Bunifu.Framework.UI.BunifuFlatButton txt_bank_details;
        private Bunifu.Framework.UI.BunifuFlatButton txt_nationalID;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update;
        private Bunifu.Framework.UI.BunifuFlatButton txt_resident_card;
        private Bunifu.Framework.UI.BunifuFlatButton txt_passport;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton txt_driving_license;
        private Bunifu.Framework.UI.BunifuFlatButton txt_medical_infos;
        private Bunifu.Framework.UI.BunifuFlatButton txt_visa;
        private Bunifu.Framework.UI.BunifuFlatButton txt_dependents;
        private Bunifu.Framework.UI.BunifuFlatButton txt_vsr;
        private Bunifu.Framework.UI.BunifuFlatButton txt_contract;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nationality;
    }
}