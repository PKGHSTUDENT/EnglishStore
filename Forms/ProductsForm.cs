using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EnglishStore.Forms
{
    public partial class ProductsForm : Form
    {
        private DataGridViewColumn _col;

        public ProductsForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        public void ReloadDataGridView()
        {
            this.manufacturerTableAdapter.Fill(this.englishStoreDataSet1.Manufacturer);
            this.productTableAdapter.Fill(this.englishStoreDataSet1.Product);
            toolStripStatusLabel1.Text = $"Count products: {dataGridViewProduct.Rows.Count - 1}";
        }

        private void ProductsForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'englishStoreDataSet1.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.englishStoreDataSet1.Manufacturer);
            // TODO: This line of code loads data into the 'englishStoreDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.englishStoreDataSet1.Product);

            toolStripStatusLabel1.Text = $"Count products: {dataGridViewProduct.Rows.Count - 1}";
        }

        private void backToMainForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void editPostButton_Click(object sender, System.EventArgs e)
        {

        }

        private void addPostButton_Click(object sender, System.EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Owner = this;
            addProductForm.ShowDialog(this);
        }

        private void deletePostButton_Click(object sender, System.EventArgs e)
        {

        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < dataGridViewProduct.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewProduct.RowCount - 1; j++)
                {
                    dataGridViewProduct[i, j].Style.BackColor = Color.White;
                    dataGridViewProduct[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < dataGridViewProduct.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewProduct.RowCount - 1; j++)
                {
                    if (dataGridViewProduct[i, j].Value.ToString().IndexOf(searchTextBox.Text) == -1)
                    {
                        dataGridViewProduct[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridViewProduct[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void descRatioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _col = new DataGridViewColumn();
            _col = dataGridViewProduct.Columns[1];
            dataGridViewProduct.Sort(_col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void ascRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _col = new DataGridViewColumn();
            _col = dataGridViewProduct.Columns[1];
            dataGridViewProduct.Sort(_col, System.ComponentModel.ListSortDirection.Ascending);
        }

        private void filtrationButton_Click(object sender, System.EventArgs e)
        {
            productBindingSource.Filter = string.Format("[ManufacturerId] = {0}", filtrationComboBox.SelectedValue);
        }

        private void showAllButton_Click(object sender, System.EventArgs e)
        {
            productBindingSource.RemoveFilter();
        }
    }
}
