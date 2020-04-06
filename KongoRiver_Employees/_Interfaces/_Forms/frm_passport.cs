using KongoRiver_Employees._Codes;
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
    public partial class frm_passport : Form
    {
        DataRepository rps = new DataRepository();
        public frm_passport()
        {
            InitializeComponent();
        }
        public void refresh_Data()
        {
            rps.remplir_lisbox_nom(listBox1);
            rps.afficher_passport(bunifuCustomDataGrid2);
            txt_comments.Clear();
            txt_coy_id.Clear();
            txt_passport_number.Clear();
            txt_place_issued.Clear();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
