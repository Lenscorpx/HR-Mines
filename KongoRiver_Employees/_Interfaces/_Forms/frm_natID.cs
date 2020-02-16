using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KongoRiver_Employees._Codes;

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_natID : Form
    {
        DataRepository rps = new DataRepository();
        public frm_natID()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            rps.afficher_nat_ID(bunifuCustomDataGrid2);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
