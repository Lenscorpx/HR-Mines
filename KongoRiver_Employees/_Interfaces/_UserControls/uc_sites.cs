using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KongoRiver_Employees._Codes;
using System.Windows.Forms;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_sites : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_sites()
        {
            InitializeComponent();
            loading();
        }
        private void loading()
        {
            rps.afficher_site(bunifuCustomDataGrid1);
        }

        private void txt_designation_site_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_site(bunifuCustomDataGrid1, txt_designation_site.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_site_id.Text==""||txt_designation_site.Text=="")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                rps.inserer_site(txt_site_id.Text, txt_designation_site.Text);
                loading();
                txt_site_id.Clear();txt_designation_site.Clear();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_site_id.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_site(txt_site_id.Text);
                    loading();
                    txt_site_id.Clear(); txt_designation_site.Clear();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_site_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_designation_site.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
