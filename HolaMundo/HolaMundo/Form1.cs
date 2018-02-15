using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventana = new Form2();
            ventana.Show();
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/Luis/Desktop/Mac.wav";
            Player.Play();
        }
    }
}
