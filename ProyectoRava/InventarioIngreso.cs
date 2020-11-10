using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProyectoRava
{
    public partial class InventarioIngreso : Form
    {
        public InventarioIngreso()
        {
            InitializeComponent();
        }

        private void InventarioIngreso_Load(object sender, EventArgs e)
        {
            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = lalitoness12; Database = Rava_Sandwich");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            comm.CommandText =
                "SELECT p_name FROM Productos";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                cBoxInventario.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = lalitoness12; Database = Rava_Sandwich");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            comm.CommandText =
                "Update Productos " +
                "SET p_stock = " + NUPInventario.Value.ToString() + 
                "WHERE p_name = '" + cBoxInventario.SelectedItem.ToString() + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            MessageBox.Show(
                "Se han agregado " + NUPInventario.Value.ToString() + 
                " unidades al producto " + cBoxInventario.SelectedItem.ToString(), 
                "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
