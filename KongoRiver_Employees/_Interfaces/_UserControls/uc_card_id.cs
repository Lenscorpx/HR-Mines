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
    public partial class uc_card_id : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_card_id()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_nat_ID(bunifuCustomDataGrid1);
            rps.remplir_lisbox_nom(listBox1);
            txt_coy_id.Clear();
            txt_natID_number.Clear();
            txt_place_issued.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee(listBox1, txt_search.Text);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string complete_name;
            complete_name = listBox1.SelectedItem.ToString();
            rps.rechercher_coy_ID(txt_coy_id, complete_name);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_natID_number.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_nat_ID(txt_natID_number.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_coy_id.Text == "" || txt_natID_number.Text == "" || txt_place_issued.Text == "" || dt_date_issued.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_nat_ID(txt_natID_number.Text, txt_place_issued.Text, dt_date_issued.Value, txt_coy_id.Text);
                refreshData();
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_natID_number.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_place_issued.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            dt_date_issued.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
            txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            rps.search_natID_bycoy(bunifuCustomDataGrid1, txt_coy_id.Text);
        }
    }
}
