namespace taller1
{
    partial class Ejercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio4));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txtnota1 = new System.Windows.Forms.TextBox();
            this.Txtnota3 = new System.Windows.Forms.TextBox();
            this.Txtnota2 = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR PROMEDIO DE NOTAS";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(577, 341);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(184, 29);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Visible = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(577, 297);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(184, 29);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "REGRESAR A MENU";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Visible = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DIGITE LA PRIMER NOTA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIGITE LA SEGUNDA NOTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIGITE LA TERCER NOTA:";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.Location = new System.Drawing.Point(178, 324);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(116, 13);
            this.lblpro.TabIndex = 11;
            this.lblpro.Text = "EL PROMEDIO ES:";
            this.lblpro.Visible = false;
            // 
            // LblPromedio
            // 
            this.LblPromedio.AutoSize = true;
            this.LblPromedio.Location = new System.Drawing.Point(338, 324);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(35, 13);
            this.LblPromedio.TabIndex = 12;
            this.LblPromedio.Text = "label6";
            this.LblPromedio.Visible = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(236, 239);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(97, 41);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 177);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Txtnota1
            // 
            this.Txtnota1.Location = new System.Drawing.Point(341, 88);
            this.Txtnota1.Name = "Txtnota1";
            this.Txtnota1.Size = new System.Drawing.Size(100, 20);
            this.Txtnota1.TabIndex = 15;
            // 
            // Txtnota3
            // 
            this.Txtnota3.Location = new System.Drawing.Point(341, 183);
            this.Txtnota3.Name = "Txtnota3";
            this.Txtnota3.Size = new System.Drawing.Size(100, 20);
            this.Txtnota3.TabIndex = 16;
            // 
            // Txtnota2
            // 
            this.Txtnota2.Location = new System.Drawing.Point(341, 131);
            this.Txtnota2.Name = "Txtnota2";
            this.Txtnota2.Size = new System.Drawing.Size(100, 20);
            this.Txtnota2.TabIndex = 17;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(577, 260);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(184, 29);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "LIMPIAR CAMPOS";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Visible = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.Txtnota2);
            this.Controls.Add(this.Txtnota3);
            this.Controls.Add(this.Txtnota1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblPromedio);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txtnota1;
        private System.Windows.Forms.TextBox Txtnota3;
        private System.Windows.Forms.TextBox Txtnota2;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}