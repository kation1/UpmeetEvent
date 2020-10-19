using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using UpmeetProject.Models;

namespace UpmeetProject.Services
{


    public class DAL : IDAL
    {

        private string connString;
        public DAL(IConfiguration config)
        {
            connString = config.GetConnectionString("rick");
        }

        public Event AddEvent()
        {
            throw new NotImplementedException();
        }

        public int AddFavorite(int id)
        {
            throw new NotImplementedException();
        }

        public Event GetEvent(int id)
        {

            SqlConnection conn = new SqlConnection(connString);
            string command = "SELECT * FROM Events WHERE ID=@id";
            Event result = (Event)conn.Query<Event>(command, new { id });
            return result;

        }

        public Favorite GetFavorite(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetList()
        {
            throw new NotImplementedException();
        }

        public int RemoveFavorite(int id)
        {
            throw new NotImplementedException();
        }
    }
}
