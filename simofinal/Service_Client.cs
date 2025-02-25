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
    public partial class Service_Client : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Service_Client()
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
    sc.Id_service,
    sc.date_demande,
    sc.description_demande,
    sc.statut,
    c.Id_client,
    c.nom ,
    c.prénom,
    c.adresse,
    c.telephone,
    c.Email,
    q.Id_quartier,
    q.nom_quartier,
    q.code_postal,
    v.Id_ville,
    v.nom_ville
FROM
    Service_Client sc
INNER JOIN
    Client c ON sc.client_id = c.Id_client
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
                servicedv.DataSource = dataTable;
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
        }

        private void quartiersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void client_idsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_quartiersear_Click(object sender, EventArgs e)
        {

        }

        private void Service_Client_Load(object sender, EventArgs e)
        {
            databasehelper.GetClientId(client_id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string query = @"INSERT INTO service_client (date_demande, description_demande, statut, client_id, name_patient) 
                                     VALUES (@date_demande, @description_demande, @statut, @client_id, @name_patient)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date_demande", date_demande.Value.Date);
                cmd.Parameters.AddWithValue("@description_demande", description_demande.Text);
                cmd.Parameters.AddWithValue("@statut", statut.Text);
                cmd.Parameters.AddWithValue("@client_id", Convert.ToInt32(client_id.SelectedValue));
                cmd.Parameters.AddWithValue("@name_patient", name_client.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("you insert the fucturation");
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
            ClearServiceClient();
        }

        private void ClearServiceClient()
        {
            Id_service.Clear();
            date_demande.Value = DateTime.Today;
            description_demande.Clear();
            statut.SelectedIndex = -1;
            client_id.SelectedIndex = -1;
            name_client.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE service_client 
                         SET date_demande = @date_demande, 
                             description_demande = @description_demande, 
                             statut = @statut, 
                             client_id = @client_id, 
                             name_patient = @name_patient 
                         WHERE Id_service = @Id_service";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date_demande", date_demande.Value.Date);
                cmd.Parameters.AddWithValue("@description_demande", description_demande.Text);
                cmd.Parameters.AddWithValue("@statut", statut.Text);
                cmd.Parameters.AddWithValue("@client_id", Convert.ToInt32(client_id.SelectedValue));
                cmd.Parameters.AddWithValue("@name_patient", name_client.Text);
                cmd.Parameters.AddWithValue("@Id_service", Convert.ToInt32(Id_service.Text)); // Assuming Id_service is a TextBox for the ID of the facture

                cmd.ExecuteNonQuery();
                MessageBox.Show("Facture mise à jour avec succès");
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
            ClearServiceClient();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM service_client WHERE Id_service = @Id_service";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_service", Convert.ToInt32(Id_service.Text)); // Assuming Id_service is a TextBox for the ID of the facture

                cmd.ExecuteNonQuery();
                MessageBox.Show("Facture supprimée avec succès");
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
            ClearServiceClient();
        }

        private void client_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (client_id.SelectedValue != null)
            {
                int patientId = Convert.ToInt32(client_id.SelectedValue);
                string patientName = databasehelper.GetClienyName(patientId);
                name_client.Text = patientName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = idserviceclient.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }

        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM service_client WHERE Id_service = @Id_service";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_service", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                servicedv.DataSource = dataTable;
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

        private void servicedv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = servicedv.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    Id_service.Text = row.Cells["Id_service"].Value.ToString();
                    date_demande.Text = row.Cells["date_demande"].Value.ToString();
                    description_demande.Text = row.Cells["description_demande"].Value.ToString();
                    statut.SelectedValue = row.Cells["statut"].Value.ToString();
                    client_id.SelectedValue = row.Cells["Id_client"].Value;
                    name_client.Text = row.Cells["nom"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Id_service_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearServiceClient();
        }
    }
}
