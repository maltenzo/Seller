namespace Seller_2._0
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.volver_bt = new System.Windows.Forms.Button();
            this.agregar_bt = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoria_box = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // volver_bt
            // 
            this.volver_bt.Location = new System.Drawing.Point(12, 415);
            this.volver_bt.Name = "volver_bt";
            this.volver_bt.Size = new System.Drawing.Size(75, 23);
            this.volver_bt.TabIndex = 0;
            this.volver_bt.Text = "Volver";
            this.volver_bt.UseVisualStyleBackColor = true;
            this.volver_bt.Click += new System.EventHandler(this.volver_bt_Click);
            // 
            // agregar_bt
            // 
            this.agregar_bt.Location = new System.Drawing.Point(3, 167);
            this.agregar_bt.Name = "agregar_bt";
            this.agregar_bt.Size = new System.Drawing.Size(75, 26);
            this.agregar_bt.TabIndex = 1;
            this.agregar_bt.Text = "Agregar";
            this.agregar_bt.UseVisualStyleBackColor = true;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(1, 27);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(129, 23);
            this.name_box.TabIndex = 2;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(1, 81);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(129, 23);
            this.price_box.TabIndex = 3;
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(1, 9);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(34, 15);
            this.item.TabIndex = 4;
            this.item.Text = "Item:";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(1, 63);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(43, 15);
            this.Precio.TabIndex = 5;
            this.Precio.Text = "Precio:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 448);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoria_box
            // 
            this.categoria_box.Location = new System.Drawing.Point(1, 138);
            this.categoria_box.Name = "categoria_box";
            this.categoria_box.Size = new System.Drawing.Size(129, 23);
            this.categoria_box.TabIndex = 7;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(1, 120);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(61, 15);
            this.categoria.TabIndex = 8;
            this.categoria.Text = "Categoria:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.categoria_box);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.item);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.agregar_bt);
            this.Controls.Add(this.volver_bt);
            this.Name = "Stock";
            this.Text = "Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volver_bt;
        private System.Windows.Forms.Button agregar_bt;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox categoria_box;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.TextBox textBox1;
    }
}