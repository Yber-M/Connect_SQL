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
    public partial class FrmActualizarDatosDB : Form
    {
        // Cadena de conexión y abrimos la conexión a la base de datos
        //  ** Cambiar el "server" según tu dispositivo ** 
        private SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = BASE1 ; integrated security = true");

        public FrmActualizarDatosDB()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Guardamos el contenido del tbx en una variable
            string cod = tbxCodigo.Text;

            // Crear la cadena SQL para hacer la consulta del DB y definimos el codigo
            string cadena = "SELECT codigo, descripcion, precio FROM PRODUCTO WHERE codigo = " + cod;

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Guardamos las consultas
            SqlDataReader registros = comando.ExecuteReader();

            // Recorremos el indice de las tablas
            if (registros.Read())
            {
                // Colocamos lso datos en los labels correspondientes y extraemos
                // los datos de la tabla registros según sus atributos.
                lblStatus.Text = "Producto Encontrado con Éxito";
                tbxDescrip.Text = registros["descripcion"].ToString();
                tbxPrecio.Text = registros["precio"].ToString();
            }
            else
            {
                // Si no encuentra un producto con el codigo dado por el usuario,
                // mostrará un mensaje indicándolo.
                lblStatus.Text = "No existe un producto con ese código";

                // Vaciamos los tbx
                tbxDescrip.Text = "";
                tbxPrecio.Text = "";
            }

            // Cerramos la conexión
            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Extraemos los datos de las cajas de texto
            // ??? El Trim sirve para QUITAR los espacios en blanco
            string cod = tbxCodigo.Text.Trim();
            string descrip = tbxDescrip.Text.Trim();
            string prec = tbxPrecio.Text.Trim();

            // Crear la cadena SQL para la ACTUALIZACIÓN de datos en la tabla PRODUCTO según su CÓDIGO
            string cadena = "UPDATE PRODUCTO SET descripcion = '" + descrip + "', precio = '" + prec + "' WHERE codigo = '" + cod + "'";


            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Verficar que se hayan agregado datos
            int cant;

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            cant = comando.ExecuteNonQuery();

            if (cant == 1)
            {
                // Mostrar un mensaje indicando que el proceso fue correctamente concluido
                lblStatus.Text = "Los datos se ACTUALIZARON correctamente";

                // Vaciamos las cajas de texto
                tbxCodigo.Text = "";
                tbxDescrip.Text = "";
                tbxPrecio.Text = "";
            }
            else
            {
                lblStatus.Text = "ERROR. No se pudo ACTUALIZAR";
            }

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
