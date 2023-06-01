using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishStore.Forms
{
    public partial class MainForm : Form
    {
        private ProductsForm productsForm;

        public MainForm()
        {
            InitializeComponent();
            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            } else if (dialogResult == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Hide();
            authForm.Visible = true;
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productsForm = new ProductsForm();
            productsForm.Visible = true;
        }
    }
}
