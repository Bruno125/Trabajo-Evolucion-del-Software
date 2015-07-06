namespace CineEvo.UI
{
    partial class frmPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalPago = new System.Windows.Forms.Label();
            this.LblDineroIngresado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTipoPelicula = new System.Windows.Forms.Label();
            this.LblHorario = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblPelicula = new System.Windows.Forms.Label();
            this.LblCine = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de tu compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dinero ingresado:";
            // 
            // LblTotalPago
            // 
            this.LblTotalPago.AutoSize = true;
            this.LblTotalPago.Location = new System.Drawing.Point(225, 29);
            this.LblTotalPago.Name = "LblTotalPago";
            this.LblTotalPago.Size = new System.Drawing.Size(10, 13);
            this.LblTotalPago.TabIndex = 2;
            this.LblTotalPago.Text = "-";
            // 
            // LblDineroIngresado
            // 
            this.LblDineroIngresado.AutoSize = true;
            this.LblDineroIngresado.Location = new System.Drawing.Point(225, 65);
            this.LblDineroIngresado.Name = "LblDineroIngresado";
            this.LblDineroIngresado.Size = new System.Drawing.Size(10, 13);
            this.LblDineroIngresado.TabIndex = 3;
            this.LblDineroIngresado.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vuelto:";
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.Location = new System.Drawing.Point(225, 104);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(10, 13);
            this.LblVuelto.TabIndex = 5;
            this.LblVuelto.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.LblSala);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblTipoPelicula);
            this.panel1.Controls.Add(this.LblHorario);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.LblPelicula);
            this.panel1.Controls.Add(this.LblCine);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(347, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 312);
            this.panel1.TabIndex = 6;
            // 
            // LblTipoPelicula
            // 
            this.LblTipoPelicula.AutoSize = true;
            this.LblTipoPelicula.Location = new System.Drawing.Point(37, 146);
            this.LblTipoPelicula.Name = "LblTipoPelicula";
            this.LblTipoPelicula.Size = new System.Drawing.Size(83, 13);
            this.LblTipoPelicula.TabIndex = 11;
            this.LblTipoPelicula.Text = "Tipo de Pelicula";
            // 
            // LblHorario
            // 
            this.LblHorario.AutoSize = true;
            this.LblHorario.Location = new System.Drawing.Point(37, 115);
            this.LblHorario.Name = "LblHorario";
            this.LblHorario.Size = new System.Drawing.Size(41, 13);
            this.LblHorario.TabIndex = 10;
            this.LblHorario.Text = "Horario";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(37, 88);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Fecha";
            // 
            // LblPelicula
            // 
            this.LblPelicula.AutoSize = true;
            this.LblPelicula.Location = new System.Drawing.Point(37, 65);
            this.LblPelicula.Name = "LblPelicula";
            this.LblPelicula.Size = new System.Drawing.Size(44, 13);
            this.LblPelicula.TabIndex = 8;
            this.LblPelicula.Text = "Pelicula";
            // 
            // LblCine
            // 
            this.LblCine.AutoSize = true;
            this.LblCine.Location = new System.Drawing.Point(40, 41);
            this.LblCine.Name = "LblCine";
            this.LblCine.Size = new System.Drawing.Size(28, 13);
            this.LblCine.TabIndex = 7;
            this.LblCine.Text = "Cine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Resumen de compra";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblVuelto);
            this.panel2.Controls.Add(this.LblTotalPago);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.LblDineroIngresado);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 254);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "BOLETERIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total a Pagar: ";
            // 
            // LblSala
            // 
            this.LblSala.AutoSize = true;
            this.LblSala.Location = new System.Drawing.Point(40, 228);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(28, 13);
            this.LblSala.TabIndex = 14;
            this.LblSala.Text = "Sala";
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.Location = new System.Drawing.Point(86, 284);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(83, 40);
            this.BtnReiniciar.TabIndex = 8;
            this.BtnReiniciar.Text = "Empezar de nuevo";
            this.BtnReiniciar.UseVisualStyleBackColor = true;
            this.BtnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Location = new System.Drawing.Point(202, 284);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(83, 40);
            this.BtnPagar.TabIndex = 9;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnReiniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPago_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalPago;
        private System.Windows.Forms.Label LblDineroIngresado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTipoPelicula;
        private System.Windows.Forms.Label LblHorario;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblPelicula;
        private System.Windows.Forms.Label LblCine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.Button BtnPagar;
    }
}