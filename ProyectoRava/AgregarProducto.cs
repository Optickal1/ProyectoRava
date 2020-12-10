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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
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
                "SELECT DISTINCT p_type FROM Productos ORDER BY p_type ASC";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                cBoxAddType.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text != null && cBoxAddType.SelectedItem != null)
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
                    "INSERT INTO Productos(p_name, p_type, p_stock, p_final, p_consum, p_entry)" +
                    "VALUES ('" + txtAddName.Text + "', '" + cBoxAddType.SelectedItem.ToString() + "', '" + NUPAgregar.Value.ToString() +
                    "', '0', '0', '0')";
                //Leer BD
                NpgsqlDataReader dr = comm.ExecuteReader();
                //Cerrar comandos
            
                comm.Dispose();
                //Desconectar BD
                conn.Close();

                MessageBox.Show(
                    "Se ha agregado el producto " + txtAddName.Text +
                    " de tipo " + cBoxAddType.SelectedItem.ToString() + 
                    " con stock inicial " + NUPAgregar.Value.ToString(),
                    "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(
                    "Debe ingresar un nombre o tipo válido",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
