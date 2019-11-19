using MaterialSkin.Controls;
using MetroFramework.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
//using DevExpress.XtraPrinting.Preview;

namespace KongoRiver_Employees._Codes
{
    public class DataRepository
    {
        static SqlConnection cnx;
        Params prms = new Params();
        public DataRepository()
        {
            //prms.Serveur = "tcp:conebase.database.windows.net";                    
            //prms.Nom_user = "LensX";
            //prms.Mot_de_passe = "Cony@2017.com?";
            //prms.Serveur = "PAMELA";
            //prms.Base_de_donnees = "AndreaBD";
            //prms.Nom_user = "sa";
            //prms.Mot_de_passe = "123456";
            //prms.Serveur = "ALEX_B";
            //prms.Base_de_donnees = "AndreaBD";
            //prms.Nom_user = "Lens";
            //prms.Mot_de_passe = "12345678";
            prms.Serveur = "DESKTOP-PO0I2OH";
            prms.Base_de_donnees = "AndreaBD";
            prms.Nom_user = "Lens";
            prms.Mot_de_passe = "Windy@2019.com?";

        }
        public void afficher_employees(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_employees", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_employees_params(DataGridView dtg, string search)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_employees_params", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = search;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_employee(string coy_ID, string surname, string postname, string given_name, string sex, string nationality, string place_of_birth, DateTime date_of_birth, string province, string district, string territory, string sect_cheff, string village, byte[] photo)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("surname", SqlDbType.NVarChar)).Value = surname;
                cmd.Parameters.Add(new SqlParameter("postname", SqlDbType.NVarChar)).Value = postname;
                cmd.Parameters.Add(new SqlParameter("given_name", SqlDbType.NVarChar)).Value = given_name;
                cmd.Parameters.Add(new SqlParameter("sex", SqlDbType.NVarChar)).Value = sex;
                cmd.Parameters.Add(new SqlParameter("nationality", SqlDbType.NVarChar)).Value = nationality;
                cmd.Parameters.Add(new SqlParameter("place_of_birth", SqlDbType.NVarChar)).Value = place_of_birth;
                cmd.Parameters.Add(new SqlParameter("date_of_birth", SqlDbType.Date)).Value = date_of_birth;
                cmd.Parameters.Add(new SqlParameter("province", SqlDbType.NVarChar)).Value = province;
                cmd.Parameters.Add(new SqlParameter("district", SqlDbType.NVarChar)).Value = district;
                cmd.Parameters.Add(new SqlParameter("territory", SqlDbType.NVarChar)).Value = territory;
                cmd.Parameters.Add(new SqlParameter("sect_cheff", SqlDbType.NVarChar)).Value = sect_cheff;
                cmd.Parameters.Add(new SqlParameter("village", SqlDbType.NVarChar)).Value = village;
                cmd.Parameters.Add(new SqlParameter("photo", SqlDbType.Image)).Value = photo;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Database Update Succeeded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_employee(string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);
                MessageBox.Show("Database Update Succeeded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_employee(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("input", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_nom_employee(ListBox lst, string search_name)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_nom_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_nom_employee_engage(ListBox lst, string search_name)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_nom_employee_engage", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void remplir_lisbox_nom(ListBox lst)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("remplir_lisbox_nom", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void remplir_listbox_engaged(ListBox lst)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("remplir_listbox_engaged", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_coy_ID(MaterialSingleLineTextField txt, string search_name)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_coy_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("complete_name_employee", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                txt.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    txt.Text=Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_engagement_ID(MaterialSingleLineTextField txt, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_engagement_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                txt.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    txt.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_engagement_parAgent(DataGridView dtg, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_engagement_parAgent", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_engagement_employee(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_engagement_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void afficher_status_employee(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_status_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_status_employee(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_status_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_status_employee(string id_status, string title_status)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_status_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_status", SqlDbType.NVarChar)).Value = id_status;
                cmd.Parameters.Add(new SqlParameter("title_status", SqlDbType.NVarChar)).Value = title_status;
                cmd.Parameters.Add(new SqlParameter("record_date", SqlDbType.Date)).Value = Convert.ToDateTime(DateTime.Today);
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_status_employee(string id_status)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_status_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_status", SqlDbType.NVarChar)).Value = id_status;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_engagement_employee(string coy_ID, DateTime date_engagement, string id_status_employee, string current_adress, string marital_status, string telephone_1, string telephone_2, DateTime date_fin_contrat, string id_contract)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_engagement_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("date_engagement", SqlDbType.Date)).Value = date_engagement;
                cmd.Parameters.Add(new SqlParameter("date_fin_contrat", SqlDbType.Date)).Value = date_fin_contrat;
                cmd.Parameters.Add(new SqlParameter("id_status_employee", SqlDbType.NVarChar)).Value = id_status_employee;
                cmd.Parameters.Add(new SqlParameter("current_adress", SqlDbType.NVarChar)).Value = current_adress;
                cmd.Parameters.Add(new SqlParameter("marital_status", SqlDbType.NVarChar)).Value = marital_status;
                cmd.Parameters.Add(new SqlParameter("telephone_1", SqlDbType.NVarChar)).Value = telephone_1;
                cmd.Parameters.Add(new SqlParameter("telephone_2", SqlDbType.NVarChar)).Value = telephone_2;
                cmd.Parameters.Add(new SqlParameter("id_contract", SqlDbType.NVarChar)).Value = id_contract;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_engagement_employee(int id_engagement_employee, string coy_ID, DateTime date_engagement, string id_status_employee, string current_adress, string marital_status, string telephone_1, string telephone_2, DateTime date_fin_contrat, string id_contract)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_engagement_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("date_engagement", SqlDbType.Date)).Value = date_engagement;
                cmd.Parameters.Add(new SqlParameter("date_fin_contrat", SqlDbType.Date)).Value = date_fin_contrat;
                cmd.Parameters.Add(new SqlParameter("id_status_employee", SqlDbType.NVarChar)).Value = id_status_employee;
                cmd.Parameters.Add(new SqlParameter("current_adress", SqlDbType.NVarChar)).Value = current_adress;
                cmd.Parameters.Add(new SqlParameter("marital_status", SqlDbType.NVarChar)).Value = marital_status;
                cmd.Parameters.Add(new SqlParameter("telephone_1", SqlDbType.NVarChar)).Value = telephone_1;
                cmd.Parameters.Add(new SqlParameter("telephone_2", SqlDbType.NVarChar)).Value = telephone_2;
                cmd.Parameters.Add(new SqlParameter("id_contract", SqlDbType.NVarChar)).Value = id_contract;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_engagement_employee(int id_engagement_employee, string coy_ID, DateTime date_engagement, string id_status_employee, string current_adress, string marital_status, string telephone_1, string telephone_2)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_engagement_employee", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_leave_in(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_leave_in", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_leave_in(int id_engagement_employee, DateTime date_leave_in, DateTime expected_date_leave_out, string motive, string comment_leave)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_leave_in", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.Parameters.Add(new SqlParameter("date_leave_in", SqlDbType.Date)).Value = date_leave_in;
                cmd.Parameters.Add(new SqlParameter("expected_date_leave_out", SqlDbType.Date)).Value = expected_date_leave_out;
                cmd.Parameters.Add(new SqlParameter("motive", SqlDbType.NVarChar)).Value = motive;
                cmd.Parameters.Add(new SqlParameter("comment_leave", SqlDbType.NVarChar)).Value = comment_leave;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_leave_in(int id_leave_in, int id_engagement_employee, DateTime date_leave_in, DateTime expected_date_leave_out, string motive, string comment_leave)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_leave_in", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_leave_in", SqlDbType.Int)).Value = id_leave_in;
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.Parameters.Add(new SqlParameter("date_leave_in", SqlDbType.Date)).Value = date_leave_in;
                cmd.Parameters.Add(new SqlParameter("expected_date_leave_out", SqlDbType.Date)).Value = expected_date_leave_out;
                cmd.Parameters.Add(new SqlParameter("motive", SqlDbType.NVarChar)).Value = motive;
                cmd.Parameters.Add(new SqlParameter("comment_leave", SqlDbType.NVarChar)).Value = comment_leave;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_leave_in(int id_leave_in)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_leave_in", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_leave_in", SqlDbType.Int)).Value = id_leave_in;
                
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_leave_end(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_leave_end", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_leave_end(int id_leave_in, DateTime date_leave_end, int days_on_leave, string comment_leave_end)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_leave_end", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_leave_in", SqlDbType.Int)).Value = id_leave_in;
                cmd.Parameters.Add(new SqlParameter("date_leave_end", SqlDbType.Date)).Value = date_leave_end;
                cmd.Parameters.Add(new SqlParameter("days_on_leave", SqlDbType.Int)).Value = days_on_leave;
                cmd.Parameters.Add(new SqlParameter("comment_leave_end", SqlDbType.NVarChar)).Value = comment_leave_end;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_leave_end(int id_leave_end, int id_leave_in, DateTime date_leave_end, int days_on_leave, string comment_leave_end)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_leave_end", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };                
                cmd.Parameters.Add(new SqlParameter("id_leave_end", SqlDbType.Int)).Value = id_leave_end;
                cmd.Parameters.Add(new SqlParameter("id_leave_in", SqlDbType.Int)).Value = id_leave_in;
                cmd.Parameters.Add(new SqlParameter("date_leave_end", SqlDbType.Date)).Value = date_leave_end;
                cmd.Parameters.Add(new SqlParameter("days_on_leave", SqlDbType.Int)).Value = days_on_leave;
                cmd.Parameters.Add(new SqlParameter("comment_leave_end", SqlDbType.NVarChar)).Value = comment_leave_end;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_leave_end(int id_leave_end)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_leave_end", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_leave_end", SqlDbType.Int)).Value = id_leave_end;

                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void retro_leave_in(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("retro_leave_in", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void retro_leave_in_params(DataGridView dtg, int id_engagement_employee)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("retro_leave_in_params", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_site(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_site(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_affectation_site(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_affectation_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void inserer_site(string id_site, string designation_site)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("inserer_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_site", SqlDbType.NVarChar)).Value = id_site;
                cmd.Parameters.Add(new SqlParameter("designation_site", SqlDbType.NVarChar)).Value = designation_site;
                cmd.Parameters.Add(new SqlParameter("record_date", SqlDbType.Date)).Value = Convert.ToDateTime(DateTime.Today);
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_affectation_site(string id_site, int id_engagement_employee, string id_job_employee, DateTime date_affectation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_affectation_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_site", SqlDbType.NVarChar)).Value = id_site;
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.Parameters.Add(new SqlParameter("id_job_employee_title", SqlDbType.NVarChar)).Value = id_job_employee;
                cmd.Parameters.Add(new SqlParameter("date_affectation", SqlDbType.Date)).Value = Convert.ToDateTime(DateTime.Today);
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void modifier_affectation_site(int id_affectation_site, string id_site, int id_engagement_employee, string id_job_employee, DateTime date_affectation)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_affectation_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_affectation_site", SqlDbType.Int)).Value = id_affectation_site;
                cmd.Parameters.Add(new SqlParameter("id_site", SqlDbType.NVarChar)).Value = id_site;
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.Int)).Value = id_engagement_employee;
                cmd.Parameters.Add(new SqlParameter("id_job_employee_title", SqlDbType.NVarChar)).Value = id_job_employee;
                cmd.Parameters.Add(new SqlParameter("date_affectation", SqlDbType.Date)).Value = Convert.ToDateTime(DateTime.Today);
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_site(string id_site)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_site", SqlDbType.NVarChar)).Value = id_site;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_affectation_site(int id_affectation_site)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_affectation_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_affectation_site", SqlDbType.NVarChar)).Value = id_affectation_site;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_site(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_affectation_site(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_affectation_site", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_engagement_employee", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_bank(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_bank", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_bank(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_bank", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_bank(string id_bank, string bank_name, string swift_code, string bank_code)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_bank", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_bank", SqlDbType.NVarChar)).Value = id_bank;
                cmd.Parameters.Add(new SqlParameter("bank_name", SqlDbType.NVarChar)).Value = bank_name;
                cmd.Parameters.Add(new SqlParameter("swift_code", SqlDbType.NVarChar)).Value = swift_code;
                cmd.Parameters.Add(new SqlParameter("bank_code", SqlDbType.NVarChar)).Value = bank_code;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_bank(string id_site)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_bank", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_bank", SqlDbType.NVarChar)).Value = id_site;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_bank(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_bank", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_departement(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_departement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_department(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_department", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_department(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_department", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_department(string id_department, string title)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_department", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_department", SqlDbType.NVarChar)).Value = id_department;
                cmd.Parameters.Add(new SqlParameter("title", SqlDbType.NVarChar)).Value = title;                
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_department(string id_department)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_department", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_department", SqlDbType.NVarChar)).Value = id_department;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_visa_type(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_visa_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_visa_type(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_visa_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_visa_type(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_visa_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_visa_type(string visa_title, string description_visa)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_visa_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("visa_title", SqlDbType.NVarChar)).Value = visa_title;
                cmd.Parameters.Add(new SqlParameter("description_visa", SqlDbType.NVarChar)).Value = @description_visa;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_visa_type(string visa_title)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_visa_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("visa_title", SqlDbType.NVarChar)).Value = visa_title;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_RR_type(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_RR_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_RR_type(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_RR_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_RR_type(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_RR_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_RR_type(string id_RR, string title_RR)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_RR_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_RR", SqlDbType.NVarChar)).Value = @id_RR;
                cmd.Parameters.Add(new SqlParameter("title_RR", SqlDbType.NVarChar)).Value = @title_RR;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_RR_type(string id_RR)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_RR_type", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_RR", SqlDbType.NVarChar)).Value = id_RR;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_job(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_job", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_job(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_job", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_job(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_job", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_job(string id_job_employee_title, string id_job_french, string id_department)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_job", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_job_employee_title", SqlDbType.NVarChar)).Value = id_job_employee_title;
                cmd.Parameters.Add(new SqlParameter("id_job_french", SqlDbType.NVarChar)).Value = id_job_french;
                cmd.Parameters.Add(new SqlParameter("id_department", SqlDbType.NVarChar)).Value = id_department;
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_job(string id_job_employee_title)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_job", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_job_employee_title", SqlDbType.NVarChar)).Value = id_job_employee_title;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_passport(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_passport", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_passport(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_passport", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_passport(string passport_number, DateTime issued_day, DateTime expiry_day, string place, string coy_ID, string comment)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_passport", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("passport_number", SqlDbType.NVarChar)).Value = passport_number;
                cmd.Parameters.Add(new SqlParameter("issued_day", SqlDbType.Date)).Value = issued_day;
                cmd.Parameters.Add(new SqlParameter("expiry_day", SqlDbType.Date)).Value = expiry_day;
                cmd.Parameters.Add(new SqlParameter("place", SqlDbType.NVarChar)).Value = place;
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("comment", SqlDbType.NVarChar)).Value = comment;
                
                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_passport(string passport_number)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_passport", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("passport_number", SqlDbType.NVarChar)).Value = passport_number;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        //public void rechercher_expiry_passport(DateTime date1, DateTime date2, DocumentViewer dcviewer)
        //{
        //    cnx = new SqlConnection(prms.ToString());
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        const string requete = "imprimer_vendeur_par_matricule";
        //        var cmd = new SqlCommand(requete, cnx)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.Add(new SqlParameter("matricule_vendeur", SqlDbType.NVarChar)).Value = matricule;
        //        cmd.ExecuteNonQuery();

        //        var da = new SqlDataAdapter(cmd);
        //        var rpt = new rpt_fiche_vendeur();
        //        var dtset = new DataSet();
        //        da.Fill(dtset, "imprimer_vendeur_par_matricule");
        //        rpt.DataSource = dtset;
        //        dcviewer.DocumentSource = rpt;
        //        rpt.CreateDocument();
        //        dcviewer.Refresh();
        //    }
        //    catch (Exception etr)
        //    {
        //        MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        var rs = new DialogResult();
        //        rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (rs == DialogResult.Yes)
        //        {
        //            MessageBox.Show(etr.ToString());
        //        }
        //    }
        //    finally
        //    {
        //        cnx.Close(); cnx.Dispose();
        //    }
        //}
        public void rechercher_nat_ID(DataGridView dtg, string a_rechercher)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_nat_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search_name", SqlDbType.NVarChar)).Value = a_rechercher;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_nat_ID(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_nat_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_nat_ID(string natID_number, string id_place_natID, DateTime id_date_natID, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_nat_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("natID_number", SqlDbType.NVarChar)).Value = natID_number;
                cmd.Parameters.Add(new SqlParameter("id_place_natID", SqlDbType.NVarChar)).Value = id_place_natID;
                cmd.Parameters.Add(new SqlParameter("id_date_natID", SqlDbType.Date)).Value = id_date_natID;                
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("record_date", SqlDbType.Date)).Value = DateTime.Today;

                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_nat_ID(string natID_number)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_nat_ID", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("natID_number", SqlDbType.NVarChar)).Value = natID_number;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }        
        public void afficher_visa(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_visa", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_visa(string visa_ref, DateTime issued_day, DateTime expiry_day, string visa_title, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_visa", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("visa_ref", SqlDbType.NVarChar)).Value = visa_ref;
                cmd.Parameters.Add(new SqlParameter("date_issued", SqlDbType.Date)).Value = issued_day;
                cmd.Parameters.Add(new SqlParameter("expiry_day", SqlDbType.Date)).Value = expiry_day;
                cmd.Parameters.Add(new SqlParameter("visa_title", SqlDbType.NVarChar)).Value = visa_title;
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;

                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_visa(string visa_ref)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_visa", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("visa_ref", SqlDbType.NVarChar)).Value = visa_ref;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_visa(DataGridView dtg, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_visa", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void afficher_driving_license(DataGridView dtg)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_driving_license", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void enregistrer_driving_license(string id_driving_license, DateTime issued_day, DateTime expiry_day, string coy_ID, DateTime record_date)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_driving_license", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_driving_license", SqlDbType.NVarChar)).Value = id_driving_license;
                cmd.Parameters.Add(new SqlParameter("issued_day", SqlDbType.Date)).Value = issued_day;
                cmd.Parameters.Add(new SqlParameter("expiry_day", SqlDbType.Date)).Value = expiry_day;
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.Parameters.Add(new SqlParameter("record_date", SqlDbType.Date)).Value = record_date;
                

                cmd.ExecuteNonQuery();
                //afficher_frais(dtg);                
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_driving_license(string id_driving_license)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_driving_license", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_driving_license", SqlDbType.NVarChar)).Value = id_driving_license;
                cmd.ExecuteNonQuery();
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_driving(DataGridView dtg, string coy_ID)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_driving", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("coy_ID", SqlDbType.NVarChar)).Value = coy_ID;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void expirer_visa(string visa_ref)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("expirer_visa", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("visa_ref", SqlDbType.NVarChar)).Value = visa_ref;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully done!");
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Want to see error code?", "Errors ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void recuperer_contrat(MetroComboBox cbx)
        {
            cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_contrat", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //cmd.Parameters.Add(new SqlParameter("complete_name", SqlDbType.NVarChar)).Value = search_name;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                cbx.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    cbx.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception tdf)
            {
                MessageBox.Show("Connection failed!\n" + tdf);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
    }
}