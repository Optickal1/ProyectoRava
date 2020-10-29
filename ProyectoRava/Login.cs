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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool blnfound = false;//Booleano que indica la existencia de datos, por default es falso
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=lalitoness12;Database=Rava_Sandwich");//Datos de conexion a la BD
            conn.Open();// Abre la BD
            //Realiza la consulta si los datos ingresados por el textbox son iguales a las que están en la BD
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Usuarios WHERE rut='" + txtRut.Text + "' and pass = '" + txtPass.Text + "'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();//Guarda los resultados de la consulta

            if (dr.Read())//Si hay datos
            {
                blnfound = true;//la existencia de datos es verdadera
                UMPrincipal mu = new UMPrincipal(); //Crea un objeto del menú
                mu.Show();// invoca la ventana del menú
                this.Hide();//Oculta la ventana del login
            }

            if (blnfound == false)//si no se encuentra
            {
                //muestra un lindo mensajito
                MessageBox.Show("Rut o password incorrecto", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                dr.Close(); // Cierra el registro de la consulta
                conn.Close();// Cierra la consulta
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
