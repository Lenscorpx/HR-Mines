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

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_operations : MetroForm
    {
        public frm_operations()
        {
            InitializeComponent();
            var fr = new uc_splash_employ_ops()
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var fr = new uc_leave_end()
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

        private void wait()
        {
            var fr = new uc_waiting_room()
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
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            wait();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            wait();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            wait();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
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
    }
}
