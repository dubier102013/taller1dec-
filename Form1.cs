using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PtEjercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 Ejerci1 = new Ejercicio1();
            Ejerci1.Show();
            this.Hide();
        }

        private void PcEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 Ejerci2 = new Ejercicio2();
            Ejerci2.Show();
            this.Hide();
        }

        private void PcEjercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ejerci3 = new Ejercicio3();
            Ejerci3.Show();
            this.Hide();
        }

        private void PcEjercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4 Ejerci4 = new Ejercicio4();
            Ejerci4.Show();
            this.Hide();
        }

        private void PcSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
