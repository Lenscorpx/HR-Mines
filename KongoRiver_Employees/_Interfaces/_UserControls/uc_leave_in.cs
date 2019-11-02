using System;
using System.Windows.Forms;
using KongoRiver_Employees._Codes;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_leave_in : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_leave_in()
        {
            InitializeComponent();
            refresh_Data();
        }
        public void refresh_Data()
        {
            rps.remplir_listbox_engaged(listBox1);
            rps.afficher_leave_in(bunifuCustomDataGrid1);
            clear_all();
        }
        void txt_search_TextChanged(object sender, EventArgs e)
            => rps.rechercher_nom_employee_engage(listBox1, txt_search.Text);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string complete_name;
                complete_name = listBox1.SelectedItem.ToString();
                rps.rechercher_coy_ID(txt_coy_id, complete_name);
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
        }
        private void clear_all()
        {
            txt_comments.Clear();
            txt_coy_id.Clear();
            txt_id_engagement.Clear();
            txt_id_leave_in.Clear();
            txt_motive.Clear();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_id_leave_in.Text != "")
            {
                if (txt_id_engagement.Text == ""|| dt_leavein.Text == "" || dt_expected.Text == "" || txt_motive.Text == "" || txt_comments.Text == "")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.modifier_leave_in(Convert.ToInt32(txt_id_leave_in.Text), Convert.ToInt32(txt_id_engagement.Text), Convert.ToDateTime(dt_leavein.Text), Convert.ToDateTime(dt_expected.Text), txt_motive.Text, txt_comments.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }

            }
            else
            {
                if (txt_id_engagement.Text == "" || dt_leavein.Text == "" || dt_expected.Text == "" || txt_motive.Text == "" || txt_comments.Text == "")
                {
                    MessageBox.Show("Complete all required informations!");
                }
                else
                {
                    rps.enregistrer_leave_in(Convert.ToInt32(txt_id_engagement.Text), Convert.ToDateTime(dt_leavein.Text), Convert.ToDateTime(dt_expected.Text), txt_motive.Text, txt_comments.Text);
                    MessageBox.Show(this, "Informations have been successfully recorded!", "Successful Recording!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_Data();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_id_leave_in.Text == "")
            {
                MessageBox.Show("Complete all required informations!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_leave_in(Convert.ToInt32(txt_id_leave_in.Text));
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
            txt_id_leave_in.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_id_engagement.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            dt_leavein.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            dt_expected.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            txt_motive.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            txt_comments.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}