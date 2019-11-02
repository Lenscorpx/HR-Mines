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
    public partial class uc_RR_type : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_RR_type()
        {
            InitializeComponent();
            refresh_data();
        }
        private void refresh_data()
        {
            rps.afficher_RR_type(bunifuCustomDataGrid1);
            txt_description.Clear();
            txt_rr_id.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_description.Text==""||txt_rr_id.Text=="")
            {
                MessageBox.Show("Please complete all required fields!!");
            }
            else
            {
                rps.enregistrer_RR_type(txt_rr_id.Text, txt_description.Text);
                refresh_data();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_description.Text == "")
            {
                MessageBox.Show("Please complete all required fields!!");
            }
            else
            {                
                var rs = new DialogResult();
                rs = MessageBox.Show("Please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_RR_type(txt_rr_id.Text);
                    refresh_data();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_rr_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
