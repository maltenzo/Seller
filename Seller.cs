using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Seller_2._0.Clases;

namespace Seller_2._0
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Stock")
            {
                stock_window();
            }else if (e.ClickedItem.Text == "Cambiar usuario")
            {
                login_window();
            }else if(e.ClickedItem.Text == "Cargar DB")
            {
                //string path = load_excel();
                ExcelDb.crear_db(); 

            }
        }

        private string load_excel()
        {
            string path = "";
            //openFileDialog1.Filter = "xlsx";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                 path = openFileDialog1.FileName;
             }
            return path;
        }


        private void Seller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stock_window()
        {
            Stock stock = new Stock(this);
            this.Hide();
            stock.Show();
        }

        private void login_window()
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
           
        }

        private void Seller_Resize(object sender, EventArgs e)
        {
            PerformAutoScale();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
