namespace KongoRiver_Employees._Interfaces._UserControls
{
    partial class uc_leave_in
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

        #region Component Designer generated code

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
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_id_leave_in = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dt_expected = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dt_leavein = new MetroFramework.Controls.MetroDateTime();
            this.txt_comments = new System.Windows.Forms.RichTextBox();
            this.txt_id_engagement = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_motive = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.txt_coy_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 315);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(993, 315);
            this.bunifuCustomDataGrid1.TabIndex = 4;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.txt_id_leave_in);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.dt_expected);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.dt_leavein);
            this.panel2.Controls.Add(this.txt_comments);
            this.panel2.Controls.Add(this.txt_id_engagement);
            this.panel2.Controls.Add(this.txt_motive);
            this.panel2.Controls.Add(this.btn_supprimer);
            this.panel2.Controls.Add(this.btn_enregistrer);
            this.panel2.Controls.Add(this.txt_coy_id);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 255);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(274, 68);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 19);
            this.materialLabel4.TabIndex = 229;
            this.materialLabel4.Text = "Leave Out Motive";
            // 
            // txt_id_leave_in
            // 
            this.txt_id_leave_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id_leave_in.Depth = 0;
            this.txt_id_leave_in.Enabled = false;
            this.txt_id_leave_in.Hint = "Leave out ID.";
            this.txt_id_leave_in.Location = new System.Drawing.Point(3, 226);
            this.txt_id_leave_in.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id_leave_in.Name = "txt_id_leave_in";
            this.txt_id_leave_in.PasswordChar = '\0';
            this.txt_id_leave_in.SelectedText = "";
            this.txt_id_leave_in.SelectionLength = 0;
            this.txt_id_leave_in.SelectionStart = 0;
            this.txt_id_leave_in.Size = new System.Drawing.Size(265, 23);
            this.txt_id_leave_in.TabIndex = 228;
            this.txt_id_leave_in.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(274, 94);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(149, 19);
            this.materialLabel3.TabIndex = 227;
            this.materialLabel3.Text = "Your comments here";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(613, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 226;
            this.materialLabel1.Text = "Expected Date Leave In";
            // 
            // dt_expected
            // 
            this.dt_expected.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dt_expected.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dt_expected.Location = new System.Drawing.Point(783, 29);
            this.dt_expected.MinimumSize = new System.Drawing.Size(0, 25);
            this.dt_expected.Name = "dt_expected";
            this.dt_expected.Size = new System.Drawing.Size(206, 25);
            this.dt_expected.TabIndex = 225;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(274, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 224;
            this.materialLabel2.Text = "Date Leave out";
            // 
            // dt_leavein
            // 
            this.dt_leavein.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dt_leavein.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dt_leavein.Location = new System.Drawing.Point(401, 32);
            this.dt_leavein.MinimumSize = new System.Drawing.Size(0, 25);
            this.dt_leavein.Name = "dt_leavein";
            this.dt_leavein.Size = new System.Drawing.Size(206, 25);
            this.dt_leavein.TabIndex = 223;
            // 
            // txt_comments
            // 
            this.txt_comments.BackColor = System.Drawing.Color.White;
            this.txt_comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_comments.Location = new System.Drawing.Point(278, 116);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(708, 92);
            this.txt_comments.TabIndex = 222;
            this.txt_comments.Text = "";
            // 
            // txt_id_engagement
            // 
            this.txt_id_engagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id_engagement.Depth = 0;
            this.txt_id_engagement.Enabled = false;
            this.txt_id_engagement.Hint = "Engagement ID.";
            this.txt_id_engagement.Location = new System.Drawing.Point(623, 3);
            this.txt_id_engagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id_engagement.Name = "txt_id_engagement";
            this.txt_id_engagement.PasswordChar = '\0';
            this.txt_id_engagement.SelectedText = "";
            this.txt_id_engagement.SelectionLength = 0;
            this.txt_id_engagement.SelectionStart = 0;
            this.txt_id_engagement.Size = new System.Drawing.Size(367, 23);
            this.txt_id_engagement.TabIndex = 221;
            this.txt_id_engagement.UseSystemPasswordChar = false;
            // 
            // txt_motive
            // 
            this.txt_motive.Depth = 0;
            this.txt_motive.Hint = "Enter Leave-out Motive";
            this.txt_motive.Location = new System.Drawing.Point(403, 68);
            this.txt_motive.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_motive.Name = "txt_motive";
            this.txt_motive.PasswordChar = '\0';
            this.txt_motive.SelectedText = "";
            this.txt_motive.SelectionLength = 0;
            this.txt_motive.SelectionStart = 0;
            this.txt_motive.Size = new System.Drawing.Size(584, 23);
            this.txt_motive.TabIndex = 219;
            this.txt_motive.UseSystemPasswordChar = false;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(763, 214);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(223, 33);
            this.btn_supprimer.TabIndex = 218;
            this.btn_supprimer.Text = "Delete";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(534, 214);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(223, 33);
            this.btn_enregistrer.TabIndex = 217;
            this.btn_enregistrer.Text = "Add";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // txt_coy_id
            // 
            this.txt_coy_id.Depth = 0;
            this.txt_coy_id.Enabled = false;
            this.txt_coy_id.Hint = "Enter the coy. ID";
            this.txt_coy_id.Location = new System.Drawing.Point(274, 3);
            this.txt_coy_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_coy_id.Name = "txt_coy_id";
            this.txt_coy_id.PasswordChar = '\0';
            this.txt_coy_id.SelectedText = "";
            this.txt_coy_id.SelectionLength = 0;
            this.txt_coy_id.SelectionStart = 0;
            this.txt_coy_id.Size = new System.Drawing.Size(333, 23);
            this.txt_coy_id.TabIndex = 216;
            this.txt_coy_id.UseSystemPasswordChar = false;
            this.txt_coy_id.TextChanged += new System.EventHandler(this.txt_coy_id_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.Depth = 0;
            this.txt_search.Hint = "Type the name to search";
            this.txt_search.Location = new System.Drawing.Point(3, 4);
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(265, 23);
            this.txt_search.TabIndex = 215;
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 176);
            this.listBox1.TabIndex = 214;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // uc_leave_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_leave_in";
            this.Size = new System.Drawing.Size(993, 570);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox txt_comments;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id_engagement;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_motive;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_enregistrer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_coy_id;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroDateTime dt_expected;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroDateTime dt_leavein;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id_leave_in;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}
