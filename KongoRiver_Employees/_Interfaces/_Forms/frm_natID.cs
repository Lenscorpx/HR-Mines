using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KongoRiver_Employees._Codes;

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_natID : Form
    {
        DataRepository rps = new DataRepository();
        public frm_natID()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            rps.afficher_nat_ID(bunifuCustomDataGrid2);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_coyID_OnValueChanged(object sender, EventArgs e)
        {
            rps.rechercher_nat_ID_coy(bunifuCustomDataGrid2, txt_coyID.Text);
        }

        private void txt_natID_ref_OnValueChanged(object sender, EventArgs e)
        {
            rps.search_natID(bunifuCustomDataGrid2, txt_natID_ref.Text);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_coyID.Text==""|| txt_natID_ref.Text=="" ||txt_place.Text=="" ||dt_issue_date.Text=="")
            {
                MessageBox.Show("Please fill all required informations!");
            }
            else
            {
                rps.enregistrer_nat_ID(txt_natID_ref.Text, txt_place.Text, dt_issue_date.Value, txt_coyID.Text);
                refresh();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if(txt_natID_ref.Text=="")
            {
                MessageBox.Show("Please select Nat ID number in order to delete it!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Confirm deletion?", "Deletion confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs==DialogResult.Yes)
                {
                    rps.supprimer_nat_ID(txt_natID_ref.Text);
                    refresh();
                }                
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_natID_ref.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_place.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            dt_issue_date.Value = Convert.ToDateTime(bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString());
            txt_coyID.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
