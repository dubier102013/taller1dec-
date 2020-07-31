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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtNombre.Text, "BIENVENIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            BtnLimpiar.Visible = true;
            BtnMenu.Visible = true;
            BtnSalir.Visible = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = null;
            TxtNombre.Focus();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form1 MenuPP = new Form1();
            MenuPP.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
