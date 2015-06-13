namespace CineEvo.UI
{
    partial class frmPrecios
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precios";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(12, 58);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(582, 154);
            this.dgvPrecios.TabIndex = 8;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.BackgroundImage = global::CineEvo.UI.Properties.Resources.siguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(452, 292);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 50);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número de entradas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sub total:";
            // 
            // frmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrecios);
            this.Name = "frmPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrecios";
            this.Load += new System.EventHandler(this.frmPrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

    }
}