using CineEvo.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineEvo.BL.Base
{
    public class BaseUtils
    {
        DbConnection GetConnection()
        {
            using (var db = new CineEvoEntities())
            {
                DbConnection conn = db.Database.Connection;
                try
                {
                    conn.Open();   // check the database connection
                    return conn;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
