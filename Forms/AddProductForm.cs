using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace EnglishStore.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void AddProductForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'englishStoreDataSet1.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.englishStoreDataSet1.Manufacturer);

        }
        
        private void addButton_Click(object sender, System.EventArgs e)
        {
            var name = nameTextBox.Text;
            var imagePath = imagePathTextBox.Text;
            var manufacturerID = manufacturerNameComboBox.SelectedValue;
            var isActive = (isActiveCheckBox.Checked) ? 1 : 0;
            double price = Double.Parse(priceTextBox.Text);

            if (nameTextBox.Text.Length < 0 || 
                priceTextBox.Text.Length < 0 ||
                imagePathTextBox.Text.Length < 0)
            {
                MessageBox.Show("Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Connection.connection))
            {
                connection.Open();

                string query = "INSERT INTO [dbo].[Product] ([dbo].[Name], [dbo].[Image], [dbo].[ManufacturerID], [dbo].[IsActive], [dbo].[Price]) VALUES (@name, @imagepath, @manufacturerID, @isActive, @price)";
                
                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@imagepath", imagePath);
                sqlCommand.Parameters.AddWithValue("@manufacturerID", manufacturerID);
                sqlCommand.Parameters.AddWithValue("@isActive", isActive);
                sqlCommand.Parameters.AddWithValue("@price", price);

                sqlCommand.ExecuteNonQuery();
            }

            ProductsForm owner = this.Owner as ProductsForm;
            owner.ReloadDataGridView();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if (priceTextBox.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                if (((sender as TextBox).Text.IndexOf(',') != -1) && priceTextBox.Text.Length > 0)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
