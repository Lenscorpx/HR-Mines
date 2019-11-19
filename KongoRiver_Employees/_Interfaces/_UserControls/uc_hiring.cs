using KongoRiver_Employees._Codes;
using System;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_hiring : UserControl
    {
        DataRepository rps = new DataRepository();

        public uc_hiring()
        {
            InitializeComponent();
            refresh_Data();
        }

        void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee(listBox1, txt_search.Text);

        public void refresh_Data()
        {
            rps.afficher_engagement_employee(bunifuCustomDataGrid1);
            rps.remplir_lisbox_nom(listBox1);
            rps.recuperer_contrat(cbx_type_contrat);
            cbx_marital_status.Items.Clear();
            rps.recuperer_status_employee(cbx_status_employee);
            cbx_marital_status.Items.Add(Marital_Status.Single);
            cbx_marital_status.Items.Add(Marital_Status.Married);
            cbx_marital_status.Items.Add(Marital_Status.Divorced);
            cbx_marital_status.Items.Add(Marital_Status.Widowed);
            cbx_marital_status.Items.Add(Marital_Status.Civil_Union);
            cbx_marital_status.Items.Add(Marital_Status.Partnership);
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string complete_name;
            complete_name = listBox1.SelectedItem.ToString();
            rps.rechercher_coy_ID(txt_coy_id, complete_name);            
            txt_noms.Text = complete_name;            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_engagement.Text != "")
            {
                if (txt_coy_id.Text == "" || cbx_marital_status.Text == "" || cbx_status_employee.Text == "" || txt_phone_1.Text == "" || txt_curent_address.Text == ""||cbx_type_contrat.Text=="")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.modifier_engagement_employee(Convert.ToInt32(txt_id_engagement.Text),txt_coy_id.Text, dt_date_hiring.Value, cbx_status_employee.Text, txt_curent_address.Text, cbx_marital_status.Text, txt_phone_1.Text, txt_phone_2.Text, dt_fin_contrat.Value,cbx_type_contrat.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }
            }
            else
            {
                if (txt_coy_id.Text == "" || cbx_marital_status.Text == "" || cbx_status_employee.Text == "" || txt_phone_1.Text == "" || txt_curent_address.Text == "")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.enregistrer_engagement_employee(txt_coy_id.Text, dt_date_hiring.Value, cbx_status_employee.Text, txt_curent_address.Text, cbx_marital_status.Text, txt_phone_1.Text, txt_phone_2.Text, dt_fin_contrat.Value, cbx_type_contrat.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_engagement.Text == "")
            {
                MessageBox.Show("Complete all required informations!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.modifier_engagement_employee(Convert.ToInt32(txt_id_engagement.Text), txt_coy_id.Text, Convert.ToDateTime(dt_date_hiring.Value), cbx_status_employee.Text, txt_curent_address.Text, cbx_marital_status.Text, txt_phone_1.Text, txt_phone_2.Text, dt_fin_contrat.Value, cbx_type_contrat.Text);
                    refresh_Data();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_engagement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            dt_date_hiring.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            cbx_status_employee.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_curent_address.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            cbx_marital_status.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
            txt_phone_1.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[6].Value.ToString();
            txt_phone_2.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_engagement_parAgent(bunifuCustomDataGrid1, txt_coy_id.Text);
        }

        private void txt_noms_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_engagement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            dt_date_hiring.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            dt_fin_contrat.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            cbx_status_employee.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            cbx_type_contrat.Text= bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
            txt_curent_address.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[6].Value.ToString();
            cbx_marital_status.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[7].Value.ToString();
            txt_phone_1.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[8].Value.ToString();
            txt_phone_2.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
