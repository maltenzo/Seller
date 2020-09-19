using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Seller_2._0
{
    public partial class Stock : Form
    {
        Seller Padre;
        public Stock(Seller padre)
        {
            InitializeComponent();
             Padre = padre;
        }

        private void volver_bt_Click(object sender, EventArgs e)
        {
            Padre.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Padre.Show();
        }
    }
}
