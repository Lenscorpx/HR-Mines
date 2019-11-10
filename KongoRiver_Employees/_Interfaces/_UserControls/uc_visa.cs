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
    public partial class uc_visa : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_visa()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_visa(bunifuCustomDataGrid1);
            rps.remplir_lisbox_nom(listBox1);
            txt_coy_id.Clear();
            txt_visa_ref.Clear();
            rps.recuperer_visa_type(cbx_visa_type);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_coy_id.Text == "" || txt_visa_ref.Text == "" || dt_date_issued.Text == ""|| cbx_visa_type.Text=="")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_visa(txt_visa_ref.Text, dt_date_issued.Value, metroDateTime1.Value, cbx_visa_type.Text, txt_coy_id.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_visa_ref.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_visa(txt_visa_ref.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_visa_ref.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                dt_date_issued.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString());
                metroDateTime1.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
                cbx_visa_type.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
                txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {
                
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

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_visa(bunifuCustomDataGrid1, txt_coy_id.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_visa_ref.Text=="")
            {
                MessageBox.Show("Selectionnez le numero de visa a declasser!");
            }
            else
            {
                DialogResult rs = new DialogResult();
                rs = MessageBox.Show(this, "Is this visa already expired?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if(rs==DialogResult.Yes)
                {
                    rps.expirer_visa(txt_visa_ref.Text);
                }
            }
        }
    }
}
