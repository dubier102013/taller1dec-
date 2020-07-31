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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3;
            if(Txtnota1.Text=="" || Txtnota2.Text=="" || Txtnota3.Text=="")
            {
                MessageBox.Show("Todos los campois debenestar diligenciados", "Mensaje de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nota1 = Convert.ToDouble(Txtnota1.Text);
                Nota2 = Convert.ToDouble(Txtnota2.Text);
                Nota3 = Convert.ToDouble(Txtnota3.Text);

                LblPromedio.Text = Convert.ToString((Nota1+Nota2+Nota3)/3);

                LblPromedio.Visible = true;
                lblpro.Visible = true;

                BtnSalir.Visible = true;
                BtnLimpiar.Visible = true;
                BtnMenu.Visible = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtnota1.Text = null;
            Txtnota2.Text = null;
            Txtnota3.Text = null;

            LblPromedio.Visible = false;
            lblpro.Visible = false;

           

            Txtnota1.Focus();
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
