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
    public partial class FrmDeleteCarID: Form
    {
        SqlConnection conexion = new SqlConnection("server = YB-M\\YBM ; database = GLOBTECX_CARS ; integrated security = true");
        public FrmDeleteCarID()
        {
            InitializeComponent();
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
                lblStatus.Text = "Carro encontrado";
                tbxPlaca.Text = registros["Placa"].ToString();
                tbxMarca.Text = registros["Marca"].ToString();
                tbxModelo.Text = registros["Modelo"].ToString();
                tbxColor.Text = registros["Color"].ToString();
            }
            else
            {
                // Si no encuentra un producto con el codigo dado por el usuario,
                // mostrará un mensaje indicándolo.
                lblStatus.Text = "No existe un carro con el ID: " + id;
            }

            // Cerramos la conexión
            conexion.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Aperturamos la conexión
            conexion.Open();

            // Extraemos los datos de las cajas de texto
            // ??? El Trim sirve para QUITAR los espacios en blanco
            string id = tbxID.Text.Trim();
            string placa = tbxPlaca.Text.Trim();
            string marca = tbxMarca.Text.Trim();
            string modelo = tbxModelo.Text.Trim();
            string color = tbxColor.Text.Trim();

            // Crear la cadena SQL para ELIMINAR datos en la tabla PRODUCTO según su CÓDIGO
            string cadena = "DELETE FROM vehiculo WHERE IdVehiculo = " + id;

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            SqlCommand comando = new SqlCommand(cadena, conexion);

            // Verficar que se hayan agregado datos
            int cant;

            // Crear un nuevo comando SQL utilizando la cadena y la conexión
            cant = comando.ExecuteNonQuery();

            if (cant == 1)
            {
                // Mostrar un mensaje indicando que el proceso fue correctamente concluido
                lblStatus.Text = "Carro ID[" + id + "] ELIMINADO con éxito";

                // Vaciamos las cajas de texto
                tbxID.Text = "";
                tbxPlaca.Text = "";
                tbxMarca.Text = "";
                tbxModelo.Text = "";
                tbxColor.Text = "";
            }
            else
            {
                lblStatus.Text = "ERROR. No se pudo ELIMINAR";
            }

            // Cerramos la conexión
            conexion.Close();
        }
    }
}
