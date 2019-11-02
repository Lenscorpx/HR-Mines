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
    public partial class frm_documents : MetroForm
    {
        public frm_documents()
        {
            InitializeComponent();
            afficher_accueil();
        }
        private void afficher_accueil()
        {
            var fr = new uc_documents_acc()
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
            var fr = new uc_passport()
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

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            var fr = new uc_card_id()
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new uc_visa()
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

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            var fr = new uc_driving_license()
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
