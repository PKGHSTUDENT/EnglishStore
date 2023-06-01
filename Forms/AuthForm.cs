using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishStore.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginTextBox.Text;
            string passwordUser = passwordTextBox.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connection))
                {
                    connection.Open();
                    string query = "SELECT * FROM [dbo].[User] WHERE [login] = @login AND [password] = @password";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@login", loginUser);
                    sqlCommand.Parameters.AddWithValue("@password", passwordUser);
                    
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Auth successful", "Auth", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Wrong login or password", "Auth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        reader.Close();
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            MainForm mainForm = new MainForm();
            mainForm.Owner = this;
            this.Hide();
            mainForm.Show();
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
