using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_Comida
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        Servicio ventas = new Servicio();

        private void Venta_Load(object sender, EventArgs e)
        {
            cantH.Text = "0";
            cantP.Text = "0";
            label15.Text = "0";
            label14.Text = "0";
            textBox1.Text = "$0";
            textBox2.Text = "$0";
            textBox2.Text = "$0";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ventas.ventaHam();
            cantH.Text = ventas.getHam().ToString();
            label15.Text = ventas.getHam().ToString();
            textBox1.Text = ("$" + ventas.VentaHamburguesas().ToString());
            textBox3.Text = ("$" + ventas.ventaTotal().ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ventas.ventaPap();
            cantP.Text = ventas.getPap().ToString();
            label14.Text = ventas.getPap().ToString();
            textBox2.Text = ("$" + ventas.VentaPapitas().ToString());
            textBox3.Text = ("$" + ventas.ventaTotal().ToString());
        }
    }
}
