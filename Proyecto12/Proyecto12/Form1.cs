using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión y abrimos la conexión a la base de datos
            SqlConnection conexion = new SqlConnection("server = . ; database = BASE1 ; integrated security = true");

            // Aperturamos la conexión
            conexion.Open();

            // Extraemos los datos de las cajas de texto
            string descripcion = tbxDescripcion.Text;
            string precio = tbxPrecio.Text;

            // Crear la cadena SQL para la inserción de datos en la tabla PRODUCTO
            string cadena = "INSERT INTO PRODUCTO(descripcion, precio) " +
                "values('"+ descripcion +"', '"+ precio +"')";

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            comando.ExecuteNonQuery();

            // Mostrar un mensaje indicando que el proceso fue correctamente concluido
            MessageBox.Show("Los Datos se guardaron correctamente");

            // Vaciamos las cajas de texto
            tbxDescripcion.Text = "";
            tbxPrecio.Text = "";

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
