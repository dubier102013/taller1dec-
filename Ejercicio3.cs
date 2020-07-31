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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtRadio.Text = null;
            LblArea.Visible = false;
            lblar.Visible = false;
            TxtRadio.Focus();
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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Radio;

            Radio = Convert.ToDouble(TxtRadio.Text);

            LblArea.Text = Convert.ToString(Math.PI * Math.Pow(Radio,2));

            LblArea.Visible = true;
            lblar.Visible = true;

            BtnSalir.Visible = true;
            BtnLimpiar.Visible = true;
            BtnMenu.Visible = true;


        }
    }
}
