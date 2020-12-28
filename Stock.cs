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

        private bool text_boxs_complete()
        {
            bool res = (name_box.Text.Length > 0) && (price_box.Text.Length > 0) && 
                       (categoria_box.Text.Length > 0) && (cantidad_box.Text.Length > 0);
            return res;
        }
        private void agregar_bt_Click(object sender, EventArgs e)
        {
            if (!text_boxs_complete())
            {
                
                MessageBox.Show("Debes completar todos los campos");
            }
            else
            {
                string p = name_box.Text;
                string c =categoria_box.Text;
                double precio = System.Convert.ToDouble(price_box.Text);
                Producto producto = new Producto(p, c, precio);
                agregar_func(producto);
            }
        }

        private void agregar_func(Producto p)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
