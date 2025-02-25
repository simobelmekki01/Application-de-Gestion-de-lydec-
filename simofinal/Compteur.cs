using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class Compteur : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Compteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = client_idsearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchMedcineByHopitalId(id);
        }

        private void SearchMedcineByHopitalId(string Id_quartier)
        {
            string query = @"SELECT
    c.Id_client,
    c.nom,
    c.prénom ,
    c.adresse,
    c.telephone,
    c.Email,
    q.Id_quartier,
    q.nom_quartier,
    q.code_postal,
    v.Id_ville,
    v.nom_ville,
    co.Id_compteur,
    co.date_installation,
    co.type
FROM
    Compteur co
INNER JOIN
    Client c ON co.Id_client = c.Id_client
INNER JOIN
    Quartier q ON c.Id_quartier = q.Id_quartier
INNER JOIN
    Ville v ON q.Id_ville = v.Id_ville
WHERE
    c.Id_client = @Id_client;

";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_client", Id_quartier);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                compteurdv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            Id_compteursearch.Clear();
        }

        private void Compteur_Load(object sender, EventArgs e)
        {
            databasehelper.GetClientId(Id_client);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = Id_compteursearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabaseIDcomp(id);
        }
        private void SearchDatabaseIDcomp(string id)
        {
            string query = "SELECT * FROM compteur WHERE Id_compteur = @Id_compteur";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_compteur", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                compteurdv.DataSource = dataTable;
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
            client_idsearch.Clear();
            
        }
        private void client_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Id_client.SelectedValue != null)
            {
                int patientId = Convert.ToInt32(Id_client.SelectedValue);
                string patientName = databasehelper.GetClienyName(patientId);
                nom.Text = patientName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(type.Text) || Id_client.SelectedValue == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string query = "INSERT INTO compteur (date_installation,type, Id_client, nom) VALUES (@date_installation,@type, @Id_client, @nom)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date_installation", date_installation.Value.Date);
                    cmd.Parameters.AddWithValue("@type", type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Id_client", Convert.ToInt32(Id_client.SelectedValue));
                    cmd.Parameters.AddWithValue("@nom", nom.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lit ajouté avec succès");
                    efface();

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
        private void efface()
        {
            Id_compteur.Clear();
            date_installation.Value = DateTime.Today;
            type.SelectedIndex = -1;
            Id_client.SelectedIndex = -1;
            nom.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(type.Text) || Id_client.SelectedValue == null || string.IsNullOrWhiteSpace(Id_compteur.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string query = @"UPDATE compteur 
                                 SET date_installation = @date_installation, 
                                     type = @type, 
                                     Id_client = @Id_client, 
                                     nom = @nom 
                                 WHERE Id_compteur = @id_compteur";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Replace with actual values or variables from your form or application logic
                    cmd.Parameters.AddWithValue("@id_compteur", Convert.ToInt32(Id_compteur.Text)); // Assuming Id_compteur is a TextBox or similar control
                    cmd.Parameters.AddWithValue("@date_installation", date_installation.Value.Date);
                    cmd.Parameters.AddWithValue("@type", type.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Id_client", Convert.ToInt32(Id_client.SelectedValue));
                    cmd.Parameters.AddWithValue("@nom", nom.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lit ajouté avec succès");
                    efface();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Id_compteur.Text))
            {
                MessageBox.Show("Veuillez entrer l'ID du lit à supprimer.");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string query = "DELETE FROM compteur WHERE Id_compteur = @Id_compteur";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id_compteur", Convert.ToInt32(Id_compteur.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    efface();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Lit supprimé avec succès");

                    }
                    else
                    {
                        MessageBox.Show("Aucun lit trouvé avec cet ID.");
                    }

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

        private void button6_Click(object sender, EventArgs e)
        {
            efface();
        }

        private void compteurdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = compteurdv.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    Id_compteur.Text = row.Cells["ID_compteur"].Value.ToString(); // Replace with actual column name
                    date_installation.Value = Convert.ToDateTime(row.Cells["date_installation"].Value); // Replace with actual column name
                    type.SelectedItem = row.Cells["type"].Value.ToString(); // Replace with actual column name

                    // Assuming Id_client is a ComboBox or similar control
                    int clientId = Convert.ToInt32(row.Cells["Id_client"].Value);
                    Id_client.SelectedValue = clientId;

                    nom.Text = row.Cells["nom"].Value.ToString(); // Replace with actual column name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; ;
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quartier qa = new Quartier();
            qa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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
