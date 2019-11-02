using System;
using System.Windows.Forms;
using KongoRiver_Employees._Codes;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_leave_end : UserControl
    {
        DataRepository rps = new DataRepository();
        DateTime d1, d2, d3;
        public uc_leave_end()
        {
            InitializeComponent();
            refresh_Data();
        }
        public void refresh_Data()
        {
            rps.remplir_listbox_engaged(listBox1);
            rps.retro_leave_in(bunifuCustomDataGrid2);
            rps.afficher_leave_end(bunifuCustomDataGrid1);            
        }

        void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee_engage(listBox1, txt_search.Text);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try
            {                
                rps.rechercher_coy_ID(txt_coy_id, listBox1.SelectedItem.ToString());
            }
            catch
            {

            }
            
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            string coy_ID;
            coy_ID = txt_coy_id.Text;
            rps.rechercher_engagement_ID(txt_id_engagement, coy_ID);
            if(txt_id_engagement.Text!="")
            {
                rps.retro_leave_in_params(bunifuCustomDataGrid2, Convert.ToInt32(txt_id_engagement.Text));
            }
            else
            {
                MessageBox.Show(this,"Please verify hiring's information about the employee!","Employee not hired yet!");
            }
            
        }

        private void dt_expected_ValueChanged(object sender, EventArgs e)
        {
            
            d1 = dt_leavein.Value;
            d2 = dt_expected.Value;
            int f = d2.Subtract(d1).Days;
            lbl_dys_on_leave.Text = f.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_leave_end.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_id_engagement.Text =bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            dt_expected.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            lbl_dys_on_leave.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_comments.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_engagement.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            d3 = Convert.ToDateTime(bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString());
            txt_id_leave_in.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            dt_leavein.Value = Convert.ToDateTime(bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString());

            //dt_leavein.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            //d3 = DateTime.Now;
            dt_expected.Text = d3.ToString();
            d1 = dt_leavein.Value;
            int r = DateTime.Now.Subtract(d1).Days;
            lbl_expected.Text = r.ToString();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {            
            if (txt_id_leave_end.Text != "")
            {
                if (txt_id_leave_in.Text == ""|| lbl_dys_on_leave.Text=="" || dt_expected.Text == "" || txt_comments.Text == "")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.modifier_leave_end(Convert.ToInt32(txt_id_leave_end.Text), Convert.ToInt32(txt_id_leave_in.Text), DateTime.Now, Convert.ToInt32(lbl_expected.Text), txt_comments.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }

            }
            else
            {
                if (txt_id_leave_in.Text == "" || lbl_dys_on_leave.Text == "" || dt_expected.Text == "" || txt_comments.Text == "")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.enregistrer_leave_end(Convert.ToInt32(txt_id_leave_in.Text), DateTime.Now, Convert.ToInt32(lbl_expected.Text), txt_comments.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {            
            if (txt_id_leave_end.Text == "")
            {
                MessageBox.Show("Complete all required informations!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_leave_end(Convert.ToInt32(txt_id_leave_end.Text));
                    refresh_Data();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DateTime d3;
            
        }

        private void txt_days_on_leave_TextChanged(object sender, EventArgs e)
        {
            int s=Convert.ToInt32(lbl_expected.Text);
            if(s>1)
            {
                lbl.Text = "days";
            }
            else
            {
                lbl.Text = "day";
            }
        }
    }
}
