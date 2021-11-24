
namespace Sonora_Creativa
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new CustomControls.RJControls.roundbutton();
            this.roundbutton1 = new CustomControls.RJControls.roundbutton();
            this.lblContra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundbutton2 = new CustomControls.RJControls.roundbutton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoftwareInterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtContraseña.Location = new System.Drawing.Point(63, 272);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(250, 29);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(63, 198);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 29);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged_1);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUsuario.Location = new System.Drawing.Point(60, 173);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(100, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(176, 33);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Iniciar Sesíon";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // roundbutton1
            // 
            this.roundbutton1.BackColor = System.Drawing.Color.GhostWhite;
            this.roundbutton1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.roundbutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton1.BorderRadius = 10;
            this.roundbutton1.BorderSize = 2;
            this.roundbutton1.Enabled = false;
            this.roundbutton1.FlatAppearance.BorderSize = 0;
            this.roundbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundbutton1.ForeColor = System.Drawing.Color.White;
            this.roundbutton1.Location = new System.Drawing.Point(48, 65);
            this.roundbutton1.Name = "roundbutton1";
            this.roundbutton1.Size = new System.Drawing.Size(285, 380);
            this.roundbutton1.TabIndex = 10;
            this.roundbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundbutton1.TextColor = System.Drawing.Color.White;
            this.roundbutton1.UseVisualStyleBackColor = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblContra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblContra.Location = new System.Drawing.Point(60, 247);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 11;
            this.lblContra.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(126, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "¿Aún no estás registrado?";
            // 
            // roundbutton2
            // 
            this.roundbutton2.BackColor = System.Drawing.Color.White;
            this.roundbutton2.BackgroundColor = System.Drawing.Color.White;
            this.roundbutton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundbutton2.BorderRadius = 0;
            this.roundbutton2.BorderSize = 0;
            this.roundbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundbutton2.FlatAppearance.BorderSize = 0;
            this.roundbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundbutton2.ForeColor = System.Drawing.Color.Black;
            this.roundbutton2.Location = new System.Drawing.Point(154, 399);
            this.roundbutton2.Name = "roundbutton2";
            this.roundbutton2.Size = new System.Drawing.Size(71, 24);
            this.roundbutton2.TabIndex = 14;
            this.roundbutton2.Text = "Registrarse";
            this.roundbutton2.TextColor = System.Drawing.Color.Black;
            this.roundbutton2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Sonora_Creativa.Properties.Resources.nortec;
            this.pictureBox1.Location = new System.Drawing.Point(82, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoftwareInterno
            // 
            this.lblSoftwareInterno.AutoSize = true;
            this.lblSoftwareInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareInterno.ForeColor = System.Drawing.Color.White;
            this.lblSoftwareInterno.Location = new System.Drawing.Point(59, 19);
            this.lblSoftwareInterno.Name = "lblSoftwareInterno";
            this.lblSoftwareInterno.Size = new System.Drawing.Size(254, 20);
            this.lblSoftwareInterno.TabIndex = 16;
            this.lblSoftwareInterno.Text = "Software de Inventario Interno";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(383, 468);
            this.Controls.Add(this.lblSoftwareInterno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundbutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.roundbutton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private CustomControls.RJControls.roundbutton btnLogin;
        private CustomControls.RJControls.roundbutton roundbutton1;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.roundbutton roundbutton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSoftwareInterno;
    }
}