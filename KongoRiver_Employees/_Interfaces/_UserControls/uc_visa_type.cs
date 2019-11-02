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
    public partial class uc_visa_type : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_visa_type()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_visa_type(bunifuCustomDataGrid1);
            txt_visa_ID.Clear();
            txt_description.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_visa_ID.Text==""||txt_description.Text=="")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_visa_type(txt_visa_ID.Text, txt_description.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_visa_ID.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {                
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_visa_type(txt_visa_ID.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_visa_ID.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
