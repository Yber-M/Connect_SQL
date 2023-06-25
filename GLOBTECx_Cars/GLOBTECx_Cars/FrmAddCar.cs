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
    public partial class FrmAddCar : Form
    {
        // Cadena en la que abrimos la conexión con la base de datos
        SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = GLOBTECX_CARS ; integrated security = true");
        public FrmAddCar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Extraemos los datos de las cajas de texto y las guardamos en variables
            string placa = tbxPlaca.Text.ToUpper();
            string marca = tbxMarca.Text;
            string modelo = tbxModelo.Text;
            string color = tbxColor.Text;

            // Mensaje de éxito para el usuario
            MessageBox.Show("El carro MARCA [" + marca + "] con la PLACA [" + placa + "] fue AGREGADO con ÉXITO.");

            // Crear la cadena para insertar los datos a la tabla vehiculo de SQL
            string cadena = "INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES " +
                "('" + placa + "', '" + marca + "', '" + modelo + "', '" + color + "')";

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Ejecutar el nuevo comando SQL utilizando la cadena y la conexión
            comando.ExecuteNonQuery();

            // Vaciamos las cajas de texto
            tbxPlaca.Text = "";
            tbxMarca.Text = "";
            tbxModelo.Text = "";
            tbxColor.Text = "";

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
