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

namespace GLOBTECx_Cars
{
    public partial class FrmBuscarCarID : Form
    {
        SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = GLOBTECX_CARS ; integrated security = true");

        public FrmBuscarCarID()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Guardamos el contenido del tbx en una variable
            string id = tbxID.Text.ToUpper();

            // Crear la cadena SQL para hacer la consulta del DB y definimos el codigo
            string cadena = "SELECT Placa, Marca, Modelo, Color FROM vehiculo WHERE IdVehiculo = " + id;

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Guardamos las consultas
            SqlDataReader registros = comando.ExecuteReader();

            // Recorremos el indice de las tablas
            if (registros.Read())
            {
                // Colocamos lso datos en los labels correspondientes y extraemos
                // los datos de la tabla registros según sus atributos.
                lblPlaca.Text = registros["Placa"].ToString();
                lblMarca.Text = registros["Marca"].ToString();
                lblModelo.Text = registros["Modelo"].ToString();
                lblColor.Text = registros["Color"].ToString();

            }
            else
            {
                // Si no encuentra un producto con el codigo dado por el usuario,
                // mostrará un mensaje indicándolo.
                lblPlaca.Text = "----------------";
                lblMarca.Text = "----------------";
                lblModelo.Text = "----------------";
                lblColor.Text = "----------------";
                MessageBox.Show("No existe un carro con el ID: " + id);
            }

            // Cerramos la conexión
            conexion.Close();

            // Vaciar el TextBoxCodigo
            tbxID.Text = "";
        }
    }
}
