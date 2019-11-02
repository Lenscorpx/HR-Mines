namespace KongoRiver_Employees._Interfaces._UserControls
{
    partial class uc_affectation_site
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_affectation_site = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_id_engagement = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.txt_coy_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nom_complet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbx_job = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_site = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_affectation_site
            // 
            this.txt_affectation_site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_affectation_site.Depth = 0;
            this.txt_affectation_site.Enabled = false;
            this.txt_affectation_site.Hint = "Affectation site Id";
            this.txt_affectation_site.Location = new System.Drawing.Point(436, 114);
            this.txt_affectation_site.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_affectation_site.Name = "txt_affectation_site";
            this.txt_affectation_site.PasswordChar = '\0';
            this.txt_affectation_site.SelectedText = "";
            this.txt_affectation_site.SelectionLength = 0;
            this.txt_affectation_site.SelectionStart = 0;
            this.txt_affectation_site.Size = new System.Drawing.Size(545, 23);
            this.txt_affectation_site.TabIndex = 228;
            this.txt_affectation_site.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(297, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 19);
            this.materialLabel2.TabIndex = 224;
            this.materialLabel2.Text = "Site\'s Designation";
            // 
            // txt_id_engagement
            // 
            this.txt_id_engagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id_engagement.Depth = 0;
            this.txt_id_engagement.Enabled = false;
            this.txt_id_engagement.Hint = "Engagement ID.";
            this.txt_id_engagement.Location = new System.Drawing.Point(433, 80);
            this.txt_id_engagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id_engagement.Name = "txt_id_engagement";
            this.txt_id_engagement.PasswordChar = '\0';
            this.txt_id_engagement.SelectedText = "";
            this.txt_id_engagement.SelectionLength = 0;
            this.txt_id_engagement.SelectionStart = 0;
            this.txt_id_engagement.Size = new System.Drawing.Size(548, 23);
            this.txt_id_engagement.TabIndex = 221;
            this.txt_id_engagement.UseSystemPasswordChar = false;
            this.txt_id_engagement.TextChanged += new System.EventHandler(this.txt_id_engagement_TextChanged);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(803, 219);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(178, 33);
            this.btn_supprimer.TabIndex = 218;
            this.btn_supprimer.Text = "Delete";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(616, 219);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(178, 33);
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
            this.txt_coy_id.Location = new System.Drawing.Point(433, 47);
            this.txt_coy_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_coy_id.Name = "txt_coy_id";
            this.txt_coy_id.PasswordChar = '\0';
            this.txt_coy_id.SelectedText = "";
            this.txt_coy_id.SelectionLength = 0;
            this.txt_coy_id.SelectionStart = 0;
            this.txt_coy_id.Size = new System.Drawing.Size(548, 23);
            this.txt_coy_id.TabIndex = 216;
            this.txt_coy_id.UseSystemPasswordChar = false;
            this.txt_coy_id.TextChanged += new System.EventHandler(this.txt_coy_id_TextChanged);
            // 
            // txt_search
            // 
            this.txt_search.Depth = 0;
            this.txt_search.Hint = "Type the name to search";
            this.txt_search.Location = new System.Drawing.Point(0, 3);
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(291, 23);
            this.txt_search.TabIndex = 215;
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.TextAlignChanged += new System.EventHandler(this.txt_search_TextAlignChanged);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.txt_nom_complet);
            this.panel2.Controls.Add(this.cbx_job);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.cbx_site);
            this.panel2.Controls.Add(this.txt_affectation_site);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.txt_id_engagement);
            this.panel2.Controls.Add(this.btn_supprimer);
            this.panel2.Controls.Add(this.btn_enregistrer);
            this.panel2.Controls.Add(this.txt_coy_id);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 570);
            this.panel2.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(299, 47);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 19);
            this.materialLabel6.TabIndex = 238;
            this.materialLabel6.Text = "Coy ID.";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(302, 118);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 19);
            this.materialLabel5.TabIndex = 237;
            this.materialLabel5.Text = "Site\'s Assign ID.";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(302, 84);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 236;
            this.materialLabel3.Text = "Assignement ID";
            // 
            // txt_nom_complet
            // 
            this.txt_nom_complet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nom_complet.Depth = 0;
            this.txt_nom_complet.Enabled = false;
            this.txt_nom_complet.Hint = "Noms complets";
            this.txt_nom_complet.Location = new System.Drawing.Point(433, 14);
            this.txt_nom_complet.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nom_complet.Name = "txt_nom_complet";
            this.txt_nom_complet.PasswordChar = '\0';
            this.txt_nom_complet.SelectedText = "";
            this.txt_nom_complet.SelectionLength = 0;
            this.txt_nom_complet.SelectionStart = 0;
            this.txt_nom_complet.Size = new System.Drawing.Size(548, 23);
            this.txt_nom_complet.TabIndex = 234;
            this.txt_nom_complet.UseSystemPasswordChar = false;
            // 
            // cbx_job
            // 
            this.cbx_job.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbx_job.FormattingEnabled = true;
            this.cbx_job.ItemHeight = 19;
            this.cbx_job.Location = new System.Drawing.Point(436, 181);
            this.cbx_job.Name = "cbx_job";
            this.cbx_job.Size = new System.Drawing.Size(545, 25);
            this.cbx_job.TabIndex = 232;
            this.cbx_job.UseSelectable = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(302, 187);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 231;
            this.materialLabel4.Text = "Job Title";
            // 
            // cbx_site
            // 
            this.cbx_site.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbx_site.FormattingEnabled = true;
            this.cbx_site.ItemHeight = 19;
            this.cbx_site.Location = new System.Drawing.Point(436, 143);
            this.cbx_site.Name = "cbx_site";
            this.cbx_site.Size = new System.Drawing.Size(545, 25);
            this.cbx_site.TabIndex = 230;
            this.cbx_site.UseSelectable = true;
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
            this.listBox1.Size = new System.Drawing.Size(288, 208);
            this.listBox1.TabIndex = 214;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 306);
            this.panel1.TabIndex = 240;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(993, 306);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick_1);
            // 
            // uc_affectation_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Name = "uc_affectation_site";
            this.Size = new System.Drawing.Size(993, 570);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_affectation_site;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id_engagement;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_enregistrer;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_coy_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroComboBox cbx_site;
        private MetroFramework.Controls.MetroComboBox cbx_job;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nom_complet;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
