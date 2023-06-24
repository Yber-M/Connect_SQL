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
    public partial class FrmBuscarXidDB : Form
    {
        public FrmBuscarXidDB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión y abrimos la conexión a la base de datos
            //  ** Cambiar el server según tu dispositivo ** 
            SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = BASE1 ; integrated security = true");

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
                lblDescrip.Text = registros["descripcion"].ToString();
                lblPrecio.Text = registros["precio"].ToString();
            }
            else
            {
                // Si no encuentra un producto con el codigo dado por el usuario,
                // mostrará un mensaje indicándolo.
                MessageBox.Show("No existe un producto con ese código");
            }

            // Cerramos la conexión
            conexion.Close();

            // Vaciar el TextBoxCodigo
            tbxCodigo.Text = "";
        }
    }
}
