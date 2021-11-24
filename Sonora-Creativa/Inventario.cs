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
    public partial class Inventario : Form
    {
        public Inventario()
        {

            InitializeComponent();
            cargarTabla(null);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
 


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Productos> lista = new List<Productos>();
            CtrlProductos _ctrlProductos = new CtrlProductos();
            dataGridView1.DataSource = _ctrlProductos.consulta(dato);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            Productos _producto = new Productos();
            _producto.Nombre = txtNombre.Text;
            _producto.Descripcion = txtDescripcion.Text;
            _producto.Tipo = txtTipo.Text;
            _producto.Precio = float.Parse(txtPrecio.Text);
            _producto.Cantidad = int.Parse(txtCantidad.Text);

            CtrlProductos ctrl = new CtrlProductos();

            if (txtId.Text != "")
            {
                _producto.Id_producto = int.Parse(txtId.Text);
                bandera=ctrl.actualizar(_producto);
            }
            else
            {
                bandera=ctrl.insertar(_producto);
            }
            if (bandera)
            {
                MessageBox.Show("Registro Guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtTipo.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTipo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCantidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro?",
                "Salir", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CtrlProductos _ctrl = new CtrlProductos();
                bandera=_ctrl.eliminar(id);

                if (bandera)
                {
                    MessageBox.Show("Registro Guardado");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
