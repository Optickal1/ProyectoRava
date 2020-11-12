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
    public partial class AInventario : Form
    {
        public AInventario()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            AMPrincipal amp = new AMPrincipal();
            amp.Show();
            this.Close();
        }

        private void dGV_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresoPA_Click(object sender, EventArgs e)
        {

            InventarioIngreso inventarioIngreso = new InventarioIngreso();
            if (Application.OpenForms[inventarioIngreso.Name] == null) 
            {
                inventarioIngreso.Show();
            }
            else
            {
                Application.OpenForms[inventarioIngreso.Name].Activate();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }
 
        private void btnConsumoPA_Click(object sender, EventArgs e)
        {
            InventarioConsumo inventarioConsumo = new InventarioConsumo();
            if (Application.OpenForms[inventarioConsumo.Name] == null)
            {
                inventarioConsumo.Show();
            }
            else
            {
                Application.OpenForms[inventarioConsumo.Name].Activate();
            }
        }

        private void llenarTabla()
        {
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
            comm.CommandText = "SELECT * FROM Inventario";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)//Si la tabla tiene 1 o más filas...
            {
                //Crear objeto referente a la tabla
                DataTable dt = new DataTable();
                //Cargar Tabla
                dt.Load(dr);
                //Mostrar tabla
                dGV_Inventario.DataSource = dt;
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }
    }
}
