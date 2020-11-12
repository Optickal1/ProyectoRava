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
    public partial class InventarioConsumo : Form
    {
        public InventarioConsumo()
        {
            InitializeComponent();
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

        private void InventarioConsumo_Load(object sender, EventArgs e)
        {

        }

        private void cBoxInventario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            if (verificarStock()) {
            
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
                "UPDATE Productos " +
                "SET p_consum = p_consum +" + NUPInventario.Value.ToString() +
                ", p_final = p_final -" + NUPInventario.Value.ToString() +
                "WHERE p_name = '" + cBoxInventario.SelectedItem.ToString() + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            MessageBox.Show(
                "Se han consumido " + NUPInventario.Value.ToString() +
                " unidades del producto " + cBoxInventario.SelectedItem.ToString(),
                "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("La cantidad ingresada no puede superar el stock actual", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private bool verificarStock()
        {
            int stockDB, stock;
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
                "SELECT p_final FROM Productos WHERE p_name = '" + cBoxInventario.SelectedItem.ToString() + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();

            //Leer una fila
            dr.Read();
            //Se entra al valor de la fila y se asigna una variable
            stockDB = dr.GetInt16(0);

            //Cerrar comandos
            comm.Dispose();
            //Desconectar DB
            conn.Close();
            stock = Int32.Parse(NUPInventario.Value.ToString());
            return stockDB >= stock;
        }
    }
}
