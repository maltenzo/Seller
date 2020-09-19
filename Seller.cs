using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            Stock stock = new Stock(this);
            this.Hide();
            stock.Show();
        }

        private void Seller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
