using KongoRiver_Employees._Codes;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KongoRiver_Employees._Interfaces._UserControls
{
    public partial class uc_employee : UserControl
    {
        DataRepository drs = new DataRepository();
        public uc_employee()
        {
            InitializeComponent();
            afficher_employees();
            cbx_sexe.Items.Add(Sexes.Female);
            cbx_sexe.Items.Add(Sexes.Male);
        }
        public void afficher_employees()
        {
            drs.afficher_employees(bunifuCustomDataGrid1);
            txt_coy_id.Clear();
            txt_district.Clear();
            txt_givenname.Clear();
            txt_nationality.Clear();
            txt_place_of_birth.Clear();
            txt_postname.Clear();
            txt_province.Clear();
            txt_sect_chef.Clear();
            txt_surname.Clear();
            txt_territoire.Clear();
            txt_village.Clear();
            cbx_sexe.Text = "";
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
                    txt_coy_id.Text == "" || 
                    txt_district.Text == "" || 
                    cbx_sexe.Text == "" ||
                    txt_givenname.Text==""||
                    txt_nationality.Text==""||
                    txt_place_of_birth.Text==""||
                    txt_postname.Text==""||
                    txt_province.Text==""||
                    txt_sect_chef.Text==""||
                    txt_surname.Text==""||
                    txt_territoire.Text==""||
                    txt_village.Text==""
                )
                {
                    //MetroMessageBox.Show(this, "Essai reussi", "Essai", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) ;
                    MessageBox.Show("Complete all empty cases!!");
                }
                else
                {
                    drs.inserer_employee(txt_coy_id.Text, txt_surname.Text, txt_postname.Text, txt_givenname.Text, cbx_sexe.Text, txt_nationality.Text, txt_place_of_birth.Text, Convert.ToDateTime(dt_date_of_birth.Text), txt_province.Text, txt_district.Text, txt_territoire.Text, txt_sect_chef.Text, txt_village.Text,tof);
                afficher_employees();
                }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_surname_TextChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid1, txt_surname.Text);
        }

        private void txt_postname_TextChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid1, txt_postname.Text);
        }

        private void txt_givenname_TextChanged(object sender, EventArgs e)
        {
            drs.rechercher_employee(bunifuCustomDataGrid1, txt_givenname.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_coy_id_TextChanged(object sender, EventArgs e)
        {
            drs.afficher_employees_params(bunifuCustomDataGrid1, txt_coy_id.Text);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_coy_id.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString();
            txt_surname.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[1].Value.ToString();
            txt_postname.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[2].Value.ToString();
            txt_givenname.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            cbx_sexe.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            txt_nationality.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[5].Value.ToString();
            txt_place_of_birth.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[6].Value.ToString();
            dt_date_of_birth.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[7].Value.ToString();
            txt_province.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[8].Value.ToString();
            txt_district.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[9].Value.ToString();
            txt_territoire.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[10].Value.ToString();
            txt_sect_chef.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[11].Value.ToString();
            txt_village.Text = bunifuCustomDataGrid1.SelectedRows[0].Cells[12].Value.ToString();
            try
            {
                byte[] tof2 = (byte[])bunifuCustomDataGrid1.SelectedRows[0].Cells[13].Value;
                var ms = new MemoryStream();
                ms = new MemoryStream(tof2);
                ms.Seek(0, SeekOrigin.Begin);
                pictureBox2.Image = Image.FromStream(ms);
            }
            catch(Exception tdf)
            {
                ///MessageBox.Show(tdf.ToString());
                MessageBox.Show("Cet agent n'a pas de photo convertible!");
            }
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

        private void txt_coy_id_Click(object sender, EventArgs e)
        {

        }
    }
}