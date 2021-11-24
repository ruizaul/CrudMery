using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonora_Creativa
{
    public partial class Login : Form
    {   
        
        public Login()
        {
            InitializeComponent();
        }
        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            string codigo= "select apodo, contraseña from usuarios where apodo= '" + txtUsuario.Text + "' and contraseña = '" + txtContraseña.Text + "';";
            MySqlCommand consulta;
            consulta = new MySqlCommand(codigo, conexionBD);

            MySqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read())
            {
                
                Form2 admin = new Form2();
                admin.Show();
                this.Hide();
             
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conexionBD.Close();


        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

      

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
