using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongoRiver_Employees._Codes
{
    public partial class frm_visa : Form
    {
        DataRepository rps = new DataRepository();
        public frm_visa()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refreshData()
        {
            rps.afficher_visa(bunifuCustomDataGrid2);
            txt_coyID.Text = "";
            txt_visa_ref.Text = "";
            rps.recuperer_visa_type(cbx_visa_type);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (txt_coyID.Text == "" || txt_visa_ref.Text == "" || dt_issue_date.Text == "" || cbx_visa_type.Text == "")
            {
                MessageBox.Show("Please complete all required fields!");
            }
            else
            {
                rps.enregistrer_visa(txt_visa_ref.Text, dt_issue_date.Value, dt_expiry_date.Value, cbx_visa_type.Text, txt_coyID.Text);
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

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_visa_ref.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
                dt_issue_date.Value = Convert.ToDateTime(bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString());
                dt_expiry_date.Value = Convert.ToDateTime(bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString());
                cbx_visa_type.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
                txt_coyID.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void txt_coyID_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_visa(bunifuCustomDataGrid2, txt_coyID.Text);
        }

        private void btn_expiry_Click(object sender, EventArgs e)
        {
            if (txt_visa_ref.Text == "")
            {
                MessageBox.Show("Select visa Ref!");
            }
            else
            {
                DialogResult rs = new DialogResult();
                rs = MessageBox.Show(this, "Is this visa already expired?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.Yes)
                {
                    rps.expirer_visa(txt_visa_ref.Text);
                }
            }
        }
    }
}
