using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
