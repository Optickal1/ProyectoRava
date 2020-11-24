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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Personal_Load(object sender, EventArgs e)
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
                "SELECT nombre FROM Usuarios";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                cBoxPersonal.Items.Add(dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            AMPrincipal amp = new AMPrincipal();
            amp.Show();
            this.Close();
        }

        private void cBoxPersonal_SelectedIndexChanged(object sender, EventArgs e)
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
                "SELECT nombre, rut, telefono, correo, direccion FROM Usuarios " +
                "WHERE nombre = '" + cBoxPersonal.SelectedItem.ToString() + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            
            txtNombre.Text =    dr.GetString(0);
            txtRut.Text =       dr.GetString(1);
            txtTelefono.Text =  dr.GetString(2);
            txtCorreo.Text =    dr.GetString(3);
            txtDireccion.Text = dr.GetString(4);
            
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }
    }
}
