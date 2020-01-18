namespace KongoRiver_Employees._Interfaces._Forms
{
    partial class frm_home
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fermer = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_admin = new System.Windows.Forms.Panel();
            this.btn_settings = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_reports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_rr = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_flights = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_leave = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_sites = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_employees = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fermer)).BeginInit();
            this.pnl_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_fermer);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 54);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::KongoRiver_Employees.Properties.Resources.home;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(43, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Andrea - Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_fermer, BunifuAnimatorNS.DecorationType.None);
            this.btn_fermer.Image = global::KongoRiver_Employees.Properties.Resources.Fermer_window;
            this.btn_fermer.ImageActive = null;
            this.btn_fermer.Location = new System.Drawing.Point(1256, 3);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(57, 48);
            this.btn_fermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_fermer.TabIndex = 1;
            this.btn_fermer.TabStop = false;
            this.btn_fermer.Zoom = 10;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnl_admin
            // 
            this.pnl_admin.Controls.Add(this.btn_settings);
            this.pnl_admin.Controls.Add(this.btn_reports);
            this.pnl_admin.Controls.Add(this.btn_rr);
            this.pnl_admin.Controls.Add(this.btn_flights);
            this.pnl_admin.Controls.Add(this.btn_leave);
            this.pnl_admin.Controls.Add(this.btn_sites);
            this.pnl_admin.Controls.Add(this.btn_employees);
            this.pnl_admin.Controls.Add(this.btn_dashboard);
            this.bunifuTransition1.SetDecoration(this.pnl_admin, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.pnl_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_admin.Location = new System.Drawing.Point(0, 54);
            this.pnl_admin.Name = "pnl_admin";
            this.pnl_admin.Size = new System.Drawing.Size(1316, 627);
            this.pnl_admin.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_settings.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_settings.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_settings, BunifuAnimatorNS.DecorationType.None);
            this.btn_settings.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::KongoRiver_Employees.Properties.Resources.settings_3_96px;
            this.btn_settings.ImagePosition = 22;
            this.btn_settings.ImageZoom = 50;
            this.btn_settings.LabelPosition = 44;
            this.btn_settings.LabelText = "Settings";
            this.btn_settings.Location = new System.Drawing.Point(1013, 347);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(244, 190);
            this.btn_settings.TabIndex = 16;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_reports.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_reports.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_reports, BunifuAnimatorNS.DecorationType.None);
            this.btn_reports.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Image = global::KongoRiver_Employees.Properties.Resources.reports;
            this.btn_reports.ImagePosition = 22;
            this.btn_reports.ImageZoom = 50;
            this.btn_reports.LabelPosition = 44;
            this.btn_reports.LabelText = "Reports";
            this.btn_reports.Location = new System.Drawing.Point(694, 347);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(244, 190);
            this.btn_reports.TabIndex = 15;
            // 
            // btn_rr
            // 
            this.btn_rr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rr.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rr.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_rr, BunifuAnimatorNS.DecorationType.None);
            this.btn_rr.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_rr.ForeColor = System.Drawing.Color.White;
            this.btn_rr.Image = global::KongoRiver_Employees.Properties.Resources.rr;
            this.btn_rr.ImagePosition = 22;
            this.btn_rr.ImageZoom = 50;
            this.btn_rr.LabelPosition = 44;
            this.btn_rr.LabelText = "R.R Management";
            this.btn_rr.Location = new System.Drawing.Point(378, 347);
            this.btn_rr.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_rr.Name = "btn_rr";
            this.btn_rr.Size = new System.Drawing.Size(244, 190);
            this.btn_rr.TabIndex = 14;
            // 
            // btn_flights
            // 
            this.btn_flights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_flights.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_flights.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_flights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_flights, BunifuAnimatorNS.DecorationType.None);
            this.btn_flights.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_flights.ForeColor = System.Drawing.Color.White;
            this.btn_flights.Image = global::KongoRiver_Employees.Properties.Resources.flight;
            this.btn_flights.ImagePosition = 22;
            this.btn_flights.ImageZoom = 50;
            this.btn_flights.LabelPosition = 44;
            this.btn_flights.LabelText = "Flights";
            this.btn_flights.Location = new System.Drawing.Point(59, 347);
            this.btn_flights.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_flights.Name = "btn_flights";
            this.btn_flights.Size = new System.Drawing.Size(244, 190);
            this.btn_flights.TabIndex = 13;
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_leave.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_leave.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_leave, BunifuAnimatorNS.DecorationType.None);
            this.btn_leave.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_leave.ForeColor = System.Drawing.Color.White;
            this.btn_leave.Image = global::KongoRiver_Employees.Properties.Resources.leave;
            this.btn_leave.ImagePosition = 22;
            this.btn_leave.ImageZoom = 50;
            this.btn_leave.LabelPosition = 44;
            this.btn_leave.LabelText = "Leaves";
            this.btn_leave.Location = new System.Drawing.Point(1013, 89);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(244, 190);
            this.btn_leave.TabIndex = 12;
            // 
            // btn_sites
            // 
            this.btn_sites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_sites.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_sites.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_sites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_sites, BunifuAnimatorNS.DecorationType.None);
            this.btn_sites.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_sites.ForeColor = System.Drawing.Color.White;
            this.btn_sites.Image = global::KongoRiver_Employees.Properties.Resources.sites_localisation;
            this.btn_sites.ImagePosition = 22;
            this.btn_sites.ImageZoom = 50;
            this.btn_sites.LabelPosition = 44;
            this.btn_sites.LabelText = "Sites";
            this.btn_sites.Location = new System.Drawing.Point(694, 89);
            this.btn_sites.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_sites.Name = "btn_sites";
            this.btn_sites.Size = new System.Drawing.Size(244, 190);
            this.btn_sites.TabIndex = 11;
            this.btn_sites.Click += new System.EventHandler(this.btn_sites_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_employees.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_employees.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_employees, BunifuAnimatorNS.DecorationType.None);
            this.btn_employees.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_employees.ForeColor = System.Drawing.Color.White;
            this.btn_employees.Image = global::KongoRiver_Employees.Properties.Resources.employees;
            this.btn_employees.ImagePosition = 22;
            this.btn_employees.ImageZoom = 50;
            this.btn_employees.LabelPosition = 44;
            this.btn_employees.LabelText = "Employees";
            this.btn_employees.Location = new System.Drawing.Point(378, 89);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(244, 190);
            this.btn_employees.TabIndex = 10;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_dashboard.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_dashboard.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_dashboard, BunifuAnimatorNS.DecorationType.None);
            this.btn_dashboard.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::KongoRiver_Employees.Properties.Resources.dashboard;
            this.btn_dashboard.ImagePosition = 22;
            this.btn_dashboard.ImageZoom = 50;
            this.btn_dashboard.LabelPosition = 44;
            this.btn_dashboard.LabelText = "Dashboard";
            this.btn_dashboard.Location = new System.Drawing.Point(59, 89);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(244, 190);
            this.btn_dashboard.TabIndex = 9;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 20;
            // 
            // frm_home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1316, 681);
            this.Controls.Add(this.pnl_admin);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_home";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fermer)).EndInit();
            this.pnl_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btn_fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_admin;
        private Bunifu.Framework.UI.BunifuTileButton btn_settings;
        private Bunifu.Framework.UI.BunifuTileButton btn_reports;
        private Bunifu.Framework.UI.BunifuTileButton btn_rr;
        private Bunifu.Framework.UI.BunifuTileButton btn_flights;
        private Bunifu.Framework.UI.BunifuTileButton btn_leave;
        private Bunifu.Framework.UI.BunifuTileButton btn_sites;
        private Bunifu.Framework.UI.BunifuTileButton btn_employees;
        private Bunifu.Framework.UI.BunifuTileButton btn_dashboard;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}