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
    public partial class loginhome : Form
    {
        MySqlConnection conn = databasehelper.GetConnection();
        public loginhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(editor.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Entrez A UserName Or Password");
                return;
            }

            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE editor = @editor AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@editor", editor.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    Form1 hp = new Form1();
                    hp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName Or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editor.Clear();
            password.Clear();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }
    }
}
