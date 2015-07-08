using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using CineEvo.BL;
using CineEvo.UI.Controls;
using CineEvo.BE;
using CineEvo.UI.ViewModel;
using System.Drawing.Printing;


namespace CineEvo.UI
{
    

    public partial class frmPrincipal : Form, ControlListener
    {
        Bitmap bmpUser;
        List<int> xses;
        List<int> yses;
        List<string> ids;
        int w;
        int defineSeparador;
        SalaModel controlador;
        List<Tuple<int, string>> listaRes;

        //atributos necesarios principales
        CineBL objCineBL = CineBL.ObtenerInstancia();
        int idCineSeleccionado;
        int nroHojaActual; //En que escena del formulario se esta actualmente
       
        int columnaSeleccionada;
        int filaSeleccionada;
        bool cambioValor;
        int idSala,cantEntradasEscogidas,idTipoEntrada,idFuncion;
        bool mostrarMapa;

        public frmPrincipal()
        {
            InitializeComponent();

            nroHojaActual = 1;
            cantEntradasEscogidas = -1;
            mostrarMapa = false;
            //cambioValor = false;
            xses = new List<int>();
            yses = new List<int>();
            ids = new List<string>();
            w = 21;
            defineSeparador = 7;
            filaSeleccionada = -1;
            idSala = -1;
            idTipoEntrada = -1;
            idFuncion = -1;
            bmpUser = new Bitmap(this.pcUser.Image);
            generarCoordenadas();

        }

        private void generarCoordenadas()
        {
            //ALGORITMO SALVAJE e.e

            int x = 110, y = 90, separadorX = 0, auxX = 0, auxY = 0, separadorY = 0;
            int numFilas = 10, numCol = 20,contNumeros=1;
            int primerColBlanca = 4, segundaColBlanca = 15;
            char letra = 'A';

            for (int i = 0; i < numFilas; i++)
            {

                for (int j = 0; j < numCol; j++)    
                {
                    if (j != primerColBlanca && j != segundaColBlanca)
                    {
                       
                        if(contNumeros<10)
                        insertarAListas(x + auxX + separadorX, y + auxY + separadorY,letra+"0"+contNumeros);
                        else
                        insertarAListas(x + auxX + separadorX, y + auxY + separadorY, letra + "" + contNumeros);
                        
                        contNumeros++;
                    }
                    auxX += w;
                    separadorX += defineSeparador;
                }

                contNumeros = 1;
                letra++;
                auxX = 0;
                separadorX = 0;
                separadorY += defineSeparador;
                auxY += w;
            }

        }

        private void insertarAListas(int x,int y,string id)
        {
            xses.Add(x);
            yses.Add(y);
            ids.Add(id);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            int Wreal = (int)gr.VisibleClipBounds.Width;
            int Hreal = (int)gr.VisibleClipBounds.Height;
            BufferedGraphicsContext espaciobuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = espaciobuffer.Allocate(gr, new Rectangle(0, 0, Wreal, Hreal));
            buffer.Graphics.Clear(this.BackColor);
            //AQUI VA LOS DIBUJOS

            if(mostrarMapa)
            {
                controlador.DibujarAsientos(buffer.Graphics,bmpUser);
                controlador.DibujarAsientosOcupados(buffer.Graphics, bmpUser);
               
            }

            

           // buffer.Graphics.FillEllipse(new SolidBrush(Color.Blue),30,30,30,30);
            /*
            for (int i = 0; i < xses.Count; i++)
            {
                buffer.Graphics.FillRectangle(new SolidBrush(Color.Brown), xses[i], yses[i], w, w);
                buffer.Graphics.DrawString(ids[i], new Font("Arial Black", 6), new SolidBrush(Color.White), xses[i]+w/10, yses[i]+w/4);
            }
            */

                buffer.Render(gr);
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Width = 767;
            this.Height = 527;
            CenterToScreen();

            //ComboBox Cine
            cbCines.DataSource = objCineBL.Listar();
            cbCines.DisplayMember = "nombre";
            cbCines.ValueMember = "idCine";
            cbCines.SelectedIndex = -1;

            PosicionesTamaniosControles();
            ConfigurarControles(dgvFunciones);
           ConfigurarControles(dgvPrecios);

           lbTotalNum.Visible = false;
            lbTotal.Visible=false;
           lbTotalNum.Parent = this;
           lbTotal.Parent = this;

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Evento cuando cierra el form
        }

