using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using CineEvo.DataModel;

namespace CineEvo.BL
{
    public class CineBL
    {
        private CineEvoEntities datacontext;

        public CineBL()
        {
            datacontext = new CineEvoEntities();
        }

        public List<Cine> ListarCines()
        {
            try
            {
                return datacontext.Cine.ToList();
            }
            catch (Exception E)
            {
                throw E;
            }
        }


    }
}
