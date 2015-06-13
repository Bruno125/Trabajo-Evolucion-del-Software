namespace CineEvo.UI
{
    partial class frmFunciones
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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pelicula,
            this.Horario,
            this.TipoFuncion,
            this.Sala});
            this.dgvFunciones.Location = new System.Drawing.Point(12, 77);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(582, 228);
            this.dgvFunciones.TabIndex = 0;
            // 
            // Pelicula
            // 
            this.Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pelicula.DataPropertyName = "NombrePelicula";
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.MinimumWidth = 150;
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // TipoFuncion
            // 
            this.TipoFuncion.DataPropertyName = "tipo_funcion";
            this.TipoFuncion.HeaderText = "Tipo de función";
            this.TipoFuncion.Name = "TipoFuncion";
            this.TipoFuncion.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funciones";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackgroundImage = global::CineEvo.UI.Properties.Resources.siguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(451, 315);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 50);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 377);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFunciones);
            this.Name = "frmFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFunciones";
            this.Load += new System.EventHandler(this.frmFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}