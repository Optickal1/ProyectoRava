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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
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
                "SELECT p_name FROM Productos ORDER BY p_name ASC";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                cBoxEliminar.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                "DELETE FROM Productos " +
                "WHERE p_name = '" + cBoxEliminar.SelectedItem.ToString() + "'";

            DialogResult dialogResult = MessageBox.Show(
                "¿Eliminar " + cBoxEliminar.SelectedItem.ToString() + "?",
                "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if(dialogResult == DialogResult.Yes)
            {
                //Ejecutar DELETE
                NpgsqlDataReader dr = comm.ExecuteReader();
                //Cerrar comandos
                comm.Dispose();
                //Desconectar BD
                conn.Close();
                MessageBox.Show(
                    "El producto " + cBoxEliminar.SelectedItem.ToString() + " se ha eliminado con éxito",
                    "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (dialogResult == DialogResult.No)
            {
                //Cerrar comandos
                comm.Dispose();
                //Desconectar BD
                conn.Close();
                MessageBox.Show(
                    "Operación cancelada",
                    "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
