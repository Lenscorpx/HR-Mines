using KongoRiver_Employees._Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongoRiver_Employees._Interfaces._Forms
{
    public partial class frm_employees : Form
    {
        DataRepository drs = new DataRepository();
        public frm_employees()
        {
            InitializeComponent();
            afficher_employees();
            cbx_sexe.Items.Add(Sexes.Female);
            cbx_sexe.Items.Add(Sexes.Male);
            cbx_etat_civil.Items.Add(Marital_Status.Civil_Union);
            cbx_etat_civil.Items.Add(Marital_Status.Divorced);
            cbx_etat_civil.Items.Add(Marital_Status.Married);
            cbx_etat_civil.Items.Add(Marital_Status.Partnership);
            cbx_etat_civil.Items.Add(Marital_Status.Single);
            cbx_etat_civil.Items.Add(Marital_Status.Widowed);
        }
        public void afficher_employees()
        {
            drs.afficher_employees(bunifuCustomDataGrid2);
            txt_coy_ID.Text="";
            txt_district.Text = "";
            txt_given_name.Text = "";
            txt_nationality.Text = "";
            txt_birthplace.Text = "";
            txt_lastname.Text = ""; 
            txt_province.Text = ""; ;
            txt_sect_chef.Text = "";
            txt_first_name.Text = "";
            txt_territory.Text = "";
            txt_village.Text = "";
            cbx_sexe.Text = "";
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "fichiers d'images|*.jpg;png;bmp";
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.Cancel)
                return;
            pictureBox2.Image = Image.FromFile(ofd.FileName);
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_coy_ID.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[0].Value.ToString();
            txt_first_name.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[1].Value.ToString();
            txt_lastname.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[2].Value.ToString();
            txt_given_name.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[3].Value.ToString();
            cbx_sexe.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[4].Value.ToString();
            txt_nationality.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[5].Value.ToString();
            txt_birthplace.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[6].Value.ToString();
            dt_date_birthday.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[7].Value.ToString();
            txt_province.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[8].Value.ToString();
            txt_district.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[9].Value.ToString();
            txt_territory.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[10].Value.ToString();
            txt_sect_chef.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[11].Value.ToString();
            txt_village.Text = bunifuCustomDataGrid2.SelectedRows[0].Cells[12].Value.ToString();
            try
            {
                byte[] tof2 = (byte[])bunifuCustomDataGrid2.SelectedRows[0].Cells[13].Value;
                var ms = new MemoryStream();
                ms = new MemoryStream(tof2);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox2.Image = Image.FromStream(ms);
            }
            catch (Exception tdf)
            {
                ///MessageBox.Show(tdf.ToString());
                MessageBox.Show("Cet agent n'a pas de photo convertible!");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] tof = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(tof, 0, tof.Length);
            if
                (
                    txt_coy_ID.Text == "" ||
                    txt_district.Text == "" ||
                    cbx_sexe.Text == "" ||
                    txt_given_name.Text == "" ||
                    txt_nationality.Text == "" ||
                    txt_birthplace.Text == "" ||
                    txt_lastname.Text == "" ||
                    txt_province.Text == "" ||
                    txt_sect_chef.Text == "" ||
                    txt_first_name.Text == "" ||
                    txt_territory.Text == "" ||
                    txt_village.Text == ""
                )
            {
                //MetroMessageBox.Show(this, "Essai reussi", "Essai", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) ;
                MessageBox.Show("Complete all empty cases!!");
            }
            else
            {
                drs.inserer_employee(txt_coy_ID.Text, txt_first_name.Text, txt_first_name.Text, txt_given_name.Text, cbx_sexe.Text, txt_nationality.Text, txt_birthplace.Text, Convert.ToDateTime(dt_date_birthday.Text), txt_province.Text, txt_district.Text, txt_territory.Text, txt_sect_chef.Text, txt_village.Text, tof);
                afficher_employees();
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if
                (txt_coy_ID.Text == "")
            {
                MessageBox.Show("Complete all empty cases!!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Veuillez confirmer pour la suppression", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    drs.supprimer_employee(txt_coy_ID.Text);
                    afficher_employees();
                    MessageBox.Show(this, "Suppression Reussie!", "Suppression Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_first_name_OnValueChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid2, txt_first_name.Text);
        }

        private void txt_lastname_OnValueChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid2, txt_lastname.Text);
        }

        private void txt_given_name_OnValueChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid2, txt_given_name.Text);
        }

        private void txt_coy_ID_OnValueChanged(object sender, EventArgs e)
        {
            drs.afficher_employees_params(bunifuCustomDataGrid2, txt_coy_ID.Text);
        }

        private void txt_visa_Click(object sender, EventArgs e)
        {
            if(txt_coy_ID.Text=="")
            {
                MessageBox.Show("Select first, Coy ID!");
            }
            else
            {
                var ds = new frm_visa();
                ds.txt_coyID.Text = txt_coy_ID.Text;
                ds.Show();
            }            
        }

        private void frm_employees_Load(object sender, EventArgs e)
        {

        }

        private void txt_contract_Click(object sender, EventArgs e)
        {
            if (txt_coy_ID.Text == "")
            {
                MessageBox.Show("Select first, Coy ID!");
            }
            else
            {
                var ds = new frm_contracts();
                ds.txt_coy_ID.Text = txt_coy_ID.Text;
                ds.txt_noms.Text = txt_first_name.Text + " " + txt_given_name.Text + " " + txt_lastname.Text;
                ds.Show();
            }
        }

        private void btn_nationalID_Click(object sender, EventArgs e)
        {
            if (txt_coy_ID.Text == "")
            {
                MessageBox.Show("Select first, Coy ID!");
            }
            else
            {
                var ds = new frm_natID();
                ds.txt_coyID.Text = txt_coy_ID.Text;
                ds.txt_noms.Text = txt_first_name.Text + " " + txt_given_name.Text + " " + txt_lastname.Text;
                ds.Show();
            }
        }
    }
}
