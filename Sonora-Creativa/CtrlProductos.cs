using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonora_Creativa
{
    class CtrlProductos : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id_producto, nombre, descripcion, tipo, precio, cantidad FROM inventario ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT id_producto, nombre, descripcion, tipo, precio, cantidad FROM inventario WHERE nombre LIKE '%" + dato + "%' OR descripcion LIKE '%" + dato + "%' OR tipo LIKE '%" + dato + "%' OR precio LIKE '%" + dato + "%' OR cantidad LIKE '%" + dato + "%' ORDER BY nombre ASC";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Productos _producto = new Productos();
                    _producto.Id_producto = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader[1].ToString();
                    _producto.Descripcion = reader.GetString("descripcion");
                    _producto.Tipo = reader[3].ToString();
                    _producto.Precio = float.Parse(reader[4].ToString());
                    _producto.Cantidad = int.Parse(reader.GetString(5));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Productos datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO inventario(nombre,descripcion, tipo, precio,cantidad)VALUES" +
                "('" + datos.Nombre + "','" + datos.Descripcion + "','" + datos.Tipo + "','" + datos.Precio + "','" + datos.Cantidad + "')";

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;


        }

        public bool actualizar(Productos datos)
        {
            bool bandera = false;

            string sql = "UPDATE inventario SET nombre='" + datos.Nombre + "',descripcion='"
                + datos.Descripcion + "', tipo='" + datos.Tipo + "', precio='" + datos.Precio
                + "',cantidad='" + datos.Cantidad + "' WHERE id_producto='" + datos.Id_producto + "'";

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;
        }

        public bool eliminar(int id)
        {
            bool bandera = false;

            string sql = "DELETE FROM inventario  WHERE id_producto='" + id + "'";

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;

        }
    }
}