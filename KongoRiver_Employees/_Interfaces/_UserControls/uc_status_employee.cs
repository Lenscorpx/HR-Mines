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
    public partial class uc_status_employee : UserControl
    {
        DataRepository repository = new DataRepository();
        public uc_status_employee()
        {
            InitializeComponent();
            loading();
        }
        private void loading()
        {
            repository.afficher_status_employee(bunifuCustomDataGrid1);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_id_status.Text==""||txt_description.Text=="")
            {
                MessageBox.Show("Missing Informations!");
            }
            else
            {
                repository.enregistrer_status_employee(txt_id_status.Text, txt_description.Text);
                loading();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_id_status.Text=="")
            {
                MessageBox.Show("Select at least one row to be able to delete!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    repository.supprimer_status_employee(txt_id_status.Text);
                    loading();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_status.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
