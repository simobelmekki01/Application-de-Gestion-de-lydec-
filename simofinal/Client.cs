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
    public partial class Client : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            databasehelper.GetQuartier(Id_quartier);
        }

        private void Id_quartier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Id_quartier.SelectedValue != null)
            {
                int patientId = Convert.ToInt32(Id_quartier.SelectedValue);
                string patientName = databasehelper.GetQuartierName(patientId);
                nom_quartier.Text = patientName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "INSERT INTO Client (nom, prénom, adresse, telephone,email,Id_quartier,nom_quartier) VALUES (@nom, @prénom, @adresse, @telephone,@email,@Id_quartier,@nom_quartier)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prénom", prénom.Text);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@Id_quartier", Convert.ToInt32(Id_quartier.SelectedValue));
                cmd.Parameters.AddWithValue("@nom_quartier", nom_quartier.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quartier ajouté avec succès");
                clearclientfield();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idquartiersearchi.Text.Trim();

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
                            c.nom ,
                            c.prénom,
                            c.adresse,
                            c.telephone,
                            c.email,
                            q.Id_quartier,
                            q.nom_quartier,
                            q.code_postal,
                            v.Id_ville,
                            v.nom_ville
                        FROM
                            Client c
                        INNER JOIN
                            Quartier q ON c.Id_quartier = q.Id_quartier
                        INNER JOIN
                            Ville v ON q.Id_ville = v.Id_ville
                        WHERE
                            q.Id_quartier = @Id_quartier;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_quartier", Id_quartier);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                clientdv.DataSource = dataTable;
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
            idclientsearch.Clear();
        }

        private void idquartiersearchi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_quartiersear_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = idclientsearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }


        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM client WHERE Id_client = @Id_client";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_client", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                clientdv.DataSource = dataTable;
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
            idquartiersearchi.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Client SET nom = @nom, prénom = @prénom, adresse = @adresse, telephone = @telephone, email = @email, Id_quartier = @Id_quartier, nom_quartier = @nom_quartier WHERE Id_client = @Id_client";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_client", Id_client.Text);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prénom", prénom.Text);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@Id_quartier", Id_quartier.SelectedValue);
                cmd.Parameters.AddWithValue("@nom_quartier", nom_quartier.Text);
                MessageBox.Show("you modifier the client");
                cmd.ExecuteNonQuery();
                clearclientfield();
            }
            catch(Exception ex)
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "DELETE FROM client WHERE Id_client = @Id_client";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_client", Convert.ToInt32(Id_client.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("client supprimé avec succès");
                clearclientfield();
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

        void clearclientfield() {
            Id_client.Clear();
            nom.Clear();
            prénom.Clear();
            adresse.Clear();
            telephone.Clear();
            email.Clear();
            Id_quartier.SelectedIndex = -1;
            nom_quartier.Clear();
        }

        private void clientdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = clientdv.Rows[e.RowIndex];

                Id_client.Text = row.Cells["Id_client"].Value.ToString();
                nom.Text = row.Cells["nom"].Value.ToString();
                prénom.Text = row.Cells["prénom"].Value.ToString();
                adresse.Text = row.Cells["adresse"].Value.ToString();
                telephone.Text = row.Cells["telephone"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                Id_quartier.SelectedValue = Convert.ToInt32(row.Cells["Id_quartier"].Value);
                nom_quartier.Text = row.Cells["nom_quartier"].Value.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearclientfield();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quartier qa = new Quartier();
            qa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void lit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Client sv = new Service_Client();
            sv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
