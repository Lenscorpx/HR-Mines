using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KongoRiver_Employees._Interfaces._Forms;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_dashboard : UserControl
    {
        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_alerte_visa();
            fr.ShowDialog();
        }
    }
}
