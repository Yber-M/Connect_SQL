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
    public partial class FrmVerTodosCar : Form
    {
        // Cadena de conexión y abrimos la conexión a la base de datos
        SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = GLOBTECX_CARS ; integrated security = true");
        public FrmVerTodosCar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Crear la cadena SQL para hacer la consulta del DB
            string cadena = "SELECT * FROM vehiculo;";

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Guardamos las consultas
            SqlDataReader registros = comando.ExecuteReader();

            // Recorremos el indice de las tablas
            tbxVerCars.AppendText("ID     ||     PLACA     ||    MARCA    ||    MODELO   ||   COLOR");
            tbxVerCars.AppendText(Environment.NewLine);
            tbxVerCars.AppendText("--------------------------------------------------------------------------------------------------");
            tbxVerCars.AppendText(Environment.NewLine);

            while (registros.Read())
            {
                // Mostramos en la TextBox el IDVEHICULO
                tbxVerCars.AppendText(registros["IdVehiculo"].ToString());
                tbxVerCars.AppendText("     ||      ");

                // Mostramos en la TextBox el PLACA
                tbxVerCars.AppendText(registros["Placa"].ToString());
                tbxVerCars.AppendText("     ||      ");

                // Mostramos en la TextBox el MARCA
                tbxVerCars.AppendText(registros["Marca"].ToString());
                tbxVerCars.AppendText("     ||      ");

                // Mostramos en la TextBox el MODELO
                tbxVerCars.AppendText(registros["Modelo"].ToString());
                tbxVerCars.AppendText("     ||      ");

                // Mostramos en la TextBox el COLOR
                tbxVerCars.AppendText(registros["Color"].ToString());

                // Cuando llegue al final de un producto dará un salto línea
                tbxVerCars.AppendText(Environment.NewLine);
            }

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
