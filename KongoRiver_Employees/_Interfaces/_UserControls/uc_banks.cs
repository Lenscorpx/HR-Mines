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
    public partial class uc_banks : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_banks()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_bank(bunifuCustomDataGrid1);
            txt_bank_code.Clear();
            txt_bank_id.Clear();
            txt_bank_name.Clear();
            txt_swift_code.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_bank_id.Text==""||txt_bank_name.Text=="")
            {
                MessageBox.Show("You must complete bank id and bank name!");
            }
            else
            {
                rps.enregistrer_bank(txt_bank_id.Text, txt_bank_name.Text, txt_swift_code.Text, txt_bank_code.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_bank_id.Text == "")
            {
                MessageBox.Show("You must complete bank id in order to delete!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_bank(txt_bank_id.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_bank_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_bank_name.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_swift_code.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            txt_bank_code.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
