namespace CineEvo.UI
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.lbNombreCine = new System.Windows.Forms.Label();
            this.cbCines = new System.Windows.Forms.ComboBox();
            this.lbPreferencia = new System.Windows.Forms.Label();
            this.lbSeleccione = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelCeleste = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.PictureBox();
            this.lbCartelera = new System.Windows.Forms.Label();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picBotonComprar = new System.Windows.Forms.PictureBox();
            this.picBannerAbajo = new System.Windows.Forms.PictureBox();
            this.picQuieroCine = new System.Windows.Forms.PictureBox();
            this.picComprar = new System.Windows.Forms.PictureBox();
            this.picCanchita = new System.Windows.Forms.PictureBox();
            this.picCinepolis = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.totalPrecio = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCeleste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotonComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuieroCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanchita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinepolis)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(91)))), ((int)(((byte)(161)))));
            this.Header.Controls.Add(this.lbNombreCine);
            this.Header.Controls.Add(this.cbCines);
            this.Header.Controls.Add(this.lbPreferencia);
            this.Header.Controls.Add(this.lbSeleccione);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(751, 70);
            this.Header.TabIndex = 5;
            // 
            // lbNombreCine
            // 
            this.lbNombreCine.AutoSize = true;
            this.lbNombreCine.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbNombreCine.ForeColor = System.Drawing.Color.White;
            this.lbNombreCine.Location = new System.Drawing.Point(353, 17);
            this.lbNombreCine.Name = "lbNombreCine";
            this.lbNombreCine.Size = new System.Drawing.Size(70, 30);
            this.lbNombreCine.TabIndex = 8;
            this.lbNombreCine.Text = "label8";
            this.lbNombreCine.Visible = false;
            // 
            // cbCines
            // 
            this.cbCines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCines.FormattingEnabled = true;
            this.cbCines.Location = new System.Drawing.Point(527, 27);
            this.cbCines.Name = "cbCines";
            this.cbCines.Size = new System.Drawing.Size(184, 22);
            this.cbCines.TabIndex = 7;
            // 
            // lbPreferencia
            // 
            this.lbPreferencia.AutoSize = true;
            this.lbPreferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreferencia.ForeColor = System.Drawing.Color.White;
            this.lbPreferencia.Location = new System.Drawing.Point(429, 39);
            this.lbPreferencia.Name = "lbPreferencia";
            this.lbPreferencia.Size = new System.Drawing.Size(75, 15);
            this.lbPreferencia.TabIndex = 6;
            this.lbPreferencia.Text = "preferencia:";
            // 
            // lbSeleccione
            // 
            this.lbSeleccione.AutoSize = true;
            this.lbSeleccione.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeleccione.ForeColor = System.Drawing.Color.White;
            this.lbSeleccione.Location = new System.Drawing.Point(367, 23);
            this.lbSeleccione.Name = "lbSeleccione";
            this.lbSeleccione.Size = new System.Drawing.Size(137, 15);
            this.lbSeleccione.TabIndex = 1;
            this.lbSeleccione.Text = "Selecciona el cine de tu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelCeleste
            // 
            this.panelCeleste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(168)))), ((int)(((byte)(231)))));
            this.panelCeleste.Controls.Add(this.label7);
            this.panelCeleste.Controls.Add(this.label6);
            this.panelCeleste.Controls.Add(this.label5);
            this.panelCeleste.Controls.Add(this.label3);
            this.panelCeleste.Controls.Add(this.label4);
            this.panelCeleste.Controls.Add(this.btnConsultar);
            this.panelCeleste.Location = new System.Drawing.Point(67, 211);
            this.panelCeleste.Name = "panelCeleste";
            this.panelCeleste.Size = new System.Drawing.Size(165, 159);
            this.panelCeleste.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Click aquí ->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "- Precios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "- Sedes y ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "- Películas y detalles";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consulta aquí :";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::CineEvo.UI.Properties.Resources._1430638298_clapstick;
            this.btnConsultar.Location = new System.Drawing.Point(100, 100);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(59, 57);
            this.btnConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbCartelera
            // 
            this.lbCartelera.AutoSize = true;
            this.lbCartelera.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartelera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(91)))), ((int)(((byte)(161)))));
            this.lbCartelera.Location = new System.Drawing.Point(554, 89);
            this.lbCartelera.Name = "lbCartelera";
            this.lbCartelera.Size = new System.Drawing.Size(99, 30);
            this.lbCartelera.TabIndex = 11;
            this.lbCartelera.Text = "Cartelera";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(12, 114);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(21, 19);
            this.dgvPrecios.TabIndex = 15;
            this.dgvPrecios.Visible = false;
            this.dgvPrecios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrecios_CellValueChanged);
            this.dgvPrecios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPrecios_EditingControlShowing);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Location = new System.Drawing.Point(12, 88);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(21, 19);
            this.dgvFunciones.TabIndex = 16;
            this.dgvFunciones.Visible = false;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(268, 351);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(159, 17);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBar.TabIndex = 138;
            this.pBar.Visible = false;
            // 
            // picBack
            // 
            this.picBack.Image = global::CineEvo.UI.Properties.Resources.backPro;
            this.picBack.Location = new System.Drawing.Point(45, 82);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(48, 48);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBack.TabIndex = 139;
            this.picBack.TabStop = false;
            this.picBack.Visible = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picBotonComprar
            // 
            this.picBotonComprar.Image = global::CineEvo.UI.Properties.Resources.comprar;
            this.picBotonComprar.Location = new System.Drawing.Point(272, 277);
            this.picBotonComprar.Name = "picBotonComprar";
            this.picBotonComprar.Size = new System.Drawing.Size(82, 44);
            this.picBotonComprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBotonComprar.TabIndex = 13;
            this.picBotonComprar.TabStop = false;
            this.picBotonComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // picBannerAbajo
            // 
            this.picBannerAbajo.Image = global::CineEvo.UI.Properties.Resources._201542992421544_prin;
            this.picBannerAbajo.Location = new System.Drawing.Point(23, 398);
            this.picBannerAbajo.Name = "picBannerAbajo";
            this.picBannerAbajo.Size = new System.Drawing.Size(441, 74);
            this.picBannerAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBannerAbajo.TabIndex = 12;
            this.picBannerAbajo.TabStop = false;
            // 
            // picQuieroCine
            // 
            this.picQuieroCine.Image = global::CineEvo.UI.Properties.Resources.quieroCine;
            this.picQuieroCine.Location = new System.Drawing.Point(67, 211);
            this.picQuieroCine.Name = "picQuieroCine";
            this.picQuieroCine.Size = new System.Drawing.Size(165, 34);
            this.picQuieroCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuieroCine.TabIndex = 9;
            this.picQuieroCine.TabStop = false;
            // 
            // picComprar
            // 
            this.picComprar.Image = global::CineEvo.UI.Properties.Resources.compraEntradas;
            this.picComprar.Location = new System.Drawing.Point(268, 211);
            this.picComprar.Name = "picComprar";
            this.picComprar.Size = new System.Drawing.Size(159, 114);
            this.picComprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComprar.TabIndex = 8;
            this.picComprar.TabStop = false;
            // 
            // picCanchita
            // 
            this.picCanchita.Image = global::CineEvo.UI.Properties.Resources.bannerhome;
            this.picCanchita.Location = new System.Drawing.Point(67, 89);
            this.picCanchita.Name = "picCanchita";
            this.picCanchita.Size = new System.Drawing.Size(360, 88);
            this.picCanchita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanchita.TabIndex = 7;
            this.picCanchita.TabStop = false;
            // 
            // picCinepolis
            // 
            this.picCinepolis.Image = global::CineEvo.UI.Properties.Resources.thumb;
            this.picCinepolis.Location = new System.Drawing.Point(491, 130);
            this.picCinepolis.Name = "picCinepolis";
            this.picCinepolis.Size = new System.Drawing.Size(226, 329);
            this.picCinepolis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCinepolis.TabIndex = 6;
            this.picCinepolis.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.BackgroundImage = global::CineEvo.UI.Properties.Resources.siguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(99, 82);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 50);
            this.btnSiguiente.TabIndex = 140;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // totalPrecio
            // 
            this.totalPrecio.Enabled = true;
            this.totalPrecio.Interval = 1;
            this.totalPrecio.Tick += new System.EventHandler(this.totalPrecio_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 488);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.picBotonComprar);
            this.Controls.Add(this.picBannerAbajo);
            this.Controls.Add(this.lbCartelera);
            this.Controls.Add(this.picQuieroCine);
            this.Controls.Add(this.picComprar);
            this.Controls.Add(this.picCanchita);
            this.Controls.Add(this.picCinepolis);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panelCeleste);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CINEPOLIS - ¡ Disfruta tu Película !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCeleste.ResumeLayout(false);
            this.panelCeleste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotonComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuieroCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanchita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinepolis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbCines;
        private System.Windows.Forms.Label lbPreferencia;
        private System.Windows.Forms.Label lbSeleccione;
        private System.Windows.Forms.PictureBox picCinepolis;
        private System.Windows.Forms.PictureBox picCanchita;
        private System.Windows.Forms.PictureBox picComprar;
        private System.Windows.Forms.PictureBox picQuieroCine;
        private System.Windows.Forms.Panel panelCeleste;
        private System.Windows.Forms.PictureBox btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCartelera;
        private System.Windows.Forms.PictureBox picBannerAbajo;
        private System.Windows.Forms.PictureBox picBotonComprar;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label lbNombreCine;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Timer totalPrecio;
    }
}

