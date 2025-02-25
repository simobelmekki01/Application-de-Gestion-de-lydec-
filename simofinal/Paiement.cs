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
    public partial class Paiement : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();  
        public Paiement()
        {
            InitializeComponent();
            GetFactureId();
        }
        private void GetFactureId()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select ID_Facture from facture", conn);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Facture", typeof(int));
            dt.Load(rdr);

            idFactureComboBox.ValueMember = "ID_Facture";
            idFactureComboBox.DataSource = dt;
            conn.Close();

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
            string query = @"
SELECT
    p.Id_paiement,
    p.date_paiement,
    p.montant_paiement,
    f.Id_facture,
    f.date_facturation,
    f.montant,
    f.statut_paiement,
    f.type_service,
    co.Id_compteur,
    co.date_installation,
    co.type AS type_compteur,
    cl.Id_client,
    cl.nom AS nom_client,
    cl.prénom AS prénom_client,
    cl.adresse AS adresse_client,
    cl.telephone,
    cl.Email,
    q.Id_quartier,
    q.nom_quartier,
    q.code_postal,
    v.Id_ville,
    v.nom_ville
FROM
    Paiement p
INNER JOIN
    Facture f ON p.id_facture = f.Id_facture
INNER JOIN
    Compteur co ON f.Id_compteur = co.Id_compteur
INNER JOIN
    Client cl ON co.Id_client = cl.Id_client
INNER JOIN
    Quartier q ON cl.Id_quartier = q.Id_quartier
INNER JOIN
    Ville v ON q.Id_ville = v.Id_ville
WHERE
    p.id_facture = @id_facture;

";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_facture", Id_quartier);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                paimentdv.DataSource = dataTable;
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

        private void ClearPaiementFields()
        {
            idPaiementTextBox.Clear();
            datePaiementPicker.Value = DateTime.Today;
            montantPaiementTextBox.Clear();
            modePaiementComboBox.SelectedIndex = -1;
            idFactureComboBox.SelectedIndex = -1;
        }

        private void paimentdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = paimentdv.Rows[e.RowIndex];

                idPaiementTextBox.Text = row.Cells["ID_paiement"].Value.ToString();
                datePaiementPicker.Value = Convert.ToDateTime(row.Cells["Date_paiement"].Value);
                montantPaiementTextBox.Text = row.Cells["Montant_paiement"].Value.ToString();
                idFactureComboBox.SelectedValue = row.Cells["ID_facture"].Value;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"INSERT INTO Paiement (Date_paiement, Montant_paiement, ID_facture) 
                             VALUES (@Date_paiement, @Montant_paiement, @ID_facture)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Date_paiement", datePaiementPicker.Value.Date);
                cmd.Parameters.AddWithValue("@Montant_paiement", Convert.ToDecimal(montantPaiementTextBox.Text));
                
                cmd.Parameters.AddWithValue("@ID_facture", Convert.ToInt32(idFactureComboBox.SelectedValue));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paiement ajouté avec succès");
                ClearPaiementFields();
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

                string query = @"UPDATE Paiement 
                             SET Date_paiement = @Date_paiement, 
                                 Montant_paiement = @Montant_paiement, 
                                 ID_facture = @ID_facture 
                             WHERE ID_paiement = @ID_paiement";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Date_paiement", datePaiementPicker.Value.Date);
                cmd.Parameters.AddWithValue("@Montant_paiement", Convert.ToDecimal(montantPaiementTextBox.Text));
                
                cmd.Parameters.AddWithValue("@ID_facture", Convert.ToInt32(idFactureComboBox.SelectedValue));
                cmd.Parameters.AddWithValue("@ID_paiement", Convert.ToInt32(idPaiementTextBox.Text));



                cmd.ExecuteNonQuery();
                MessageBox.Show("Paiement mis à jour avec succès");
                ClearPaiementFields();
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

                string query = "DELETE FROM Paiement WHERE ID_paiement = @ID_paiement";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_paiement", Convert.ToInt32(idPaiementTextBox.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paiement supprimé avec succès");
                ClearPaiementFields();
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

        private void button6_Click(object sender, EventArgs e)
        {
            ClearPaiementFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idFacture = FactureId.Text.Trim();

            if (string.IsNullOrEmpty(idFacture))
            {
                MessageBox.Show("Please enter a facture ID to search.");
                return;
            }

            SearchPaiements(idFacture);
        }
        private void SearchPaiements(string idFacture)
        {
            string query = @"
            SELECT
    p.Id_paiement,
    p.date_paiement,
    p.montant_paiement,
    f.Id_facture,
    f.date_facturation,
    f.montant,
    f.statut_paiement,
    f.type_service
FROM Facture f
INNER JOIN Paiement p ON f.Id_facture = p.id_facture
WHERE p.id_facture =  @id_facture;
        ";

            try
            {

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_facture", idFacture);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dataGridViewPaiements is your DataGridView
                paimentdv.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            ID_paiementsearch.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            string id = ID_paiementsearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }



        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM paiement WHERE ID_paiement = @ID";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                paimentdv.DataSource = dataTable;
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
            FactureId.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
