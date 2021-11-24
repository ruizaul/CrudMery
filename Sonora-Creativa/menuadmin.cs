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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BCobro_Click(object sender, EventArgs e)
        {
           
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
           
        }

        private void BUsuario_Click(object sender, EventArgs e)
        {
          
        }

        private void BInventario_Click(object sender, EventArgs e)
        {
            Inventario In = new Inventario();
            In.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
