namespace KongoRiver_Employees._Interfaces._Forms
{
    partial class frm_contracts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_coy_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_noms = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_id_engagement = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_telephone_1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_telephone_2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbx_type_contract = new MetroFramework.Controls.MetroComboBox();
            this.dt_date_birthday = new MetroFramework.Controls.MetroDateTime();
            this.cbx_etat_civil = new MetroFramework.Controls.MetroComboBox();
            this.cbx_status_employee = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_adress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Social_number = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_leaves = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_supervisor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_flight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_affectation_site = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_rr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informations about contracts";
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
            this.txt_coy_ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_coy_ID.LineIdleColor = System.Drawing.Color.White;
            this.txt_coy_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_coy_ID.LineThickness = 4;
            this.txt_coy_ID.Location = new System.Drawing.Point(13, 107);
            this.txt_coy_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coy_ID.Name = "txt_coy_ID";
            this.txt_coy_ID.Size = new System.Drawing.Size(453, 44);
            this.txt_coy_ID.TabIndex = 273;
            this.txt_coy_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_noms
            // 
            this.txt_noms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_noms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms.ForeColor = System.Drawing.Color.White;
            this.txt_noms.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms.HintText = "Complete full name here";
            this.txt_noms.isPassword = false;
            this.txt_noms.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms.LineThickness = 4;
            this.txt_noms.Location = new System.Drawing.Point(13, 159);
            this.txt_noms.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms.Name = "txt_noms";
            this.txt_noms.Size = new System.Drawing.Size(453, 44);
            this.txt_noms.TabIndex = 274;
            this.txt_noms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_id_engagement
            // 
            this.txt_id_engagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_id_engagement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_engagement.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_engagement.ForeColor = System.Drawing.Color.White;
            this.txt_id_engagement.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_engagement.HintText = "Enter Engagement ID here";
            this.txt_id_engagement.isPassword = false;
            this.txt_id_engagement.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_engagement.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_engagement.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_engagement.LineThickness = 4;
            this.txt_id_engagement.Location = new System.Drawing.Point(13, 55);
            this.txt_id_engagement.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_engagement.Name = "txt_id_engagement";
            this.txt_id_engagement.Size = new System.Drawing.Size(453, 44);
            this.txt_id_engagement.TabIndex = 275;
            this.txt_id_engagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_telephone_1
            // 
            this.txt_telephone_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_telephone_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone_1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone_1.ForeColor = System.Drawing.Color.White;
            this.txt_telephone_1.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telephone_1.HintText = "Enter Mobile Number 1";
            this.txt_telephone_1.isPassword = false;
            this.txt_telephone_1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone_1.LineIdleColor = System.Drawing.Color.White;
            this.txt_telephone_1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone_1.LineThickness = 4;
            this.txt_telephone_1.Location = new System.Drawing.Point(13, 220);
            this.txt_telephone_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone_1.Name = "txt_telephone_1";
            this.txt_telephone_1.Size = new System.Drawing.Size(453, 44);
            this.txt_telephone_1.TabIndex = 276;
            this.txt_telephone_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_telephone_2
            // 
            this.txt_telephone_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_telephone_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone_2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone_2.ForeColor = System.Drawing.Color.White;
            this.txt_telephone_2.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telephone_2.HintText = "Enter Mobile Phone 2 here!";
            this.txt_telephone_2.isPassword = false;
            this.txt_telephone_2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone_2.LineIdleColor = System.Drawing.Color.White;
            this.txt_telephone_2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone_2.LineThickness = 4;
            this.txt_telephone_2.Location = new System.Drawing.Point(13, 272);
            this.txt_telephone_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone_2.Name = "txt_telephone_2";
            this.txt_telephone_2.Size = new System.Drawing.Size(453, 44);
            this.txt_telephone_2.TabIndex = 277;
            this.txt_telephone_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbx_type_contract
            // 
            this.cbx_type_contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_type_contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_type_contract.ForeColor = System.Drawing.Color.White;
            this.cbx_type_contract.FormattingEnabled = true;
            this.cbx_type_contract.ItemHeight = 23;
            this.cbx_type_contract.Location = new System.Drawing.Point(628, 122);
            this.cbx_type_contract.Name = "cbx_type_contract";
            this.cbx_type_contract.PromptText = "Choose contract\'s type here";
            this.cbx_type_contract.Size = new System.Drawing.Size(221, 29);
            this.cbx_type_contract.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_type_contract.TabIndex = 287;
            this.cbx_type_contract.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_type_contract.UseSelectable = true;
            // 
            // dt_date_birthday
            // 
            this.dt_date_birthday.Location = new System.Drawing.Point(628, 237);
            this.dt_date_birthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_birthday.Name = "dt_date_birthday";
            this.dt_date_birthday.Size = new System.Drawing.Size(221, 29);
            this.dt_date_birthday.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_birthday.TabIndex = 286;
            this.dt_date_birthday.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_etat_civil
            // 
            this.cbx_etat_civil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_etat_civil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_etat_civil.ForeColor = System.Drawing.Color.White;
            this.cbx_etat_civil.FormattingEnabled = true;
            this.cbx_etat_civil.ItemHeight = 23;
            this.cbx_etat_civil.Location = new System.Drawing.Point(628, 74);
            this.cbx_etat_civil.Name = "cbx_etat_civil";
            this.cbx_etat_civil.PromptText = "Civil Status";
            this.cbx_etat_civil.Size = new System.Drawing.Size(221, 29);
            this.cbx_etat_civil.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_etat_civil.TabIndex = 285;
            this.cbx_etat_civil.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_etat_civil.UseSelectable = true;
            // 
            // cbx_status_employee
            // 
            this.cbx_status_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_status_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_status_employee.ForeColor = System.Drawing.Color.White;
            this.cbx_status_employee.FormattingEnabled = true;
            this.cbx_status_employee.ItemHeight = 23;
            this.cbx_status_employee.Location = new System.Drawing.Point(628, 175);
            this.cbx_status_employee.Name = "cbx_status_employee";
            this.cbx_status_employee.PromptText = "Choose employee\'s status";
            this.cbx_status_employee.Size = new System.Drawing.Size(221, 29);
            this.cbx_status_employee.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_status_employee.TabIndex = 290;
            this.cbx_status_employee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_status_employee.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(628, 291);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(221, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroDateTime1.TabIndex = 289;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle18;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 375);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.ShowEditingIcon = false;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 310);
            this.bunifuCustomDataGrid2.TabIndex = 291;
            // 
            // txt_adress
            // 
            this.txt_adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adress.ForeColor = System.Drawing.Color.White;
            this.txt_adress.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_adress.HintText = "Enter Addresses here!";
            this.txt_adress.isPassword = false;
            this.txt_adress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_adress.LineIdleColor = System.Drawing.Color.White;
            this.txt_adress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_adress.LineThickness = 4;
            this.txt_adress.Location = new System.Drawing.Point(13, 324);
            this.txt_adress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(453, 44);
            this.txt_adress.TabIndex = 306;
            this.txt_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(498, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 307;
            this.label2.Text = "Civil Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(498, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 308;
            this.label3.Text = "Contract Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(498, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 309;
            this.label4.Text = "Status Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(498, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 310;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(498, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 311;
            this.label6.Text = "End Date";
            // 
            // btn_Social_number
            // 
            this.btn_Social_number.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_Social_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Social_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_Social_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Social_number.BorderRadius = 0;
            this.btn_Social_number.ButtonText = "     Social Number";
            this.btn_Social_number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Social_number.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Social_number.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Social_number.ForeColor = System.Drawing.Color.White;
            this.btn_Social_number.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Social_number.Iconimage = global::KongoRiver_Employees.Properties.Resources.loyalty_104px;
            this.btn_Social_number.Iconimage_right = null;
            this.btn_Social_number.Iconimage_right_Selected = null;
            this.btn_Social_number.Iconimage_Selected = null;
            this.btn_Social_number.IconMarginLeft = 0;
            this.btn_Social_number.IconMarginRight = 0;
            this.btn_Social_number.IconRightVisible = true;
            this.btn_Social_number.IconRightZoom = 0D;
            this.btn_Social_number.IconVisible = true;
            this.btn_Social_number.IconZoom = 50D;
            this.btn_Social_number.IsTab = true;
            this.btn_Social_number.Location = new System.Drawing.Point(1098, 261);
            this.btn_Social_number.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Social_number.Name = "btn_Social_number";
            this.btn_Social_number.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_Social_number.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_Social_number.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Social_number.selected = false;
            this.btn_Social_number.Size = new System.Drawing.Size(196, 40);
            this.btn_Social_number.TabIndex = 305;
            this.btn_Social_number.Text = "     Social Number";
            this.btn_Social_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Social_number.Textcolor = System.Drawing.Color.White;
            this.btn_Social_number.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_leaves
            // 
            this.btn_leaves.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_leaves.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_leaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_leaves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leaves.BorderRadius = 0;
            this.btn_leaves.ButtonText = "     Leaves";
            this.btn_leaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leaves.DisabledColor = System.Drawing.Color.Gray;
            this.btn_leaves.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leaves.ForeColor = System.Drawing.Color.White;
            this.btn_leaves.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_leaves.Iconimage = global::KongoRiver_Employees.Properties.Resources.trekking_104px;
            this.btn_leaves.Iconimage_right = null;
            this.btn_leaves.Iconimage_right_Selected = null;
            this.btn_leaves.Iconimage_Selected = null;
            this.btn_leaves.IconMarginLeft = 0;
            this.btn_leaves.IconMarginRight = 0;
            this.btn_leaves.IconRightVisible = true;
            this.btn_leaves.IconRightZoom = 0D;
            this.btn_leaves.IconVisible = true;
            this.btn_leaves.IconZoom = 50D;
            this.btn_leaves.IsTab = true;
            this.btn_leaves.Location = new System.Drawing.Point(1098, 214);
            this.btn_leaves.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_leaves.Name = "btn_leaves";
            this.btn_leaves.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_leaves.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_leaves.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_leaves.selected = false;
            this.btn_leaves.Size = new System.Drawing.Size(196, 40);
            this.btn_leaves.TabIndex = 304;
            this.btn_leaves.Text = "     Leaves";
            this.btn_leaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leaves.Textcolor = System.Drawing.Color.White;
            this.btn_leaves.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_supervisor
            // 
            this.btn_supervisor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supervisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supervisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supervisor.BorderRadius = 0;
            this.btn_supervisor.ButtonText = "     Supervisors";
            this.btn_supervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supervisor.DisabledColor = System.Drawing.Color.Gray;
            this.btn_supervisor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supervisor.ForeColor = System.Drawing.Color.White;
            this.btn_supervisor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_supervisor.Iconimage = global::KongoRiver_Employees.Properties.Resources.worker_104px;
            this.btn_supervisor.Iconimage_right = null;
            this.btn_supervisor.Iconimage_right_Selected = null;
            this.btn_supervisor.Iconimage_Selected = null;
            this.btn_supervisor.IconMarginLeft = 0;
            this.btn_supervisor.IconMarginRight = 0;
            this.btn_supervisor.IconRightVisible = true;
            this.btn_supervisor.IconRightZoom = 0D;
            this.btn_supervisor.IconVisible = true;
            this.btn_supervisor.IconZoom = 50D;
            this.btn_supervisor.IsTab = true;
            this.btn_supervisor.Location = new System.Drawing.Point(1098, 175);
            this.btn_supervisor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supervisor.Name = "btn_supervisor";
            this.btn_supervisor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supervisor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supervisor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supervisor.selected = false;
            this.btn_supervisor.Size = new System.Drawing.Size(196, 40);
            this.btn_supervisor.TabIndex = 303;
            this.btn_supervisor.Text = "     Supervisors";
            this.btn_supervisor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supervisor.Textcolor = System.Drawing.Color.White;
            this.btn_supervisor.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_flight
            // 
            this.btn_flight.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_flight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_flight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_flight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_flight.BorderRadius = 0;
            this.btn_flight.ButtonText = "     Flights";
            this.btn_flight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flight.DisabledColor = System.Drawing.Color.Gray;
            this.btn_flight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flight.ForeColor = System.Drawing.Color.White;
            this.btn_flight.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_flight.Iconimage = global::KongoRiver_Employees.Properties.Resources.flight1;
            this.btn_flight.Iconimage_right = null;
            this.btn_flight.Iconimage_right_Selected = null;
            this.btn_flight.Iconimage_Selected = null;
            this.btn_flight.IconMarginLeft = 0;
            this.btn_flight.IconMarginRight = 0;
            this.btn_flight.IconRightVisible = true;
            this.btn_flight.IconRightZoom = 0D;
            this.btn_flight.IconVisible = true;
            this.btn_flight.IconZoom = 50D;
            this.btn_flight.IsTab = true;
            this.btn_flight.Location = new System.Drawing.Point(1098, 136);
            this.btn_flight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_flight.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_flight.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_flight.selected = false;
            this.btn_flight.Size = new System.Drawing.Size(196, 40);
            this.btn_flight.TabIndex = 302;
            this.btn_flight.Text = "     Flights";
            this.btn_flight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_flight.Textcolor = System.Drawing.Color.White;
            this.btn_flight.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_affectation_site
            // 
            this.btn_affectation_site.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_affectation_site.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_affectation_site.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_affectation_site.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_affectation_site.BorderRadius = 0;
            this.btn_affectation_site.ButtonText = "     Affectation site";
            this.btn_affectation_site.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_affectation_site.DisabledColor = System.Drawing.Color.Gray;
            this.btn_affectation_site.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_affectation_site.ForeColor = System.Drawing.Color.White;
            this.btn_affectation_site.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_affectation_site.Iconimage = global::KongoRiver_Employees.Properties.Resources.assignment;
            this.btn_affectation_site.Iconimage_right = null;
            this.btn_affectation_site.Iconimage_right_Selected = null;
            this.btn_affectation_site.Iconimage_Selected = null;
            this.btn_affectation_site.IconMarginLeft = 0;
            this.btn_affectation_site.IconMarginRight = 0;
            this.btn_affectation_site.IconRightVisible = true;
            this.btn_affectation_site.IconRightZoom = 0D;
            this.btn_affectation_site.IconVisible = true;
            this.btn_affectation_site.IconZoom = 50D;
            this.btn_affectation_site.IsTab = true;
            this.btn_affectation_site.Location = new System.Drawing.Point(1098, 98);
            this.btn_affectation_site.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_affectation_site.Name = "btn_affectation_site";
            this.btn_affectation_site.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_affectation_site.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_affectation_site.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_affectation_site.selected = false;
            this.btn_affectation_site.Size = new System.Drawing.Size(196, 40);
            this.btn_affectation_site.TabIndex = 301;
            this.btn_affectation_site.Text = "     Affectation site";
            this.btn_affectation_site.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_affectation_site.Textcolor = System.Drawing.Color.White;
            this.btn_affectation_site.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_rr
            // 
            this.btn_rr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rr.BorderRadius = 0;
            this.btn_rr.ButtonText = "     RR";
            this.btn_rr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rr.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rr.ForeColor = System.Drawing.Color.White;
            this.btn_rr.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rr.Iconimage = global::KongoRiver_Employees.Properties.Resources.sheriff_104px;
            this.btn_rr.Iconimage_right = null;
            this.btn_rr.Iconimage_right_Selected = null;
            this.btn_rr.Iconimage_Selected = null;
            this.btn_rr.IconMarginLeft = 0;
            this.btn_rr.IconMarginRight = 0;
            this.btn_rr.IconRightVisible = true;
            this.btn_rr.IconRightZoom = 0D;
            this.btn_rr.IconVisible = true;
            this.btn_rr.IconZoom = 50D;
            this.btn_rr.IsTab = true;
            this.btn_rr.Location = new System.Drawing.Point(1098, 59);
            this.btn_rr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_rr.Name = "btn_rr";
            this.btn_rr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rr.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rr.selected = false;
            this.btn_rr.Size = new System.Drawing.Size(196, 40);
            this.btn_rr.TabIndex = 300;
            this.btn_rr.Text = "     RR";
            this.btn_rr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rr.Textcolor = System.Drawing.Color.White;
            this.btn_rr.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_supprimer.Location = new System.Drawing.Point(875, 126);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(169, 40);
            this.btn_supprimer.TabIndex = 293;
            this.btn_supprimer.Text = "Delete";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_enregistrer.Location = new System.Drawing.Point(875, 74);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(169, 40);
            this.btn_enregistrer.TabIndex = 292;
            this.btn_enregistrer.Text = "Save";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frm_contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 685);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.btn_Social_number);
            this.Controls.Add(this.btn_leaves);
            this.Controls.Add(this.btn_supervisor);
            this.Controls.Add(this.btn_flight);
            this.Controls.Add(this.btn_affectation_site);
            this.Controls.Add(this.btn_rr);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.cbx_status_employee);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.cbx_type_contract);
            this.Controls.Add(this.dt_date_birthday);
            this.Controls.Add(this.cbx_etat_civil);
            this.Controls.Add(this.txt_telephone_2);
            this.Controls.Add(this.txt_telephone_1);
            this.Controls.Add(this.txt_id_engagement);
            this.Controls.Add(this.txt_noms);
            this.Controls.Add(this.txt_coy_ID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_contracts";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_engagement;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone_1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone_2;
        private MetroFramework.Controls.MetroComboBox cbx_type_contract;
        private MetroFramework.Controls.MetroDateTime dt_date_birthday;
        private MetroFramework.Controls.MetroComboBox cbx_etat_civil;
        private MetroFramework.Controls.MetroComboBox cbx_status_employee;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_leaves;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supervisor;
        private Bunifu.Framework.UI.BunifuFlatButton btn_flight;
        private Bunifu.Framework.UI.BunifuFlatButton btn_affectation_site;
        private Bunifu.Framework.UI.BunifuFlatButton btn_rr;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Social_number;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_coy_ID;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}