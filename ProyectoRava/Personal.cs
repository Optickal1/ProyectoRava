using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
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
                "DELETE FROM Usuarios " +
                "WHERE nombre = '" + cBoxPersonal.SelectedItem.ToString() + "'";

            DialogResult dialogResult = MessageBox.Show(
                "¿Eliminar " + cBoxPersonal.SelectedItem.ToString() + "?",
                "Eliminar Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                //Ejecutar DELETE
                NpgsqlDataReader dr = comm.ExecuteReader();
                //Cerrar comandos
                comm.Dispose();
                //Desconectar BD
                conn.Close();
                MessageBox.Show(
                    "El usuario " + cBoxPersonal.SelectedItem.ToString() + " se ha eliminado con éxito",
                    "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Personal amp = new Personal();
                amp.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Cerrar comandos
                comm.Dispose();
                //Desconectar BD
                conn.Close();
                MessageBox.Show(
                    "Operación cancelada",
                    "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
