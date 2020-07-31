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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombreP.Text = null;
            TxtValor.Text = null;

            lblnom.Visible = false;
            lblProducto.Visible = false;
            lblviva.Visible = false;
            LblValorIva.Visible = false;
            lbltotall.Visible = false;
            LblTotal.Visible = false;
            TxtNombreP.Focus();
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
            double iva, valor;

            valor = Convert.ToDouble(TxtValor.Text);
            iva = valor * 0.19;

            lblProducto.Text = TxtNombreP.Text;
            LblValorIva.Text = Convert.ToString(iva);
            LblTotal.Text = Convert.ToString(valor+iva);

            lblnom.Visible = true;
            lblProducto.Visible = true;
            lblviva.Visible = true;
            LblValorIva.Visible = true;
            lbltotall.Visible = true;
            LblTotal.Visible = true;

            BtnLimpiar.Visible = true;
            BtnMenu.Visible = true;
            BtnSalir.Visible = true;

        }
    }
}
