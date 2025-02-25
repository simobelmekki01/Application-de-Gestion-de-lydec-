using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simofinal
{
    public static class databasehelper
    {
        private static string connectionString = "server=localhost;user id=root;password=mohcine;database=simolydec";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public static DataTable GetHospitalIDs()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT Id_ville FROM Ville";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return dt;
        }

        public static string GetHospitalName(int Id_ville)
        {
            string hospitalName = "";

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT Nom_Ville FROM Ville WHERE Id_ville = @Id_ville";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_ville", Id_ville);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        hospitalName = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return hospitalName;
        }
        public static void GetQuartier(ComboBox comboBox)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT Id_quartier FROM Quartier", conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    comboBox.ValueMember = "Id_quartier";
                    comboBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }


        public static string GetQuartierName(int patientId)
        {
            string patientName = "";
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom_quartier FROM Quartier WHERE Id_quartier = @Id_quartier";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id_quartier", patientId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        patientName = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return patientName;
        }




        public static void GetClientId(ComboBox comboBox)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT Id_client FROM client", conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    comboBox.ValueMember = "Id_client";
                    comboBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }


        public static string GetClienyName(int patientId)
        {
            string patientName = "";
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom FROM client WHERE Id_client = @Id_client";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id_client", patientId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        patientName = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return patientName;
        }




        public static void GetCompteurId(ComboBox comboBox)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT Id_compteur FROM compteur", conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    comboBox.ValueMember = "Id_compteur";
                    comboBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }


        public static void GetTechnicienId(ComboBox comboBox)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {

                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id_technicien FROM technicien", conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    comboBox.ValueMember = "id_technicien";
                    comboBox.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }


        public static string GetTechnicienName(int patientId)
        {
            string patientName = "";
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT nom FROM technicien WHERE id_technicien = @id_technicien";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_technicien", patientId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        patientName = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return patientName;
        }


    }
}
