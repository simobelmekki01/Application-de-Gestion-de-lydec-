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
    public partial class Intervention_Technicien : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Intervention_Technicien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idcountersearch.Text.Trim();
            string idtech = idtechniiensearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchMedcineByHopitalId(id, idtech);
        }

        private void SearchMedcineByHopitalId(string Id_quartier, string ID_tech)
        {
            string query = @"
    
    SELECT
    it.id_intervention,
    it.date_intervention,
    it.description,
    t.id_technicien,
    t.nom ,
    t.prenom ,
    t.specialite,
    c.id_compteur,
    c.date_installation,
    c.type AS type_compteur,
    cl.id_client,
    cl.nom ,
    cl.prénom ,
    cl.adresse ,
    cl.telephone,
    cl.Email,
    q.id_quartier,
    q.nom_quartier,
    q.code_postal,
    v.id_ville,
    v.nom_ville
FROM
    Intervention_Technicien it
INNER JOIN
    Technicien t ON it.id_technicien = t.id_technicien
INNER JOIN
    Compteur c ON it.id_compteur = c.id_compteur
INNER JOIN
    Client cl ON c.id_client = cl.id_client
INNER JOIN
    Quartier q ON cl.id_quartier = q.id_quartier
INNER JOIN
    Ville v ON q.id_ville = v.id_ville
WHERE
    it.id_compteur = @id_compteur
    AND it.id_technicien = @id_technicien;



";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_compteur", Id_quartier);
                command.Parameters.AddWithValue("@id_technicien", ID_tech);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                interdv.DataSource = dataTable;
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
            id_interventionsearch.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = id_interventionsearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }


        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM intervention_technicien WHERE id_intervention = @ID";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                interdv.DataSource = dataTable;
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
            idcountersearch.Clear();
            idtechniiensearch.Clear();
        }

        private void Intervention_Technicien_Load(object sender, EventArgs e)
        {
            databasehelper.GetCompteurId(Id_compteur);
            databasehelper.GetTechnicienId(idtech);
        }

        private void idtech_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idtech.SelectedValue != null)
            {
                int patientId = Convert.ToInt32(idtech.SelectedValue);
                string patientName = databasehelper.GetTechnicienName(patientId);
                nom.Text = patientName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(description.Text) || Id_compteur.SelectedValue == null || idtech.SelectedValue == null || string.IsNullOrWhiteSpace(nom.Text))
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
                    string query = "INSERT INTO Intervention_Technicien (date_intervention, description, Id_compteur, Id_technicien, nom) VALUES (@date_intervention, @description, @id_compteur, @id_technicien, @nom)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@date_intervention", date_intervention.Value);
                    cmd.Parameters.AddWithValue("@description", description.Text);
                    cmd.Parameters.AddWithValue("@id_compteur", Convert.ToInt32(Id_compteur.SelectedValue));
                    cmd.Parameters.AddWithValue("@id_technicien", Convert.ToInt32(idtech.SelectedValue));
                    cmd.Parameters.AddWithValue("@nom", nom.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention ajoutée avec succès");

                    
                    ClearInterventionFields();
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_intervention.Text) || string.IsNullOrWhiteSpace(description.Text) || Id_compteur.SelectedValue == null || idtech.SelectedValue == null || string.IsNullOrWhiteSpace(nom.Text))
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
                    string query = "UPDATE Intervention_Technicien SET date_intervention = @date_intervention, description = @description, Id_compteur = @id_compteur, Id_technicien = @id_technicien, nom = @nom WHERE id_intervention = @id_intervention";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_intervention", Convert.ToInt32(id_intervention.Text));
                    cmd.Parameters.AddWithValue("@date_intervention", date_intervention.Value);
                    cmd.Parameters.AddWithValue("@description", description.Text);
                    cmd.Parameters.AddWithValue("@id_compteur", Convert.ToInt32(Id_compteur.SelectedValue));
                    cmd.Parameters.AddWithValue("@id_technicien", Convert.ToInt32(idtech.SelectedValue));
                    cmd.Parameters.AddWithValue("@nom", nom.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention mise à jour avec succès");

                    ClearInterventionFields();
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

        private void ClearInterventionFields()
        {
            id_intervention.Clear();
            date_intervention.Value = DateTime.Today;
            description.Clear();
            Id_compteur.SelectedIndex = -1;
            idtech.SelectedIndex = -1;
            nom.Clear();
        }

        private void interdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = interdv.Rows[e.RowIndex];

                    // Populate textboxes with data from the selected row
                    id_intervention.Text = row.Cells["id_intervention"].Value.ToString();
                    date_intervention.Value = Convert.ToDateTime(row.Cells["date_intervention"].Value);
                    description.Text = row.Cells["description"].Value.ToString();
                    Id_compteur.SelectedValue = row.Cells["Id_compteur"].Value;
                    idtech.SelectedValue = row.Cells["Id_technicien"].Value;
                    nom.Text = row.Cells["nom"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_intervention.Text))
            {
                MessageBox.Show("Veuillez sélectionner une intervention à supprimer");
            }
            else
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM Intervention_Technicien WHERE id_intervention = @id_intervention";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_intervention", Convert.ToInt32(id_intervention.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Intervention supprimée avec succès");


                    ClearInterventionFields();
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click_1(object sender, EventArgs e)
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

        private void button11_Click_1(object sender, EventArgs e)
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
            this.Hide();
            Paiement pa = new Paiement();
            pa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            echnoque tc = new echnoque();
            tc.Show();
        }

        private void facture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Intervention_Technicien inte = new Intervention_Technicien();
            inte.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginhome log = new loginhome();
            log.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearInterventionFields();
        }
    }
}
