namespace CineEvo.UI.Controls
{
    partial class VistaFunciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DgvFunciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::CineEvo.UI.Properties.Resources.siguiente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(503, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvFunciones
            // 
            this.DgvFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePelicula,
            this.horario,
            this.tipo_funcion,
            this.sala,
            this.id_funcion});
            this.DgvFunciones.Location = new System.Drawing.Point(33, 109);
            this.DgvFunciones.MultiSelect = false;
            this.DgvFunciones.Name = "DgvFunciones";
            this.DgvFunciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFunciones.Size = new System.Drawing.Size(612, 157);
            this.DgvFunciones.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funciones";
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombrePelicula.DataPropertyName = "NombrePelicula";
            this.NombrePelicula.HeaderText = "Pelicula";
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.ReadOnly = true;
            // 
            // horario
            // 
            this.horario.DataPropertyName = "horario";
            this.horario.HeaderText = "Horario";
            this.horario.MinimumWidth = 100;
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // tipo_funcion
            // 
            this.tipo_funcion.DataPropertyName = "tipo_funcion";
            this.tipo_funcion.HeaderText = "Tipo de funcion";
            this.tipo_funcion.MinimumWidth = 150;
            this.tipo_funcion.Name = "tipo_funcion";
            this.tipo_funcion.ReadOnly = true;
            this.tipo_funcion.Width = 150;
            // 
            // sala
            // 
            this.sala.DataPropertyName = "sala";
            this.sala.HeaderText = "Sala";
            this.sala.MinimumWidth = 150;
            this.sala.Name = "sala";
            this.sala.ReadOnly = true;
            this.sala.Width = 150;
            // 
            // id_funcion
            // 
            this.id_funcion.DataPropertyName = "id_funcion";
            this.id_funcion.HeaderText = "id_funcion";
            this.id_funcion.Name = "id_funcion";
            this.id_funcion.Visible = false;
            // 
            // VistaFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvFunciones);
            this.Controls.Add(this.label2);
            this.Name = "VistaFunciones";
            this.Size = new System.Drawing.Size(674, 337);
            this.Load += new System.EventHandler(this.VistaFunciones_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DgvFunciones, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvFunciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_funcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcion;
    }
}
