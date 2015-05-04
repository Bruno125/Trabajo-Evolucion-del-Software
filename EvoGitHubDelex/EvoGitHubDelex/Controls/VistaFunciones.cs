﻿using CineEvo.BL;
using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
namespace CineEvo.UI.Controls
{
    public partial class VistaFunciones : CineEvo.UI.Controls.BaseControl
    {
        FuncionBL objFuncionBL = FuncionBL.ObtenerInstancia();
        PeliculaBL objPeliculaBL = PeliculaBL.ObtenerInstancia();
        TipoFuncionBL objTipoFuncionBL = TipoFuncionBL.ObtenerInstancia();
        SalaBL objSalaBL = SalaBL.ObtenerInstancia();
        Cine cine;

        public VistaFunciones(Cine cine, ControlListener ControlListener)
            : base(ControlListener)
        {
            InitializeComponent();
            this.cine = cine;
            SetTitulo(cine.nombre);
        }

        public VistaFunciones()
        {
            InitializeComponent();
            SetTitulo("Nombre del cine");
        }


        public List<FuncionGridWrapper> ObtenerData()
        {
            List<FuncionGridWrapper> GridData = new List<FuncionGridWrapper>();
            try
            {
                IList<Funcion> funciones = objFuncionBL.ObtenerFunciones();
                IList<Pelicula> peliculas = objPeliculaBL.ObtenerPeliculas();
                IList<TipoFuncion> tipos_funcion = objTipoFuncionBL.ObtenerTiposFuncion();
                IList<Sala> salas = objSalaBL.ObtenerSalas();
                DateTime now = DateTime.Now;
                var data =
                    from p in peliculas
                    join f in funciones on p.idPelicula equals f.idPelicula
                    into pelicula_funcion
                    from pf in pelicula_funcion
                    join t in tipos_funcion on pf.idTipoFuncion equals t.idTipoFuncion
                    into pft
                    join s in salas on pf.idSala equals s.idSala
                    where (pf.fechaFuncion.Date.Date == now.Date
                            && s.idCine == cine.idCine)
                    //       && DateTime.Compare(pf.fechaFuncion.Date,now.Date)>0)
                    select new FuncionGridWrapper()
                    {
                        id_funcion = pf.idFuncion,
                        NombrePelicula = pf.Pelicula.titulo,
                        horario = pf.fechaFuncion,
                        tipo_funcion = pf.TipoFuncion.nombre,
                        sala = s.nombre
                    };

                GridData = data.ToList();
            }
            catch (Exception E)
            {
                return null;
            }
            return GridData;
        }

        private void VistaFunciones_Load(object sender, EventArgs e)
        {
            List<FuncionGridWrapper> Data = ObtenerData();
            if (Data != null && Data.Count > 0)
                DgvFunciones.DataSource = ObtenerData();
            //else
            //{
            //    MessageBox.Show("No hay funciones disponibles para este local el día de hoy");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIdFuncion =
                    (DgvFunciones.SelectedRows[0].DataBoundItem as FuncionGridWrapper).id_funcion;
                MessageBox.Show("Id_funcion: " + SelectedIdFuncion);
            }
            catch (Exception E)
            {
                MessageBox.Show("Selecciona una funcion");
            }
        }

    }


    public class FuncionGridWrapper
    {
        public int id_funcion { get; set; }
        public string NombrePelicula { get; set; }
        public DateTime horario { get; set; }
        public string tipo_funcion { get; set; }
        public string sala { get; set; }
    }
}
