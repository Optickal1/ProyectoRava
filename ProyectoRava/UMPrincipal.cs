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
    public partial class UMPrincipal : Form
    {
        public UMPrincipal()
        {
            InitializeComponent();

            Login login = new Login();
            txtName.Text = login.getNombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UInventario inventario = new UInventario();
            inventario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Close();
        }
    }
}
