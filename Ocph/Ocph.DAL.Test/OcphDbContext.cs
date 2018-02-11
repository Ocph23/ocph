using Ocph.DAL.Provider.MySql;
using Ocph.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocph.DAL.Test
{
   public class OcphDbContext:MySqlDbConnection
    {
        public OcphDbContext()
        {
            ConnectionString = "Server=localhost;Database=ongkir;Uid=root;Pwd=";
        }

        public IRepository<province> apakek { get { return new Repository<province>(this); } }


    }
}
