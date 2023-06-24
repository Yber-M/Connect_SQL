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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Cerrar el form
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión y abrimos la conexión a la base de datos
            SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = BASE1 ; integrated security = true");

            // Aperturamos la conexión
            conexion.Open();

            // Crear la cadena SQL para hacer la consulta del DB
            string cadena = "SELECT codigo, descripcion, precio FROM PRODUCTO";

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Guardamos las consultas
            SqlDataReader registros = comando.ExecuteReader();

            // Recorremos el indice de las tablas
            while (registros.Read())
            {
                // Mostramos en la TextBox el CÓDGIO
                tbxProductos.AppendText(registros["codigo"].ToString());
                tbxProductos.AppendText("-");

                // Mostramos en la TextBox el DESCRIPCIÓN
                tbxProductos.AppendText(registros["descripcion"].ToString());
                tbxProductos.AppendText("-");

                // Mostramos en la TextBox el PRECIO
                tbxProductos.AppendText(registros["precio"].ToString());

                // Cuando llegue al final de un producto dará un salto línea
                tbxProductos.AppendText(Environment.NewLine);
            }

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