        private void AparecerPagina1()
        {
            btnSiguiente.Visible = !btnSiguiente.Visible;
            picBack.Visible = !picBack.Visible;

            //--picCanchita
            picCanchita.Visible = !picCanchita.Visible;
            //--label Cartelera
            lbCartelera.Visible = !lbCartelera.Visible;
            //--picBanner de Abajo
            picBannerAbajo.Visible = !picBannerAbajo.Visible;
            //--picLogoCinepolis
            picCinepolis.Visible = !picCinepolis.Visible;
            //--pic Quiero Cine
            picQuieroCine.Visible = !picQuieroCine.Visible;
            //--panel Celeste
            panelCeleste.Visible = !panelCeleste.Visible;
            //--btnConsultar
            btnConsultar.Visible = !btnConsultar.Visible;
            //--picComprar
            picComprar.Visible = !picComprar.Visible;
            //--picBotonComprar
            picBotonComprar.Visible = !picBotonComprar.Visible;
            //LabelNombre
            lbNombreCine.Visible = !lbNombreCine.Visible;
            //combos y labels
            if (cbCines.Visible && lbPreferencia.Visible && lbSeleccione.Visible)
            {
                cbCines.Visible = false;
                lbPreferencia.Visible = false;
                lbSeleccione.Visible = false;
            }
            else
            {
                cbCines.Visible = true;
                lbPreferencia.Visible = true;
                lbSeleccione.Visible = true;
            }

         
        }

        private void DesaparecerAparecerPagina1()
        {
            //--picCanchita
            picCanchita.Visible = !picCanchita.Visible;
            //--label Cartelera
            lbCartelera.Visible = !lbCartelera.Visible;
            //--picBanner de Abajo
            picBannerAbajo.Visible = !picBannerAbajo.Visible;
            //--picLogoCinepolis
            picCinepolis.Visible = !picCinepolis.Visible;
            //--pic Quiero Cine
            picQuieroCine.Visible = !picQuieroCine.Visible;

            //--btnConsultar
            btnConsultar.Visible = !btnConsultar.Visible;
            //--panel Celeste
            panelCeleste.Visible = !panelCeleste.Visible;
          
            //--picComprar
            picComprar.Visible = !picComprar.Visible;
            //--picBotonComprar
            picBotonComprar.Visible = !picBotonComprar.Visible;
            //LabelNombre
            lbNombreCine.Visible = !lbNombreCine.Visible;
            //combos y labels
            if (cbCines.Visible && lbPreferencia.Visible && lbSeleccione.Visible)
            {
                cbCines.Visible = false;
                lbPreferencia.Visible = false;
                lbSeleccione.Visible = false;
            }
            else
            {
                cbCines.Visible = true;
                lbPreferencia.Visible = true;
                lbSeleccione.Visible = true;
            }
            //aparecer dgvFunciones
            dgvFunciones.Visible = !dgvFunciones.Visible;
            //PicDelBACK
            picBack.Visible = !picBack.Visible;
            //BOTON
            btnSiguiente.Visible = !btnSiguiente.Visible;
        }

        public void PosicionesTamaniosControles()
        {

            //PAL DGV FUNCIONES
            dgvFunciones.Left = 70; //x
            dgvFunciones.Top = 160; // y

            dgvFunciones.Width = 600;
            dgvFunciones.Height = 228;

            //pal dfv precios
            dgvPrecios.Left = 70; //x
            dgvPrecios.Top = 160; // y

            dgvPrecios.Width = 600;
            dgvPrecios.Height = 228;

            //para el picBack
            picBack.Left = 45;
            picBack.Top = 94;

            //Para el boton
            btnSiguiente.Left = dgvFunciones.Location.X + dgvFunciones.Width - btnSiguiente.Width;
            btnSiguiente.Top = 398;
        }

