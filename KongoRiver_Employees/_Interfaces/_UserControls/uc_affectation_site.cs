using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KongoRiver_Employees._Codes;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_affectation_site : UserControl
    {
        DataRepository repository = new DataRepository();
        public uc_affectation_site()
        {
            InitializeComponent();
            loading();
        }
        private void loading()
        {
            repository.afficher_affectation_site(bunifuCustomDataGrid1);
            repository.recuperer_site(cbx_site);
            repository.recuperer_job(cbx_job);
            repository.remplir_lisbox_nom(listBox1);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string complete_name;
            complete_name = listBox1.SelectedItem.ToString();
            txt_nom_complet.Text = complete_name;
            repository.rechercher_coy_ID(txt_coy_id, complete_name);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_coy_id.Text==""||txt_id_engagement.Text==""||cbx_job.Text==""||cbx_site.Text=="")
            {
                MessageBox.Show("Please fill all required fields!");
            }
            else
            {
                if(txt_affectation_site.Text=="")
                {
                    repository.enregistrer_affectation_site(cbx_site.Text, Convert.ToInt32(txt_id_engagement.Text), cbx_job.Text, DateTime.Now);
                }
                else
                {
                    repository.modifier_affectation_site(Convert.ToInt32(txt_affectation_site.Text), cbx_site.Text, Convert.ToInt32(txt_id_engagement.Text), cbx_job.Text, DateTime.Now);
                }
                loading();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_affectation_site.Text != "")
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Are you sure to delete these datas from your database?", "Suppression Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    repository.supprimer_affectation_site(Convert.ToInt32(txt_affectation_site.Text));
                }
                loading();
            }
            else
            {
                MessageBox.Show("Please fill all required fields!");
            }
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_affectation_site.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            //cbx_site.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            //txt_id_engagement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            //cbx_job.Text= bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            ////cbx_status_employee.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            string coy_ID;
            coy_ID = txt_coy_id.Text;
            repository.rechercher_engagement_ID(txt_id_engagement, coy_ID);
        }

        private void txt_search_TextAlignChanged(object sender, EventArgs e)
        {

        }

            void txt_search_TextChanged(object sender, EventArgs e)
            => repository.rechercher_nom_employee(listBox1, txt_search.Text);

        private void txt_id_engagement_TextChanged(object sender, EventArgs e)
        {
            repository.rechercher_affectation_site(bunifuCustomDataGrid1, txt_id_engagement.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_affectation_site.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            cbx_site.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_id_engagement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            cbx_job.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            //cbx_status_employee.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
