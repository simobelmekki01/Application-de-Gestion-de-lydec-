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
    public partial class Quartier : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public Quartier()
        {
            InitializeComponent();
            LoadHopitals();
        }
        private void LoadHopitals()
        {
            DataTable dtHospitalIDs = databasehelper.GetHospitalIDs();

            if (dtHospitalIDs != null && dtHospitalIDs.Rows.Count > 0)
            {
                Id_ville.ValueMember = "Id_ville";
                Id_ville.DisplayMember = "Id_ville";
                Id_ville.DataSource = dtHospitalIDs;

                if (Id_ville.Items.Count > 0)
                {
                    Id_ville.SelectedIndex = 0;
                    // Trigger the display of hospital name
                    DisplayHopitalNamr();
                }
            }
            else
            {
                MessageBox.Show("No hospital IDs found.");
            }
        }
        private void DisplayHopitalNamr()
        {
            if (Id_ville.SelectedValue != null)
            {
                int hospitalId = Convert.ToInt32(Id_ville.SelectedValue);
                string hospitalName = databasehelper.GetHospitalName(hospitalId);
                nom_ville.Text = hospitalName; // Assuming hopname is a TextBox or similar control
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "INSERT INTO Quartier (nom_quartier, code_postal, Id_ville, nom_ville) VALUES (@nom_quartier, @code_postal, @Id_ville, @nom_ville)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom_quartier", nom_quartier.Text);
                cmd.Parameters.AddWithValue("@code_postal", code_postal.Text);
                cmd.Parameters.AddWithValue("@Id_ville", Convert.ToInt32(Id_ville.SelectedValue));
                cmd.Parameters.AddWithValue("@nom_ville", nom_ville.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quartier ajouté avec succès");
                ClearQuartierFields();
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

        private void Id_ville_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayHopitalNamr();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "UPDATE Quartier SET nom_quartier = @nom_quartier, code_postal = @code_postal, Id_ville = @Id_ville, nom_ville = @nom_ville WHERE Id_quartier = @Id_quartier";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom_quartier", nom_quartier.Text);
                cmd.Parameters.AddWithValue("@code_postal", code_postal.Text);
                cmd.Parameters.AddWithValue("@Id_ville", Convert.ToInt32(Id_ville.SelectedValue));
                cmd.Parameters.AddWithValue("@nom_ville", nom_ville.Text);
                cmd.Parameters.AddWithValue("@Id_quartier", Convert.ToInt32(Id_quartier.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quartier mis à jour avec succès");
                ClearQuartierFields();
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
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "DELETE FROM Quartier WHERE Id_quartier = @Id_quartier";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_quartier", Convert.ToInt32(Id_quartier.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quartier supprimé avec succès");
                ClearQuartierFields();
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

        private void quartiersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = quartiersDGV.Rows[e.RowIndex];

                Id_quartier.Text = row.Cells["Id_quartier"].Value.ToString();
                nom_quartier.Text = row.Cells["nom_quartier"].Value.ToString();
                code_postal.Text = row.Cells["code_postal"].Value.ToString();
                Id_ville.SelectedValue = row.Cells["Id_ville"].Value;
                nom_ville.Text = row.Cells["nom_ville"].Value.ToString();
            }
        }

        private void ClearQuartierFields()
        {
            Id_quartier.Clear();
            nom_quartier.Clear();
            code_postal.Clear();
            Id_ville.SelectedIndex = -1;
            nom_ville.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = id_Quartiersearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchDatabase(id);
        }

        private void SearchDatabase(string id)
        {
            string query = "SELECT * FROM Quartier WHERE Id_quartier = @Id_quartier";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_quartier", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                quartiersDGV.DataSource = dataTable;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idvillesearch.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID to search.");
                return;
            }

            SearchMedcineByHopitalId(id);
        }



        private void SearchMedcineByHopitalId(string idVille)
        {
            string query = @"
        SELECT 
            q.Id_quartier,
            q.nom_quartier,
            q.code_postal,
            v.Id_ville,
            v.nom_ville
        FROM 
            Quartier q
        INNER JOIN 
            Ville v ON q.Id_ville = v.Id_ville
        WHERE 
            v.Id_ville = @Id_ville;
    ";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id_ville", idVille);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Assuming dgvData is your DataGridView
                quartiersDGV.DataSource = dataTable;
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void facture_Click(object sender, EventArgs e)
        {
            this.Show();
            Intervention_Technicien inte = new Intervention_Technicien();
            inte.Show();
        }

        private void Quartier_Load(object sender, EventArgs e)
        {

        }

        private void accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
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
            Client cl = new Client();
            cl.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginhome log = new loginhome();
            log.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearQuartierFields();
        }
    }

}
