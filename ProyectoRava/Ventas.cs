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
    public partial class Ventas : Form
    {
        static int precioB1 = 0;
        static int precioB2 = 0;
        static int precioB3 = 0;
        static int precioP = 0;
        static int precioV = 0;
        static int cantB = 1;
        static String extras1 = "";
        static String extras2 = "";
        static int cantidadExtra1 = 0;
        static int cantidadExtra2 = 0;
        static int totalExtra1 = 0;
        static int totalExtra2 = 0;

        public Ventas()
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
                "SELECT id, categoria FROM Promo ORDER BY id";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                cBoxSelectPromo.Items.Add(dr.GetString(1) + " - " + dr.GetString(0));
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            //Llenar Agregados
            String[] agregados =
            {
                "Aceituna", 
                "Aji Verde", 
                "Cebolla", 
                "Champiñon", 
                "Choclo", 
                "Chucrut", 
                "Huevo", 
                "Morron", 
                "Palta", 
                "Pepinillo", 
                "Poroto Verde", 
                "Queso", 
                "Tocino", 
                "Tomate",
                " ",
            };
            for (int i = 0; i < agregados.Length; i++)
            {
                cBoxSelectAgregado1.Items.Add(agregados[i]);
                cBoxSelectAgregado2.Items.Add(agregados[i]);
                cBoxSelectAgregado3.Items.Add(agregados[i]);
                cBoxSelectAgregado4.Items.Add(agregados[i]);
                cBoxSelectAgregado5.Items.Add(agregados[i]);
                cBoxSelectAgregado6.Items.Add(agregados[i]);
                cBoxSelectAgregado7.Items.Add(agregados[i]);
                cBoxSelectAgregado8.Items.Add(agregados[i]);
                cBoxSelectExtraS1_1.Items.Add(agregados[i]);
                cBoxSelectExtraS2_1.Items.Add(agregados[i]);
            }
            //Lenar Carnes
            String[] carnes =
            {
                "Ave",
                "Churrasco",
                "Lomo",
                "Mechada",
                " "
            };
            for (int i = 0; i < carnes.Length; i++)
            {
                cBoxSelectCarne1.Items.Add(carnes[i]);
                cBoxSelectCarne2.Items.Add(carnes[i]);
            }
            //-- LLENAR LAS BEBIDAS --

            //Datos de conexión a BD
            NpgsqlConnection conn1 = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = lalitoness12; Database = Rava_Sandwich");
            //Abrir BD
            conn1.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm1 = new NpgsqlCommand();
            //Crear objeto conexión
            comm1.Connection = conn1;
            //No se que hace xd
            comm1.CommandType = CommandType.Text;
            //Consulta
            comm1.CommandText = "SELECT nombre from bebidas";
            //Leer BD
            NpgsqlDataReader dr1 = comm1.ExecuteReader();
            while (dr1.Read())//Si la tabla tiene 1 o más filas...
            {
                //Rellena la lista desplegable
                cBoxSelectBebida1.Items.Add(dr1.GetString(0));
                cBoxSelectBebida2.Items.Add(dr1.GetString(0));
                cBoxSelectBebida3.Items.Add(dr1.GetString(0));
            }
            //Cerrar comandos
            comm1.Dispose();
            //Desconectar BD
            conn1.Close();
            NUDBebida2.Visible = false;
            cBoxSelectBebida2.Visible = false;
            NUDBebida3.Visible = false;
            cBoxSelectBebida3.Visible = false;
        }

        private void cBoxSelectPromo_SelectedIndexChanged(object sender, EventArgs e)
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
            String[] Promocion = cBoxSelectPromo.SelectedItem.ToString().Split(' ');
            comm.CommandText =
                "SELECT tipo_carne1, " +
                "agregado1, " +
                "agregado2, " +
                "agregado3, " +
                "agregado4, " +
                "tipo_carne2, " +
                "agregado5, " +
                "agregado6, " +
                "agregado7, " +
                "agregado8, " +
                "precio " +
                "FROM Promo " +
                "WHERE id = '" + 
                Promocion[Promocion.Length - 1] + "'";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                /*
                cBoxSelectCarne1.Items.Add(dr.GetString(0));
                cBoxSelectAgregado1.Items.Add(dr.GetString(1));
                cBoxSelectAgregado2.Items.Add(dr.GetString(2));
                cBoxSelectAgregado3.Items.Add(dr.GetString(3));
                cBoxSelectAgregado4.Items.Add(dr.GetString(4));
                cBoxSelectCarne2.Items.Add(dr.GetString(5));
                cBoxSelectAgregado5.Items.Add(dr.GetString(6));
                cBoxSelectAgregado6.Items.Add(dr.GetString(7));
                cBoxSelectAgregado7.Items.Add(dr.GetString(8));
                cBoxSelectAgregado8.Items.Add(dr.GetString(9));
                */

                cBoxSelectCarne1.Text = dr.GetString(0);
                cBoxSelectAgregado1.Text = dr.GetString(1);
                cBoxSelectAgregado2.Text = dr.GetString(2);
                cBoxSelectAgregado3.Text = dr.GetString(3);
                cBoxSelectAgregado4.Text = dr.GetString(4);
                cBoxSelectCarne2.Text = dr.GetString(5);
                cBoxSelectAgregado5.Text = dr.GetString(6);
                cBoxSelectAgregado6.Text = dr.GetString(7);
                cBoxSelectAgregado7.Text = dr.GetString(8);
                cBoxSelectAgregado8.Text = dr.GetString(9);
                precioP = dr.GetInt16(10);//Extrae el precio de la promo de la DB
                int precioConB =
                    precioV +
                    (precioP * int.Parse(NUDPromo.Value.ToString())) +
                    (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                    (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                    (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                    totalExtra1 +
                    totalExtra2;
                txtPrecio.Text = "$ " + precioConB;
            }
            if(cBoxSelectCarne1.Text == "")
            {
                cBoxSelectCarne1.Visible = false;
                labelSelectCarne1.Visible = false;
            }
            else
            {
                cBoxSelectCarne1.Visible = true;
                labelSelectCarne1.Visible = true;
            }
            if (cBoxSelectCarne2.Text == "")
            {
                cBoxSelectCarne2.Visible = false;
                labelSelectCarne2.Visible = false;
            }
            else
            {
                cBoxSelectCarne2.Visible = true;
                labelSelectCarne2.Visible = true;
            }
            if (cBoxSelectAgregado1.Text == "")
            {
                cBoxSelectAgregado1.Visible = false;
                labelSelectAgregado1.Visible = false;
            }
            else
            {
                cBoxSelectAgregado1.Visible = true;
                labelSelectAgregado1.Visible = true;
            }
            if (cBoxSelectAgregado2.Text == "")
            {
                cBoxSelectAgregado2.Visible = false;
                labelSelectAgregado2.Visible = false;
            }
            else
            {
                cBoxSelectAgregado2.Visible = true;
                labelSelectAgregado2.Visible = true;
            }
            if (cBoxSelectAgregado3.Text == "")
            {
                cBoxSelectAgregado3.Visible = false;
                labelSelectAgregado3.Visible = false;
            }
            else
            {
                cBoxSelectAgregado3.Visible = true;
                labelSelectAgregado3.Visible = true;
            }
            if (cBoxSelectAgregado4.Text == "")
            {
                cBoxSelectAgregado4.Visible = false;
                labelSelectAgregado4.Visible = false;
            }
            else
            {
                cBoxSelectAgregado4.Visible = true;
                labelSelectAgregado4.Visible = true;
            }
            if (cBoxSelectAgregado5.Text == "")
            {
                cBoxSelectAgregado5.Visible = false;
                labelSelectAgregado5.Visible = false;
            }
            else
            {
                cBoxSelectAgregado5.Visible = true;
                labelSelectAgregado5.Visible = true;
            }
            if (cBoxSelectAgregado6.Text == "")
            {
                cBoxSelectAgregado6.Visible = false;
                labelSelectAgregado6.Visible = false;
            }
            else
            {
                cBoxSelectAgregado6.Visible = true;
                labelSelectAgregado6.Visible = true;
            }
            if (cBoxSelectAgregado7.Text == "")
            {
                cBoxSelectAgregado7.Visible = false;
                labelSelectAgregado7.Visible = false;
            }
            else
            {
                cBoxSelectAgregado7.Visible = true;
                labelSelectAgregado7.Visible = true;
            }
            if (cBoxSelectAgregado8.Text == "")
            {
                cBoxSelectAgregado8.Visible = false;
                labelSelectAgregado8.Visible = false;
            }
            else
            {
                cBoxSelectAgregado8.Visible = true;
                labelSelectAgregado8.Visible = true;
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            precioB1 = 0;
            precioB2 = 0;
            precioB3 = 0;
            precioV = 0;
            precioP = 0;
            cantB = 1;
            extras1 = "";
            extras2 = "";
            cantidadExtra1 = 0;
            cantidadExtra2 = 0;
            totalExtra1 = 0;
            totalExtra2 = 0;
            Login login = new Login();
            if(login.getRol() == "Usuario")
            {
                UMPrincipal mu = new UMPrincipal();
                mu.Show();
                this.Close();
            }
            else if(login.getRol() == "Administrador")
            {
                AMPrincipal ma = new AMPrincipal();
                ma.Show();
                this.Close();
            }
        }

        private void NUDVasos_ValueChanged(object sender, EventArgs e)
        {
            precioV = 100 * int.Parse(NUDVasos1.Value.ToString());
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
        }

        private void cBoxSelectBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUDBebida1.Value = 1;
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
                "SELECT nombre, precio FROM bebidas";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                if(cBoxSelectBebida1.SelectedItem.ToString() == dr.GetString(0))
                {
                    precioB1 = dr.GetInt16(1);
                }
            }
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void cBoxSelectBebida2_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUDBebida2.Value = 1;
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
                "SELECT nombre, precio FROM bebidas";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                if (cBoxSelectBebida2.SelectedItem.ToString() == dr.GetString(0))
                {
                    precioB2 = dr.GetInt16(1);
                }
            }
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void cBoxSelectBebida3_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUDBebida3.Value = 1;
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
                "SELECT nombre, precio FROM bebidas";
            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())//Si la tabla tiene 1 o más filas...
            {
                if (cBoxSelectBebida3.SelectedItem.ToString() == dr.GetString(0))
                {
                    precioB3 = dr.GetInt16(1);
                }
            }
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
        }

        private void NUDBebida1_ValueChanged(object sender, EventArgs e)
        {
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
        }

        private void NUDBebida2_ValueChanged(object sender, EventArgs e)
        {
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
        }

        private void NUDBebida3_ValueChanged(object sender, EventArgs e)
        {
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            cantB++;
            if(cantB == 2)
            {
                NUDBebida2.Visible = true;
                cBoxSelectBebida2.Visible = true;
            }
            else if(cantB == 3)
            {
                NUDBebida2.Visible = true;
                cBoxSelectBebida2.Visible = true;
                NUDBebida3.Visible = true;
                cBoxSelectBebida3.Visible = true;
            }
        }

        private void btnAddExtraS1_Click(object sender, EventArgs e)
        {
            if(cBoxSelectExtraS1_1.SelectedItem != null)
            {
                cantidadExtra1++;
                totalExtra1 = cantidadExtra1 * 500;
                extras1 = extras1 + " " + cBoxSelectExtraS1_1.SelectedItem.ToString();
                if (extras2 == "")
                {
                    tBoxExtras.Text = "Extra para sandwich 1: " + extras1 + "\r\nExtras Sandwich 2: " + extras2;
                }
                else
                {
                    tBoxExtras.Text = "Extra para sandwich 1: \r\n" + extras1;
                }
                int precioConB =
                   precioV +
                   (precioP * int.Parse(NUDPromo.Value.ToString())) +
                   (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                   (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                   (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                   totalExtra1 +
                   totalExtra2;
                txtPrecio.Text = "$ " + precioConB;
            }
            else
            {
                MessageBox.Show(
                "Debe ingresar al menos un extra",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnAddExtraS2_Click(object sender, EventArgs e)
        {
            if (cBoxSelectExtraS2_1.SelectedItem != null)
            {
                cantidadExtra2++;
                totalExtra2 = cantidadExtra2 * 500;
                extras2 = extras2 + " " + cBoxSelectExtraS2_1.SelectedItem.ToString();
                tBoxExtras.Text = "Extra para sandwich 1: \r\n" + extras1 + "Extra para sandwich 2: \n" + extras2;
                int precioConB =
                    precioV +
                    (precioP * int.Parse(NUDPromo.Value.ToString())) +
                    (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                    (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                    (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                    totalExtra1 +
                    totalExtra2;
                txtPrecio.Text = "$ " + precioConB;
            }
            else
            {
                MessageBox.Show(
                "Debe ingresar al menos un extra",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {

        }

        private void NUDPromo_ValueChanged(object sender, EventArgs e)
        {
            int precioConB =
                precioV +
                (precioP * int.Parse(NUDPromo.Value.ToString())) +
                (precioB1 * int.Parse(NUDBebida1.Value.ToString())) +
                (precioB2 * int.Parse(NUDBebida2.Value.ToString())) +
                (precioB3 * int.Parse(NUDBebida3.Value.ToString())) +
                totalExtra1 +
                totalExtra2;
            txtPrecio.Text = "$ " + precioConB;
        }
    }
}
