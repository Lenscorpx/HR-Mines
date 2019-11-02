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
    public partial class uc_passport : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_passport()
        {
            InitializeComponent();
            refresh_Data();
        }

        public void refresh_Data()
        {
            rps.remplir_lisbox_nom(listBox1);            
            rps.afficher_passport(bunifuCustomDataGrid1);
            txt_comments.Clear();
            txt_coy_id.Clear();
            txt_passport_number.Clear();
            txt_place_issued.Clear();            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string complete_name;
            complete_name = listBox1.SelectedItem.ToString();
            rps.rechercher_coy_ID(txt_coy_id, complete_name);
        }

        void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee(listBox1, txt_search.Text);

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_coy_id.Text==""||txt_passport_number.Text==""||txt_place_issued.Text==""||dt_date_expiry.Text==""||dt_date_issued.Text=="")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_passport(txt_passport_number.Text, Convert.ToDateTime(dt_date_issued.Text), Convert.ToDateTime(dt_date_expiry.Text), txt_place_issued.Text, txt_coy_id.Text, txt_comments.Text);
                refresh_Data();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_coy_id.Text == "" || txt_passport_number.Text == "" || txt_place_issued.Text == "" || dt_date_expiry.Text == "" || dt_date_issued.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {                
                var rs = new DialogResult();
                rs = MessageBox.Show("Please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_passport(txt_passport_number.Text);
                    refresh_Data();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_passport_number.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                dt_date_issued.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString());
                dt_date_expiry.Value = Convert.ToDateTime(bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString());
                txt_place_issued.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
                txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
            
            //txt_comments.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_driving(bunifuCustomDataGrid1, txt_coy_id.Text);
        }
    }
}
