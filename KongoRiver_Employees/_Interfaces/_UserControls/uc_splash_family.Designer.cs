namespace KongoRiver_Employees._Interfaces._UserControls
{
    partial class uc_splash_family
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_titre2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(424, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 76);
            this.label3.TabIndex = 9;
            this.label3.Text = "Family";
            // 
            // lbl_titre2
            // 
            this.lbl_titre2.AutoSize = true;
            this.lbl_titre2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre2.ForeColor = System.Drawing.Color.Black;
            this.lbl_titre2.Location = new System.Drawing.Point(238, 161);
            this.lbl_titre2.Name = "lbl_titre2";
            this.lbl_titre2.Size = new System.Drawing.Size(242, 75);
            this.lbl_titre2.TabIndex = 8;
            this.lbl_titre2.Text = "Andrea";
            // 
            // uc_splash_family
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_titre2);
            this.Name = "uc_splash_family";
            this.Size = new System.Drawing.Size(814, 454);
            this.Load += new System.EventHandler(this.uc_splash_family_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_titre2;
    }
}
