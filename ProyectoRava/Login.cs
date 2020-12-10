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
        static String nombre = "";
        static String rol = "";
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool blnfound = false;//Booleano que indica la existencia de datos, por default es falso
            NpgsqlConnection connA = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=lalitoness12;Database=Rava_Sandwich");//Datos de conexion a la BD para Administrador
            NpgsqlConnection connU = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=lalitoness12;Database=Rava_Sandwich");//Datos de conexion a la BD para Usuario
            connA.Open();// Abre la BD para Administrador
            connU.Open();// Abre la BD para Usuario
            
            NpgsqlCommand cmdA = new NpgsqlCommand("SELECT * FROM Usuarios WHERE rut='" + txtRut.Text + "' and pass = '" + txtPass.Text + "' and rol = 'Administrador'", connA);
            NpgsqlCommand cmdU = new NpgsqlCommand("SELECT * FROM Usuarios WHERE rut='" + txtRut.Text + "' and pass = '" + txtPass.Text + "' and rol = 'Usuario'", connU);
            NpgsqlDataReader drA = cmdA.ExecuteReader();//Guarda los resultados de la consulta para Administrador
            NpgsqlDataReader drU = cmdU.ExecuteReader();//Guarda los resultados de la consulta para Usuario

            if (drA.Read())//Si hay datos
            {
                nombre = drA.GetString(1);
                rol = drA.GetString(3);
                blnfound = true;//la existencia de datos es verdadera
                AMPrincipal amp = new AMPrincipal(); //Crea un objeto del menú para Administrador
                amp.Show();// invoca la ventana del menú para Administrador
                this.Hide();//Oculta la ventana del login

            }


            if (drU.Read())//Si hay datos
            {
                nombre = drU.GetString(1);
                rol = drU.GetString(3);
                blnfound = true;//la existencia de datos es verdadera
                UMPrincipal ump = new UMPrincipal(); //Crea un objeto del menú para Usuario
                ump.Show();// invoca la ventana del menú para Usuario
                this.Hide();//Oculta la ventana del login

            }

            if (blnfound == false && blnfound == false)//si no se encuentra
            {
                //Se muestra mensaje de error
                MessageBox.Show("Rut o password incorrecto", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                // Cierra el registro de la consulta
                drA.Close();
                drU.Close();
                // Cierra la consulta
                connA.Close();
                connU.Close();
            }
        }
        public String getNombre()
        {
            return nombre;
        }

        public String getRol()
        {
            return rol;
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
