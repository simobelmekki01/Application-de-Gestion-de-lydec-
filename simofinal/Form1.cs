using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simofinal
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Form1()
        {
            InitializeComponent();
            Populaire();
        }
        void Populaire()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM Ville";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                homedv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "INSERT INTO Ville (nom_ville) VALUES (@nom_ville)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom_ville", nom_ville.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ville ajoutée avec succès");
                Populaire();
                effacer();
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "UPDATE Ville SET nom_ville = @nom_ville WHERE Id_ville = @Id_ville";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom_ville", nom_ville.Text);
                cmd.Parameters.AddWithValue("@Id_ville", Id_ville.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ville mise à jour avec succès");
                Populaire();
                effacer();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "DELETE FROM Ville WHERE Id_ville = @Id_ville";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_ville", Id_ville.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ville supprimée avec succès");
                Populaire();
                effacer();
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
        void effacer()
        {
            Id_ville.Clear();
            nom_ville.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void homedv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = homedv.Rows[e.RowIndex];

                    // Check if the row contains data
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        Id_ville.Text = row.Cells[0].Value.ToString();
                        nom_ville.Text = row.Cells[1].Value.ToString();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = idvillesearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }

        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM Ville WHERE Id_ville = @Id_ville";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_ville", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                homedv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ResetSearch()
        {
            // Clear the search criteria
            idvillesearch.Text = "";

            // Reload the original data
            Populaire();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quartier qa = new Quartier();
            qa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client cl = new Client();
            cl.Show();
        }

        private void lit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Client sv = new Service_Client();
            sv.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compteur co = new Compteur();
            co.Show();
        }

        private void rendezvous_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facture fa = new Facture();
            fa.Show();
        }

        private void medicaux_Click(object sender, EventArgs e)
        {
            this.Show();
            Paiement pa = new Paiement();
        pa.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
            echnoque tc = new echnoque();
            tc.Show();
        }

        private void facture_Click(object sender, EventArgs e)
        {
            this.Show();
            Intervention_Technicien inte = new Intervention_Technicien();
            inte.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginhome log = new loginhome();
            log.Show();
        }
    }
}

