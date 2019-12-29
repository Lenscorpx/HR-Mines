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
    public partial class frm_sites : Form
    {
        DataRepository rps = new DataRepository();
        public frm_sites()
        {
            InitializeComponent();
            loading();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loading()
        {
            rps.afficher_site(bunifuCustomDataGrid2);
        }

        private void frm_sites_Load(object sender, EventArgs e)
        {

        }

        private void txt_site_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_designation_site_Click(object sender, EventArgs e)
        {

        }

        private void txt_designation_site_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_site(bunifuCustomDataGrid2, txt_bnf_designation.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_bnf_idsite.Text == "" || txt_bnf_designation.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                rps.inserer_site(txt_bnf_idsite.Text, txt_bnf_designation.Text);
                loading();
                txt_bnf_idsite.ResetText(); txt_bnf_designation.ResetText();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_bnf_idsite.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_site(txt_bnf_idsite.Text);
                    loading();
                    txt_bnf_idsite.Text=""; txt_bnf_designation.Text="";
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_bnf_idsite.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_bnf_designation.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void txt_bnf_idsite_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_site(bunifuCustomDataGrid2, txt_bnf_designation.Text);
        }
    }
}
