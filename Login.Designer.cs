namespace CapaInterfaz
{
    partial class Login
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
            this.Loglabel1 = new System.Windows.Forms.Label();
            this.logsipgaa = new System.Windows.Forms.Label();
            this.LogCarroCompras = new FontAwesome.Sharp.IconPictureBox();
            this.LogTexBoxtUsuario = new System.Windows.Forms.TextBox();
            this.LogTexBoxContrasena = new System.Windows.Forms.TextBox();
            this.LogLabelusuario = new System.Windows.Forms.Label();
            this.LoglabelContrasena = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogCarroCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // Loglabel1
            // 
            this.Loglabel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Loglabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Loglabel1.Location = new System.Drawing.Point(0, 0);
            this.Loglabel1.Name = "Loglabel1";
            this.Loglabel1.Size = new System.Drawing.Size(275, 319);
            this.Loglabel1.TabIndex = 0;
            // 
            // logsipgaa
            // 
            this.logsipgaa.AutoSize = true;
            this.logsipgaa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logsipgaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsipgaa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logsipgaa.Location = new System.Drawing.Point(39, 218);
            this.logsipgaa.Name = "logsipgaa";
            this.logsipgaa.Size = new System.Drawing.Size(197, 54);
            this.logsipgaa.TabIndex = 1;
            this.logsipgaa.Text = "SIPGAA";
            // 
            // LogCarroCompras
            // 
            this.LogCarroCompras.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogCarroCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogCarroCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.LogCarroCompras.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.LogCarroCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogCarroCompras.IconSize = 155;
            this.LogCarroCompras.Location = new System.Drawing.Point(48, 68);
            this.LogCarroCompras.Name = "LogCarroCompras";
            this.LogCarroCompras.Size = new System.Drawing.Size(172, 155);
            this.LogCarroCompras.TabIndex = 2;
            this.LogCarroCompras.TabStop = false;
            // 
            // LogTexBoxtUsuario
            // 
            this.LogTexBoxtUsuario.Location = new System.Drawing.Point(326, 81);
            this.LogTexBoxtUsuario.Name = "LogTexBoxtUsuario";
            this.LogTexBoxtUsuario.Size = new System.Drawing.Size(173, 20);
            this.LogTexBoxtUsuario.TabIndex = 3;
            // 
            // LogTexBoxContrasena
            // 
            this.LogTexBoxContrasena.Location = new System.Drawing.Point(326, 141);
            this.LogTexBoxContrasena.Name = "LogTexBoxContrasena";
            this.LogTexBoxContrasena.PasswordChar = '*';
            this.LogTexBoxContrasena.Size = new System.Drawing.Size(173, 20);
            this.LogTexBoxContrasena.TabIndex = 4;
            // 
            // LogLabelusuario
            // 
            this.LogLabelusuario.AutoSize = true;
            this.LogLabelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabelusuario.Location = new System.Drawing.Point(322, 58);
            this.LogLabelusuario.Name = "LogLabelusuario";
            this.LogLabelusuario.Size = new System.Drawing.Size(72, 20);
            this.LogLabelusuario.TabIndex = 5;
            this.LogLabelusuario.Text = "Usuario: ";
            // 
            // LoglabelContrasena
            // 
            this.LoglabelContrasena.AutoSize = true;
            this.LoglabelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoglabelContrasena.Location = new System.Drawing.Point(322, 118);
            this.LoglabelContrasena.Name = "LoglabelContrasena";
            this.LoglabelContrasena.Size = new System.Drawing.Size(100, 20);
            this.LoglabelContrasena.TabIndex = 6;
            this.LoglabelContrasena.Text = "Contraseña: ";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 21;
            this.iconButton1.Location = new System.Drawing.Point(326, 197);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(173, 36);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "INGRESAR";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Red;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 21;
            this.iconButton2.Location = new System.Drawing.Point(326, 249);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(173, 36);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "CANCELAR";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 319);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LoglabelContrasena);
            this.Controls.Add(this.LogLabelusuario);
            this.Controls.Add(this.LogTexBoxContrasena);
            this.Controls.Add(this.LogTexBoxtUsuario);
            this.Controls.Add(this.LogCarroCompras);
            this.Controls.Add(this.logsipgaa);
            this.Controls.Add(this.Loglabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LogCarroCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loglabel1;
        private System.Windows.Forms.Label logsipgaa;
        private FontAwesome.Sharp.IconPictureBox LogCarroCompras;
        private System.Windows.Forms.TextBox LogTexBoxtUsuario;
        private System.Windows.Forms.TextBox LogTexBoxContrasena;
        private System.Windows.Forms.Label LogLabelusuario;
        private System.Windows.Forms.Label LoglabelContrasena;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}