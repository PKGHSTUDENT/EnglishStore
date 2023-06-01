using EnglishStore.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishStore
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();

            this.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);

            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
        }



        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
