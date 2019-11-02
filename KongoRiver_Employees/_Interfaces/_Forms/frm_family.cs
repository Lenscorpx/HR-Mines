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
    public partial class frm_family : MetroForm
    {
        public frm_family()
        {
            InitializeComponent();
            var fr = new uc_splash_family()
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
    }
}
