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
            this.totalPrecio = new System.Windows.Forms.Timer(this.components);
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalNum = new System.Windows.Forms.Label();
            this.pcUser = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picBotonComprar = new System.Windows.Forms.PictureBox();
            this.picBannerAbajo = new System.Windows.Forms.PictureBox();
            this.picQuieroCine = new System.Windows.Forms.PictureBox();
            this.picComprar = new System.Windows.Forms.PictureBox();
            this.picCanchita = new System.Windows.Forms.PictureBox();
            this.picCinepolis = new System.Windows.Forms.PictureBox();
            this.panelPago = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LblCantidadAsientos = new System.Windows.Forms.Label();
            this.LblAsientos = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.LblTipoPelicula = new System.Windows.Forms.Label();
            this.LblHorario = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblPelicula = new System.Windows.Forms.Label();
            this.LblCine = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDinero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.LblTotalPago = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDineroIngresado = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCeleste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotonComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuieroCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanchita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinepolis)).BeginInit();
            this.panelPago.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(1348, 70);
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
            this.lbCartelera.Size = new System.Drawing.Size(100, 30);
            this.lbCartelera.TabIndex = 11;
            this.lbCartelera.Text = "Cartelera";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(12, 114);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(49, 54);
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
            // totalPrecio
            // 
            this.totalPrecio.Enabled = true;
            this.totalPrecio.Interval = 1;
            this.totalPrecio.Tick += new System.EventHandler(this.totalPrecio_Tick);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(20, 133);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(33, 14);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total";
            this.lbTotal.Visible = false;
            // 
            // lbTotalNum
            // 
            this.lbTotalNum.AutoSize = true;
            this.lbTotalNum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalNum.Location = new System.Drawing.Point(28, 163);
            this.lbTotalNum.Name = "lbTotalNum";
            this.lbTotalNum.Size = new System.Drawing.Size(33, 14);
            this.lbTotalNum.TabIndex = 141;
            this.lbTotalNum.Text = "Total";
            this.lbTotalNum.Visible = false;
            // 
            // pcUser
            // 
            this.pcUser.Image = global::CineEvo.UI.Properties.Resources.user2;
            this.pcUser.Location = new System.Drawing.Point(12, 211);
            this.pcUser.Name = "pcUser";
            this.pcUser.Size = new System.Drawing.Size(14, 14);
            this.pcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcUser.TabIndex = 142;
            this.pcUser.TabStop = false;
            this.pcUser.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.BackgroundImage = global::CineEvo.UI.Properties.Resources.siguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(111, 80);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 50);
            this.btnSiguiente.TabIndex = 140;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
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
            // panelPago
            // 
            this.panelPago.Controls.Add(this.panel1);
            this.panelPago.Controls.Add(this.panel2);
            this.panelPago.Location = new System.Drawing.Point(688, 89);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(604, 330);
            this.panelPago.TabIndex = 143;
            this.panelPago.Visible = false;
            this.panelPago.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPago_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(91)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.LblCantidadAsientos);
            this.panel1.Controls.Add(this.LblAsientos);
            this.panel1.Controls.Add(this.LblSala);
            this.panel1.Controls.Add(this.LblTipoPelicula);
            this.panel1.Controls.Add(this.LblHorario);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.LblPelicula);
            this.panel1.Controls.Add(this.LblCine);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(202, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 304);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "#Asientos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Asientos :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Sala:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "BOLETERIA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Tipo Pelicula:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Horario:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Fecha:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Pelicula:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = "Cine:";
            // 
            // LblCantidadAsientos
            // 
            this.LblCantidadAsientos.AutoSize = true;
            this.LblCantidadAsientos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadAsientos.ForeColor = System.Drawing.Color.White;
            this.LblCantidadAsientos.Location = new System.Drawing.Point(119, 246);
            this.LblCantidadAsientos.Name = "LblCantidadAsientos";
            this.LblCantidadAsientos.Size = new System.Drawing.Size(62, 15);
            this.LblCantidadAsientos.TabIndex = 16;
            this.LblCantidadAsientos.Text = "#Asientos";
            // 
            // LblAsientos
            // 
            this.LblAsientos.AutoSize = true;
            this.LblAsientos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsientos.ForeColor = System.Drawing.Color.White;
            this.LblAsientos.Location = new System.Drawing.Point(88, 269);
            this.LblAsientos.Name = "LblAsientos";
            this.LblAsientos.Size = new System.Drawing.Size(114, 15);
            this.LblAsientos.TabIndex = 15;
            this.LblAsientos.Text = "Detalle de asientos";
            // 
            // LblSala
            // 
            this.LblSala.AutoSize = true;
            this.LblSala.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSala.ForeColor = System.Drawing.Color.White;
            this.LblSala.Location = new System.Drawing.Point(119, 224);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(32, 15);
            this.LblSala.TabIndex = 14;
            this.LblSala.Text = "Sala";
            // 
            // LblTipoPelicula
            // 
            this.LblTipoPelicula.AutoSize = true;
            this.LblTipoPelicula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPelicula.ForeColor = System.Drawing.Color.White;
            this.LblTipoPelicula.Location = new System.Drawing.Point(119, 160);
            this.LblTipoPelicula.Name = "LblTipoPelicula";
            this.LblTipoPelicula.Size = new System.Drawing.Size(95, 15);
            this.LblTipoPelicula.TabIndex = 11;
            this.LblTipoPelicula.Text = "Tipo de Pelicula";
            // 
            // LblHorario
            // 
            this.LblHorario.AutoSize = true;
            this.LblHorario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHorario.ForeColor = System.Drawing.Color.White;
            this.LblHorario.Location = new System.Drawing.Point(120, 129);
            this.LblHorario.Name = "LblHorario";
            this.LblHorario.Size = new System.Drawing.Size(48, 15);
            this.LblHorario.TabIndex = 10;
            this.LblHorario.Text = "Horario";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(119, 99);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 15);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Fecha";
            // 
            // LblPelicula
            // 
            this.LblPelicula.AutoSize = true;
            this.LblPelicula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPelicula.ForeColor = System.Drawing.Color.White;
            this.LblPelicula.Location = new System.Drawing.Point(119, 76);
            this.LblPelicula.Name = "LblPelicula";
            this.LblPelicula.Size = new System.Drawing.Size(51, 15);
            this.LblPelicula.TabIndex = 8;
            this.LblPelicula.Text = "Pelicula";
            // 
            // LblCine
            // 
            this.LblCine.AutoSize = true;
            this.LblCine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCine.ForeColor = System.Drawing.Color.White;
            this.LblCine.Location = new System.Drawing.Point(119, 52);
            this.LblCine.Name = "LblCine";
            this.LblCine.Size = new System.Drawing.Size(33, 15);
            this.LblCine.TabIndex = 7;
            this.LblCine.Text = "Cine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(112, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Resumen de compra";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(91)))), ((int)(((byte)(161)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDinero);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblVuelto);
            this.panel2.Controls.Add(this.LblTotalPago);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.LblDineroIngresado);
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 304);
            this.panel2.TabIndex = 8;
            // 
            // BtnDinero
            // 
            this.BtnDinero.FlatAppearance.BorderSize = 0;
            this.BtnDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDinero.Location = new System.Drawing.Point(23, 144);
            this.BtnDinero.Name = "BtnDinero";
            this.BtnDinero.Size = new System.Drawing.Size(142, 123);
            this.BtnDinero.TabIndex = 6;
            this.BtnDinero.UseVisualStyleBackColor = true;
            this.BtnDinero.Click += new System.EventHandler(this.BtnDinero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de tu compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dinero ingresado:";
            // 
            // LblVuelto
            // 
            this.LblVuelto.AutoSize = true;
            this.LblVuelto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVuelto.ForeColor = System.Drawing.Color.White;
            this.LblVuelto.Location = new System.Drawing.Point(152, 102);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(14, 15);
            this.LblVuelto.TabIndex = 5;
            this.LblVuelto.Text = "0";
            // 
            // LblTotalPago
            // 
            this.LblTotalPago.AutoSize = true;
            this.LblTotalPago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPago.ForeColor = System.Drawing.Color.White;
            this.LblTotalPago.Location = new System.Drawing.Point(151, 27);
            this.LblTotalPago.Name = "LblTotalPago";
            this.LblTotalPago.Size = new System.Drawing.Size(14, 15);
            this.LblTotalPago.TabIndex = 2;
            this.LblTotalPago.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vuelto:";
            // 
            // LblDineroIngresado
            // 
            this.LblDineroIngresado.AutoSize = true;
            this.LblDineroIngresado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDineroIngresado.ForeColor = System.Drawing.Color.White;
            this.LblDineroIngresado.Location = new System.Drawing.Point(152, 63);
            this.LblDineroIngresado.Name = "LblDineroIngresado";
            this.LblDineroIngresado.Size = new System.Drawing.Size(14, 15);
            this.LblDineroIngresado.TabIndex = 3;
            this.LblDineroIngresado.Text = "0";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 488);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.pcUser);
            this.Controls.Add(this.lbTotalNum);
            this.Controls.Add(this.lbTotal);
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
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCeleste.ResumeLayout(false);
            this.panelCeleste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotonComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuieroCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanchita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinepolis)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalNum;
        private System.Windows.Forms.PictureBox pcUser;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.Label LblTotalPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDineroIngresado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Label LblTipoPelicula;
        private System.Windows.Forms.Label LblHorario;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblPelicula;
        private System.Windows.Forms.Label LblCine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblAsientos;
        private System.Windows.Forms.Label LblCantidadAsientos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnDinero;
    }
}

