using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRava
{
    public partial class AMPrincipal : Form
    {
        public AMPrincipal()
        {
            InitializeComponent();

            Login login = new Login();
            txtName.Text = login.getNombre();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AInventario inventario = new AInventario();
            inventario.Show();
            this.Hide();
        }

        private void btnAddUsser_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
            this.Close();
        }

        private void btnVentasA_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Close();
        }
    }
}
