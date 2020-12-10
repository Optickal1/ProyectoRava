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
                cBoxSelectExtraS1_2.Items.Add(agregados[i]);
                cBoxSelectExtraS2_1.Items.Add(agregados[i]);
                cBoxSelectExtraS2_2.Items.Add(agregados[i]);
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
            //Llenar Bebestibles
            String[] bebestibles =
            {
                "Bebida 0.5L",
                "Bebida 1.5L",
                "Bebida Mini",
                "Café",
                "Express",
                "Milo",
                "Nectar",
                "Nectar 1.5L",
                "Nectar Express",
                "Té"
            };
            for (int i = 0; i < bebestibles.Length; i++)
            {
                cBoxSelectBebida.Items.Add(bebestibles[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
                txtPrecio.Text = "$ " + dr.GetInt32(10);
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
    }
}
