using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using KongoRiver_Employees._Interfaces._UserControls;
using Bunifu.Framework.UI;

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_menu : MetroForm
    {
        public frm_menu()
        {
            InitializeComponent();
            loading();
        }
        private void loading()
        {
            var fr = new uc_accueil()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuFlatButton3.Focus();
            var fr = new uc_employee()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
            bunifuFlatButton3.selected = true;
            //bunifuFlatButton1.selected = false;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton5.selected = false;
            bunifuFlatButton7.selected = false;
            //bunifuFlatButton8.selected = false;
            //bunifuFlatButton1.selected = false;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_documents();
            fr.ShowDialog();
            bunifuFlatButton2.Focus();
            bunifuFlatButton3.selected = false;
            ///*bunifuFlatButton1.sel*/ected = false;
            bunifuFlatButton2.selected = true;
            bunifuFlatButton5.selected = false;
            bunifuFlatButton7.selected = false;
            //bunifuFlatButton8.selected = false;
            //bunifuFlatButton1.selected = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuFlatButton5.Focus();
            var fr = new uc_hiring()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
            bunifuFlatButton3.selected = false;
            //bunifuFlatButton1.selected = false;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton5.selected = true;
            bunifuFlatButton7.selected = false;
            //bunifuFlatButton8.selected = false;
            //bunifuFlatButton1.selected = false;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            //bunifuFlatButton8.Focus();
            ////var fr = new frm_family();
            //fr.Show();
            //bunifuFlatButton3.selected = false;
            ////bunifuFlatButton1.selected = false;
            //bunifuFlatButton2.selected = false;
            //bunifuFlatButton5.selected = false;
            //bunifuFlatButton7.selected = false;
            //bunifuFlatButton8.selected = true;
            //bunifuFlatButton1.selected = false;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bunifuFlatButton7.Focus();
            var fr = new frm_parameters();
            fr.ShowDialog();
            bunifuFlatButton3.selected = false;
            //bunifuFlatButton1.selected = false;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton5.selected = false;
            bunifuFlatButton7.selected = true;
            //bunifuFlatButton8.selected = false;
            //bunifuFlatButton1.selected = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //bunifuFlatButton1.Focus();
            var fr = new frm_operations();
            fr.Show();

            bunifuFlatButton3.selected = false;
            //bunifuFlatButton1.selected = false;
            bunifuFlatButton2.selected = false;
            bunifuFlatButton5.selected = false;
            bunifuFlatButton7.selected = false;
            //bunifuFlatButton8.selected = false;
            //bunifuFlatButton1.selected = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuFlatButton4.Focus();
            var fr = new uc_affectation_site()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {
            bunifuFlatButton8.Focus();
            var fr = new uc_leave_in()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //bunifuFlatButton6.Focus();
            //if(bunifuFlatButton6.Focused==true)
            //{
            //    bunifuFlatButton6.ForeColor = Color.White;
            //    bunifuFlatButton6.BackColor = Color.Black;
            //}
            //var fr = new uc_leave_end()
            //{
            //    Size = panel4.Size
            //};
            //panel4.Controls.Clear();
            //panel4.Controls.Add(fr);
            //fr.Visible = false;
            //bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            //bunifuTransition1.ShowSync(fr);
            //fr.Visible = true;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            bunifuFlatButton10.Focus();
            if (bunifuFlatButton10.Focused == true)
            {
                bunifuFlatButton10.ForeColor = Color.White;
                bunifuFlatButton10.BackColor = Color.Black;
            }
            var fr = new uc_dashboard()
            {
                Size = panel4.Size
            };
            panel4.Controls.Clear();
            panel4.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }
    }
}
