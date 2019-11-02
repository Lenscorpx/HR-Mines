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
    public partial class uc_driving_license : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_driving_license()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_driving_license(bunifuCustomDataGrid1);
            rps.remplir_lisbox_nom(listBox1);
            txt_coy_id.Clear();
            txt_driving_license.Clear();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_coy_id.Text == "" || txt_driving_license.Text == "" || dt_date_issued.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_driving_license(txt_driving_license.Text, dt_date_issued.Value, metroDateTime1.Value, txt_coy_id.Text, DateTime.Now);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_driving_license.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_driving_license(txt_driving_license.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string complete_name;
            complete_name = listBox1.SelectedItem.ToString();
            rps.rechercher_coy_ID(txt_coy_id, complete_name);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee(listBox1, txt_search.Text);

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_driving_license.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                dt_date_issued.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString());
                metroDateTime1.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
                txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
                //.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
