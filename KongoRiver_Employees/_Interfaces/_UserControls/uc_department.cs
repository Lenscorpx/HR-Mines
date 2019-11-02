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
    public partial class uc_department : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_department()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_department(bunifuCustomDataGrid1);
            txt_description.Clear();
            txt_department_id.Clear();
        }

        private void txt_department_id_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_departement(bunifuCustomDataGrid1, txt_department_id.Text);
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            rps.rechercher_departement(bunifuCustomDataGrid1, txt_description.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_department_id.Text==""||txt_description.Text=="")
            {
                MessageBox.Show("Please complete all informations before updating database!");
            }
            else
            {
                rps.enregistrer_department(txt_department_id.Text, txt_description.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_department_id.Text == "")
            {
                MessageBox.Show("Please complete all informations before updating database!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.supprimer_department(txt_department_id.Text);
                    refreshData();
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
                txt_department_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                txt_description.Text =   bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {

            }
            
        }
    }
}
