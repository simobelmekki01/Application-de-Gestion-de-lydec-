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
    public partial class echnoque : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public echnoque()
        {
            InitializeComponent();
            Displaytechnicien();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(prenom.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO technicien (nom, prenom, specialite) VALUES (@nom, @prenom, @specialite)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@nom", nom.Text);
                    cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                    
                    cmd.Parameters.AddWithValue("@specialite", specialite.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient ajouté avec succès");

                    Displaytechnicien();
                    effacer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        private void effacer()
        {
            id_technicien.Clear();
            nom.Clear();
            prenom.Clear();
            specialite.SelectedIndex = -1;
        }
        private void Displaytechnicien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT * FROM technicien";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                techniciendv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des patients : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_technicien.Text) || string.IsNullOrWhiteSpace(nom.Text) || string.IsNullOrWhiteSpace(prenom.Text) || specialite.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE technicien SET nom = @nom, prenom = @prenom, specialite = @specialite WHERE id_technicien = @id_technicien";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_technicien", Convert.ToInt32(id_technicien.Text));
                    cmd.Parameters.AddWithValue("@nom", nom.Text);
                    cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                    cmd.Parameters.AddWithValue("@specialite", specialite.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Technicien mis à jour avec succès");

                    Displaytechnicien();
                    effacer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_technicien.Text))
            {
                MessageBox.Show("Veuillez sélectionner un technicien à supprimer");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM technicien WHERE id_technicien = @id_technicien";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_technicien", Convert.ToInt32(id_technicien.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Technicien supprimé avec succès");

                    Displaytechnicien();
                    effacer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void technicien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = techniciendv.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    id_technicien.Text = row.Cells["id_technicien"].Value.ToString();
                    nom.Text = row.Cells["nom"].Value.ToString();
                    prenom.Text = row.Cells["prenom"].Value.ToString();
                    specialite.SelectedItem = row.Cells["specialite"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = id_techniciensearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabaseIDcomp(id);
        }


        private void SearchDatabaseIDcomp(string id)
        {
            string query = "SELECT * FROM technicien WHERE id_technicien = @id_technicien";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_technicien", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                techniciendv.DataSource = dataTable;
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            this.Show();
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
