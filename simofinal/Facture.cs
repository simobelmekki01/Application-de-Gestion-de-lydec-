using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simofinal
{
    public partial class Facture : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();  
        public Facture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = IdCompteurSearch.Text.Trim();

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
    f.Id_facture,
    f.date_facturation,
    f.montant,
    f.statut_paiement,
    f.type_service,
    co.Id_compteur,
    co.date_installation,
    co.type AS type_compteur,
    cl.Id_client,
    cl.nom ,
    cl.prénom ,
    cl.adresse ,
    cl.telephone,
    cl.Email,
    q.Id_quartier,
    q.nom_quartier,
    q.code_postal,
    v.Id_ville,
    v.nom_ville
FROM
    Facture f
INNER JOIN
    Compteur co ON f.Id_compteur = co.Id_compteur
INNER JOIN
    Client cl ON co.Id_client = cl.Id_client
INNER JOIN
    Quartier q ON cl.Id_quartier = q.Id_quartier
INNER JOIN
    Ville v ON q.Id_ville = v.Id_ville
WHERE
    f.Id_compteur = @Id_compteur;


";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_compteur", Id_quartier);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                facturedv.DataSource = dataTable;
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
            ID_Facturesearch.Clear();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            databasehelper.GetCompteurId(Id_compteur);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string query = @"INSERT INTO facture (date_facturation, montant, statut_paiement, type_service,Id_compteur) 
                                     VALUES (@date_facturation, @montant, @statut_paiement, @type_service,@Id_compteur)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date_facturation", date_facturation.Value.Date);
                cmd.Parameters.AddWithValue("@montant", montant.Text);
                cmd.Parameters.AddWithValue("@statut_paiement", statut_paiement.Text);
                cmd.Parameters.AddWithValue("@type_service", type_service.Text);
                cmd.Parameters.AddWithValue("@Id_compteur", Convert.ToInt32(Id_compteur.SelectedValue));

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
            ClearFactureFields();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = @"UPDATE facture 
                         SET date_facturation = @date_facturation, 
                             montant = @montant, 
                             statut_paiement = @statut_paiement, 
                             type_service = @type_service,
                             Id_compteur = @Id_compteur 
                         WHERE Id_facture = @Id_facture";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date_facturation", date_facturation.Value.Date);
                cmd.Parameters.AddWithValue("@montant", montant.Text);
                cmd.Parameters.AddWithValue("@statut_paiement", statut_paiement.Text);
                cmd.Parameters.AddWithValue("@type_service", type_service.Text);
                cmd.Parameters.AddWithValue("@Id_compteur", Convert.ToInt32(Id_compteur.SelectedValue));

                cmd.Parameters.AddWithValue("@Id_facture", Convert.ToInt32(Id_facture.Text)); // Assuming Id_facture is a TextBox for the ID of the facture

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
            ClearFactureFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM facture WHERE Id_facture = @Id_facture";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_facture", Convert.ToInt32(Id_facture.Text)); // Assuming Id_facture is a TextBox for the ID of the facture

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
            ClearFactureFields();
        }


        private void ClearFactureFields()
        {
            Id_facture.Clear();
            date_facturation.Value = DateTime.Today;
            montant.Clear();
            statut_paiement.SelectedIndex = -1;
            Id_compteur.SelectedIndex = -1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = ID_Facturesearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }


        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM facture WHERE ID_Facture = @ID";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                facturedv.DataSource = dataTable;
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
            IdCompteurSearch.Clear();
        }

        private void facturedv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = facturedv.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    Id_facture.Text = row.Cells["Id_facture"].Value.ToString();
                    date_facturation.Text = row.Cells["date_facturation"].Value.ToString();
                    montant.Text = row.Cells["montant"].Value.ToString();
                    statut_paiement.SelectedValue = row.Cells["statut_paiement"].Value.ToString();
                    type_service.SelectedValue = row.Cells["type_service"].Value.ToString();
                    Id_compteur.SelectedValue = row.Cells["Id_compteur"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
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
            ClearFactureFields();
        }
    }
}
