namespace Seller_2._0
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yes_bt = new System.Windows.Forms.Button();
            this.no_bt = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes_bt
            // 
            this.yes_bt.Location = new System.Drawing.Point(161, 175);
            this.yes_bt.Name = "yes_bt";
            this.yes_bt.Size = new System.Drawing.Size(75, 31);
            this.yes_bt.TabIndex = 0;
            this.yes_bt.Text = "Aceptar";
            this.yes_bt.UseVisualStyleBackColor = true;
            this.yes_bt.Click += new System.EventHandler(this.yes_bt_Click);
            // 
            // no_bt
            // 
            this.no_bt.Location = new System.Drawing.Point(48, 175);
            this.no_bt.Name = "no_bt";
            this.no_bt.Size = new System.Drawing.Size(75, 31);
            this.no_bt.TabIndex = 1;
            this.no_bt.Text = "Cancelar";
            this.no_bt.UseVisualStyleBackColor = true;
            this.no_bt.Click += new System.EventHandler(this.no_bt_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(48, 47);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(188, 23);
            this.name_box.TabIndex = 2;
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(48, 29);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(50, 15);
            this.user_lbl.TabIndex = 3;
            this.user_lbl.Text = "Usuario:";
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(48, 118);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(188, 23);
            this.pass_box.TabIndex = 4;
            this.pass_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_box_KeyDown);
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(48, 100);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(70, 15);
            this.pass_lbl.TabIndex = 5;
            this.pass_lbl.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 218);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.no_bt);
            this.Controls.Add(this.yes_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_bt;
        private System.Windows.Forms.Button no_bt;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label pass_lbl;
    }
}

