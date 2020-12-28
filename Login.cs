using System.Windows.Forms;

namespace Seller_2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login()
        {
            Seller seller = new Seller();
            this.Hide();
            seller.Show();
        }


        private void pass_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void yes_bt_Click(object sender, System.EventArgs e)
        {
            login();
        }

        private void no_bt_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