        public void ConfigurarControles(DataGridView dgv)
        {          
            dgv.AllowDrop = false;          
            dgv.AllowUserToAddRows = false;           
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            if (!dgv.Equals(dgvPrecios))
            dgv.ReadOnly = true;

            dgv.MultiSelect = false;

            if (!dgv.Equals(dgvPrecios))
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
              
        public void dgvFuncionesConfigurar()
        {
            DataGridViewCellStyle csLetras = new DataGridViewCellStyle();
            csLetras.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvFunciones.Columns["NombrePelicula"].DisplayIndex = 1; //que columna primero
            dgvFunciones.Columns["NombrePelicula"].HeaderText = "Pelicula"; //el texto a la columna
            dgvFunciones.Columns["NombrePelicula"].Width =180;    //el stilo a las letras
            dgvFunciones.Columns["NombrePelicula"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvFunciones.Columns["NombrePelicula"].HeaderCell.Style = csLetras;

            dgvFunciones.Columns["horario"].DisplayIndex = 2; //que columna primero
            dgvFunciones.Columns["horario"].HeaderText = "Horario"; //el texto a la columna
            dgvFunciones.Columns["horario"].Width = 130;    //el stilo a las letras
            dgvFunciones.Columns["horario"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvFunciones.Columns["horario"].HeaderCell.Style = csLetras;

            dgvFunciones.Columns["tipo_funcion"].DisplayIndex = 3; //que columna primero
            dgvFunciones.Columns["tipo_funcion"].HeaderText = "Tipo de Funcion"; //el texto a la columna
            dgvFunciones.Columns["tipo_funcion"].Width = 50;    //el stilo a las letras
            dgvFunciones.Columns["tipo_funcion"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvFunciones.Columns["tipo_funcion"].HeaderCell.Style = csLetras;

            dgvFunciones.Columns["sala"].DisplayIndex = 4; //que columna primero
            dgvFunciones.Columns["sala"].HeaderText = "Sala"; //el texto a la columna
            dgvFunciones.Columns["sala"].Width = 220;    //el stilo a las letras
            dgvFunciones.Columns["sala"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvFunciones.Columns["sala"].HeaderCell.Style = csLetras;


            //columnas que utilizare
            dgvFunciones.Columns["id_funcion"].Visible = false;
            dgvFunciones.Columns["id_tipo_funcion"].Visible = false;
            dgvFunciones.Columns["id_sala"].Visible = false;
            dgvFunciones.Columns["precio"].Visible = false;
            //dgvCandidato.Columns["Estado"].Visible = false;
            //dgvCandidato.Columns["Distrito"].Visible = false;
            //dgvCandidato.Columns["PartidoPolitico"].Visible = false;
            //dgvCandidato.Columns["DistritoId"].Visible = false;
            //dgvCandidato.Columns["PartidoPoliticoId"].Visible = false;

            dgvFunciones.RowHeadersWidth = 15;
            dgvFunciones.ClearSelection();

        }

        public void dgvPreciosConfigurar()
        {
            DataGridViewCellStyle csLetras = new DataGridViewCellStyle();
            csLetras.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvPrecios.Columns["nombre_tipo_entrada"].DisplayIndex = 1; //que columna primero
            dgvPrecios.Columns["nombre_tipo_entrada"].HeaderText = "Tipo de Función"; //el texto a la columna
            dgvPrecios.Columns["nombre_tipo_entrada"].Width = 180;    //el stilo a las letras
            dgvPrecios.Columns["nombre_tipo_entrada"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvPrecios.Columns["nombre_tipo_entrada"].HeaderCell.Style = csLetras;

            dgvPrecios.Columns["precio"].DisplayIndex = 1; //que columna primero
            dgvPrecios.Columns["precio"].HeaderText = "Precio"; //el texto a la columna
            dgvPrecios.Columns["precio"].Width = 180;    //el stilo a las letras
            dgvPrecios.Columns["precio"].DefaultCellStyle = csLetras;    //el stilo al header
            dgvPrecios.Columns["precio"].HeaderCell.Style = csLetras;

            //columnas que utilizare
            dgvPrecios.Columns["id_tipo_entrada"].Visible = false;
         
            //dgvCandidato.Columns["Estado"].Visible = false;
            //dgvCandidato.Columns["Distrito"].Visible = false;
            //dgvCandidato.Columns["PartidoPolitico"].Visible = false;
            //dgvCandidato.Columns["DistritoId"].Visible = false;
            //dgvCandidato.Columns["PartidoPoliticoId"].Visible = false;

            dgvPrecios.RowHeadersWidth = 15;

            //AÑADIENDO LAS COLUMNAS NECESARIAS
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Cantidad";
            cmb.Name = "dgvCbCantidad";
            cmb.MaxDropDownItems = 4;
            cmb.Items.Add("0");
            cmb.Items.Add("1");
            cmb.Items.Add("2");
            cmb.Items.Add("3");
            cmb.Items.Add("4");
            cmb.Items.Add("5");
            dgvPrecios.Columns.Add(cmb);
            //Columna de total
            DataGridViewTextBoxColumn cmb2 = new DataGridViewTextBoxColumn();
            cmb2.HeaderText = "Total";
            cmb2.Name = "dgvCbTotal";
            cmb2.ReadOnly = true;
            dgvPrecios.Columns.Add(cmb2);


            string strSelectedValue = ((DataGridViewComboBoxColumn)this.dgvPrecios.Columns["dgvCbCantidad"]).Items[0].ToString();
            
            
            foreach(DataGridViewRow r in this.dgvPrecios.Rows)
            {
                ((DataGridViewComboBoxCell)r.Cells["dgvCbCantidad"]).Value=strSelectedValue;       
               
            }        
            //dgvPrecios.ClearSelection();

        }
        
         private void DesaparecerAparecerPagina2()
        {
            
             //DGVFUNCIONES
            if (dgvFunciones.Visible)
                dgvFunciones.Visible = false;
            else
                dgvFunciones.Visible = true;

         
             //PRECIOS
            if (dgvPrecios.Visible)
                dgvPrecios.Visible = false;
            else
                dgvPrecios.Visible = true;

            if (lbTotal.Parent.Equals(dgvPrecios))
            {
                lbTotal.Parent = this;
                lbTotal.Visible = false;
            }
            else
            {
                lbTotal.Visible = true;
                lbTotal.Parent = dgvPrecios;
            }

            if (lbTotalNum.Parent.Equals(dgvPrecios))
            {
                lbTotalNum.Visible = false;
                lbTotalNum.Parent = this;
            }
            else
            {
                lbTotalNum.Visible = true;
                lbTotalNum.Parent = dgvPrecios;
            }
           // lbTotal.Parent = dgvPrecios;
            lbTotal.Left = 420;
            lbTotal.Top = 70;

             if(nroHojaActual==3)
            lbTotalNum.Text = "0";            
            lbTotalNum.Left = 510;
            lbTotalNum.Top = 70;

        }

         private void DesaparecerAparecerPagina3()
         {
              //PRECIOS
             if (dgvPrecios.Visible)
                 dgvPrecios.Visible = false;
             else
                 dgvPrecios.Visible = true;

             if (lbTotal.Parent.Equals(dgvPrecios))
             {
                 lbTotal.Parent = this;
                 lbTotal.Visible = false;
             }
             else
             {
                 lbTotal.Visible = true;
                 lbTotal.Parent = dgvPrecios;
             }

             if (lbTotalNum.Parent.Equals(dgvPrecios))
             {
                 lbTotalNum.Visible = false;
                 lbTotalNum.Parent = this;
             }
             else
             {
                 lbTotalNum.Visible = true;
                 lbTotalNum.Parent = dgvPrecios;
             }

             mostrarMapa = !mostrarMapa;

             // lbTotal.Parent = dgvPrecios;
             lbTotal.Left = 420;
             lbTotal.Top = 70;

             lbTotalNum.Left = 510;
             lbTotalNum.Top = 70;
         }

        private void DesaparecerAparecerPagina4()
         {

             mostrarMapa = !mostrarMapa;
             panelPago.Visible = !panelPago.Visible;
            //Posicionamiento
             panelPago.Left = 110;
             panelPago.Top = 70;
         }

        private void DesaparecerAparecerPagina5()
        {
            panelPago.Visible = !panelPago.Visible;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cbCines.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un cine.");
                return;
            }

            //DESAPARECE LOS COMPONENTES DE LA PAGINA 1
            
            idCineSeleccionado = Convert.ToInt32(cbCines.SelectedValue.ToString());
            lbNombreCine.Text = ((CCine)cbCines.SelectedItem).nombre;

            FuncionBL objFuncionBL = FuncionBL.ObtenerInstancia();
            dgvFunciones.DataSource = objFuncionBL.ListarFromCine(idCineSeleccionado);
            
            dgvFuncionesConfigurar();
           
           
            DesaparecerAparecerPagina1();
            nroHojaActual++;         //SE INCREMENTA   
            //QUE APARESCA UNAS LETRAS DE "Espere ..." algo así pex
                        
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //SPRINT 2
        }

        UserControl currentControl;
        public void MostrarUserControl(UserControl control, bool hasOwnNavigationBar)
        {
            currentControl = control;
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Location = new System.Drawing.Point(0, 0);
            control.TabIndex = 15;
            this.Controls.Add(control);
            this.Controls.SetChildIndex(control, 0);
            Header.Visible = !hasOwnNavigationBar;
        }
        
        public void BackPressed()
        {
            currentControl.Hide();
            Header.Visible = true;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            if (nroHojaActual == 2)
                DesaparecerAparecerPagina1();
            else if (nroHojaActual == 3)
            {
                DesaparecerAparecerPagina2();
                //ELIMINANDO LAS COLUMNAS INNECESARIAS
                dgvPrecios.Columns.Remove("dgvCbCantidad");
                dgvPrecios.Columns.Remove("dgvCbTotal");
            }
            else if(nroHojaActual==4)
            {
                DesaparecerAparecerPagina3();
            }
            else if (nroHojaActual == 5)
            {
                DesaparecerAparecerPagina4();
            }
            else if(nroHojaActual==6)
            {
                DesaparecerAparecerPagina5();
            }

            nroHojaActual--;

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nroHojaActual == 2)//Hoja de funciones
            {
                if(dgvFunciones.SelectedRows.Count==0)
                {
                    MessageBox.Show("Seleccione una función para poder continuar", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                //TODO LO QUE OCASIANRARA ESTO
                TipoEntradaBL objTipoEntradaBL = TipoEntradaBL.ObtenerInstancia();
                double precio = Convert.ToDouble(dgvFunciones.SelectedRows[0].Cells["precio"].Value.ToString());
                idSala = Convert.ToInt32(dgvFunciones.SelectedRows[0].Cells["id_sala"].Value.ToString());
                idFuncion = Convert.ToInt32(dgvFunciones.SelectedRows[0].Cells["id_funcion"].Value.ToString());
                
                //DE AQUI CAPTURO TODO PERO SOLO PRECIO POR AHORA
                dgvPrecios.DataSource = objTipoEntradaBL.ObtenerTiposEntradas(precio);
                dgvPreciosConfigurar();

                dgvPrecios.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvPrecios_EditingControlShowing);

                DesaparecerAparecerPagina2();

            }
            else if(nroHojaActual==3)//Hoja de precios
            {
                if (Convert.ToDouble(lbTotalNum.Text) == 0)
                {
                    MessageBox.Show("Seleccione una cantidad de entradas para poder continuar", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int cantGeneral=Convert.ToInt32(dgvPrecios.Rows[0].Cells["dgvCbCantidad"].Value.ToString());
                int cantNiniosViejos = Convert.ToInt32(dgvPrecios.Rows[1].Cells["dgvCbCantidad"].Value.ToString());

                SalaBL objSalaBL = SalaBL.ObtenerInstancia();
                CSala consultar=objSalaBL.Obtener(idSala);

                if(consultar.asientosLibres<(cantGeneral+cantNiniosViejos)) //si la cant que escogio es mayor que la cantidad de asientos libres
                {
                    MessageBox.Show("No existen asientos libres disponibles para la cantidad solicitada - Existen "+consultar.asientosLibres+" asientos libres", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //AQUI SI ENTRARIA A LA OTRA PANTALLA DE MAPA
                controlador = new SalaModel(idSala);
                cantEntradasEscogidas = cantGeneral + cantNiniosViejos;
                DesaparecerAparecerPagina3();                               

            }
            else if(nroHojaActual==4)
            {
                if(cantEntradasEscogidas>controlador.cantAsientosSeleccionados())
                {
                    MessageBox.Show("Aún no a seleccionado la cantidad final de entradas a comprar, seleccione", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //TODO: integra cabio de victor
                //-----                
                //------                
                //PRUEBA - VICTOR
                                
                //Muestro la pantalla de pago
                DesaparecerAparecerPagina4();
                LblTotalPago.Text = lbTotalNum.Text;
                LblCine.Text = lbNombreCine.Text;
                LblPelicula.Text = dgvFunciones.SelectedRows[0].Cells["NombrePelicula"].Value.ToString();
                LblFecha.Text = dgvFunciones.SelectedRows[0].Cells["horario"].Value.ToString().Substring(0, 10);
                LblHorario.Text = dgvFunciones.SelectedRows[0].Cells["horario"].Value.ToString().Substring(11);
                LblTipoPelicula.Text = dgvFunciones.SelectedRows[0].Cells["tipo_funcion"].Value.ToString();
                LblSala.Text = dgvFunciones.SelectedRows[0].Cells["sala"].Value.ToString();
                LblCantidadAsientos.Text = cantEntradasEscogidas.ToString();                
                listaRes = new List<Tuple<int, string>>();
                listaRes = controlador.listaDeCodigosSeleccionados(idSala);
                String acumular="";
                for (int i = 0; i < listaRes.Count;i++)
                {
                    acumular += listaRes[i].Item2;
                    if(i!=listaRes.Count-1)
                    {
                        acumular += ", ";
                    }
                }
                LblAsientos.Text = acumular;

                //Dinero a pagar
                double TotalPago = Double.Parse(LblTotalPago.Text.ToString());
                //Cantidad que se acaba de ingresar
                double DineroIngresado = Double.Parse(LblDineroIngresado.Text.ToString());
                //Valido que el saldo cubra el Total de Dinero
                if (TotalPago > DineroIngresado)
                {
                    LblVuelto.Text = "0";
                }
                else
                {
                    //Mostar un mensaje que ya se puede efectuar el pago
                    //Bloquear el ingreso de monedas
                    LblVuelto.Text = (-1 * (TotalPago - DineroIngresado)).ToString();
                }

            }
            else if (nroHojaActual == 5)
            {
                if(!(Double.Parse(LblTotalPago.Text.ToString())<Double.Parse(LblDineroIngresado.Text.ToString())))
                {
                    MessageBox.Show("No cuenta con el saldo suficiente para efectuar la compra", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (MessageBox.Show("¿Esta seguro de su transacción?", "CINEPOLIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Oculto la pantalla de pago
                    //DesaparecerAparecerPagina5();
                    //AQUI ACTUALIZO LOS ASIENTOS :D
                    AsientoBL objAsientoBL = AsientoBL.ObtenerInstancia();
                    VentaBL objVentaBL = new VentaBL();
                    for (int i = 0; i < listaRes.Count; i++)
                    {
                        objAsientoBL.VenderAsiento(listaRes[i].Item1);
                    }

                    //--Registrar la venta :D
                    int idVenta = objVentaBL.RegistrarVenta(Convert.ToDouble(lbTotalNum.Text.ToString()));
                    //--Registrar las entradas
                    objVentaBL = new VentaBL();
                    for (int i = 0; i < listaRes.Count; i++)
                    {
                        objVentaBL.RegistrarEntrada(idFuncion, listaRes[i].Item1, idVenta);
                    }

                    //--Actualizar la sala quitandole asientos libres
                    SalaBL objSalaBL = SalaBL.ObtenerInstancia();
                    objSalaBL.ActualizarAsientosLibres(idSala, cantEntradasEscogidas);

                    //--Mostrar dialog para imprimir la boleta
                    Imprimir();

                    //MessageBox.Show("Venta registrada exitosamente", "CINEPOLIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //frmPrincipal_Load(sender,e);
                    DesaparecerAparecerPagina5();
                    AparecerPagina1();
                    dgvPrecios.Columns.Remove("dgvCbCantidad");
                    dgvPrecios.Columns.Remove("dgvCbTotal");
                    nroHojaActual = 1;
                    LblTotalPago.Text = "0";
                    LblDineroIngresado.Text = "0";
                    LblVuelto.Text = "0";
                    return;

                }
                else
                    return;
               // MessageBox.Show("YA ESTAN VENDIDAS");
                   
               
            }
           

            nroHojaActual++;
        }

        private void Imprimir()
        {
            //printFont = new Font("Arial", 10);
            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler
            //   (this.pd_PrintPage);
            //pd.Print();
            PrintDocument ticket = new PrintDocument();
            ticket.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            ticket.Print();
            //PrintPreviewDialog printPrevDialog = new PrintPreviewDialog();
            //printPrevDialog.Document = ticket;
            //printPrevDialog.Show();
        }

        private Font fuenteTitulo = new Font("Courier New", 15,FontStyle.Bold);
        private Font fuenteDatos = new Font("Courier New", 10);
        private Font fuentePrecios = new Font("Courier New", 12,FontStyle.Bold);
        private float pos_x = 40,pos_y=60;
        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs evento)
        {
            int tamaño=400;
            pos_x = 40;
            pos_y=30;
            String Cine = LblCine.Text;
            String Pelicula = LblPelicula.Text;
            String Total = "Total: " +  LblTotalPago.Text;
            String Vuelto = "Vuelto: " + LblVuelto.Text;
            String Sala = "Sala: " + LblSala.Text;
            String Fecha = "Fecha: " + LblFecha.Text;
            String Asientos = "Asientos: " + LblAsientos.Text;

            //Esto se imprime
            DrawCenteredString(Cine,fuenteTitulo,evento,tamaño,true);
            DrawCenteredString(Pelicula,fuenteTitulo,evento,tamaño,true);
            DrawCenteredString("--------------------------------",fuenteTitulo,evento,tamaño,true);
            DrawCenteredString(Sala,fuenteDatos,evento,tamaño,false);
            DrawCenteredString(Fecha,fuenteDatos,evento,tamaño,false);
            DrawCenteredString(Asientos,fuenteDatos,evento,tamaño,false);
            DrawCenteredString(Total, fuentePrecios, evento, tamaño,false);
            DrawCenteredString(Vuelto, fuentePrecios, evento, tamaño,false);
        }

        private void DrawCenteredString(string Text,Font font, PrintPageEventArgs evento, int Width,bool IsCentered)
        {
            float ProyectedWidth = evento.Graphics.MeasureString(Text, font).Width;
            float ProyectedHeight = evento.Graphics.MeasureString(Text, font).Height;
            float StartX = (Width - ProyectedWidth) / 2;
            if(true)
                evento.Graphics.DrawString(Text, font, Brushes.Black, StartX, pos_y, new StringFormat());
            else
                evento.Graphics.DrawString(Text, font, Brushes.Black, pos_x, pos_y, new StringFormat());
            pos_y += ProyectedHeight + 5;
        }


        private void dgvPrecios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            /*
            ComboBox cmb = e.Control as ComboBox;
            if (cmb != null)
                cmb.SelectedIndex = 0;
        
             */
             }

        private void dgvcmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbprocess = (ComboBox)sender;
            if (cmbprocess.SelectedValue != null)
            {
                //Capturar el indice seleccionado
                double total=Convert.ToDouble(dgvPrecios.Rows[filaSeleccionada].Cells["precio"].Value.ToString())*Convert.ToInt32(cmbprocess.SelectedText.ToString());
                dgvPrecios.Rows[filaSeleccionada].Cells["dgvCbTotal"].Value = total.ToString();
            }

        }

        private void dgvPrecios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrecios.Columns.Count > 3) // como primero comienza con 3 columnas (id,tipoEnt,precio) y despues se añaden 2 mas, valido que esto se ejecute cuando ya tenga las columnas Cantidad y Total
            {

                if (e.ColumnIndex == dgvPrecios.Columns["dgvCbCantidad"].Index && e.RowIndex >= 0)
                {
                    int cantidad = Convert.ToInt32(dgvPrecios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    double precio=Convert.ToDouble(dgvPrecios.Rows[e.RowIndex].Cells["precio"].Value.ToString());
                    dgvPrecios.Rows[e.RowIndex].Cells["dgvCbTotal"].Value = (cantidad*precio).ToString();

                    if (dgvPrecios.Rows[0].Cells["dgvCbTotal"].Value == null)
                    {
                        dgvPrecios.Rows[0].Cells["dgvCbCantidad"].Value = "0";
                        dgvPrecios.Rows[0].Cells["dgvCbTotal"].Value = "0";
                    }
                    if (dgvPrecios.Rows[1].Cells["dgvCbTotal"].Value == null)
                    {
                        dgvPrecios.Rows[1].Cells["dgvCbCantidad"].Value = "0";
                        dgvPrecios.Rows[1].Cells["dgvCbTotal"].Value = "0";
                    }

                    double precio1 = Convert.ToDouble(dgvPrecios.Rows[0].Cells["dgvCbTotal"].Value.ToString());
                    double precio2 = Convert.ToDouble(dgvPrecios.Rows[1].Cells["dgvCbTotal"].Value.ToString());
                    lbTotalNum.Text = (precio1 + precio2)+"";

                 }
            }

            /*
            if (dgvPrecios.SelectedRows.Count != 0)
            {
                double precio = Convert.ToDouble(dgvPrecios.Rows[dgvPrecios.SelectedRows[0].Index].Cells["precio"].Value.ToString());
                
                double cantidad = Convert.ToInt32(dgvPrecios.Rows[dgvPrecios.SelectedRows[0].Index].Cells["dgvCbCantidad"].Value.ToString());

                double total = precio * cantidad;
                int x = 0;
            } */
        }

        private void totalPrecio_Tick(object sender, EventArgs e)
        {
            /*if(dgvPrecios.Columns.Count>3)
            {
                if(cambioValor)//cambio el valor de la cantidad
                {
                    int cantidad = Convert.ToInt32(dgvPrecios.Rows[filaSeleccionada].Cells[columnaSeleccionada].Value.ToString());
                    double precio = Convert.ToDouble(dgvPrecios.Rows[filaSeleccionada].Cells["precio"].Value.ToString());
                    dgvPrecios.Rows[filaSeleccionada].Cells["dgvCbTotal"].Value = (cantidad * precio).ToString();
                    cambioValor = false;
                }
            }*/
        
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if(mostrarMapa)
            {
                if (controlador.manitoEnCasilla(e.X, e.Y,cantEntradasEscogidas))
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;
            }
        }

        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            if(mostrarMapa)
            {
                AsientoViewModel seleccionar = controlador.traerAsientoClickeado(e.X, e.Y,cantEntradasEscogidas);
                if (seleccionar != null)
                    seleccionar.seleccionado = !seleccionar.seleccionado;
            }

        }
        
        private void BtnDinero_Click(object sender, EventArgs e)
        {
            int aumenta = 0;
            aumenta = 10;

            //Dinero a pagar
            double TotalPago = Double.Parse(LblTotalPago.Text.ToString());
            //Cantidad que se acaba de ingresar
            double DineroIngresado = Double.Parse(LblDineroIngresado.Text.ToString());
            //Actualizo el dinero
            LblDineroIngresado.Text = (DineroIngresado + aumenta).ToString();
            //Re-calculo del dinero actual
            DineroIngresado = Double.Parse(LblDineroIngresado.Text.ToString());

            
            //Valido que el saldo cubra el Total de Dinero
            if (TotalPago > DineroIngresado)
            {
                LblVuelto.Text = "0";
            }
            else
            {
                //Mostar un mensaje que ya se puede efectuar el pago
                //Bloquear el ingreso de monedas
                LblVuelto.Text = (-1 * (TotalPago - DineroIngresado)).ToString();
            }
        }

        private void panelPago_Paint(object sender, PaintEventArgs e)
        {

        }
    
    
    }
}
