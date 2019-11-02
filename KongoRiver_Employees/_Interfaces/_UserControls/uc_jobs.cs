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
    public partial class uc_jobs : UserControl
    {
        DataRepository rps = new DataRepository();
        public uc_jobs()
        {
            InitializeComponent();
            refreshData();
        }
        private void refreshData()
        {
            rps.afficher_job(bunifuCustomDataGrid1);
            rps.recuperer_department(cbx_status_employee);
            txt_description.Clear();
            txt_job_title.Clear();
            if(cbx_status_employee!=null)
            {
                cbx_status_employee.SelectedIndex = 0;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_description.Text==""||txt_job_title.Text=="")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_job(txt_job_title.Text, txt_description.Text, cbx_status_employee.Text);
                refreshData();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_description.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {               
                var rs = new DialogResult();
                rs = MessageBox.Show("please confirm with OK to delete this information", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    rps.enregistrer_job(txt_job_title.Text, txt_description.Text, cbx_status_employee.Text);
                    refreshData();
                    MessageBox.Show(this, "successful deletion!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_job_title.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_description.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            cbx_status_employee.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
