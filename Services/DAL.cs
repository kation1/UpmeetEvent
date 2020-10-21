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

        public long AddEvent(Event e)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "INSERT INTO Event (Name, Date) VALUES (@Name, @Date)";
            long result = conn.Execute(command, new
            {
                Name = e.Name,
                Date = e.Date
            });
            return result;
        }

        public void RemoveFavorite(int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "DELETE FROM Favorite WHERE ID=@id";
            conn.Execute(command, new { id = id });
            //int result = conn.Execute(command, new { id = id });
            //return result;
        }

        public Event GetEvent(long id)
        {
            SqlConnection conn = new SqlConnection(connString);
            //string command = $"SELECT * FROM Event WHERE ID= {id}";
            string command = "SELECT * FROM Event WHERE ID= @id";
            Event result = conn.QueryFirst<Event>(command, new { id = id });
            return result;
        }

        public IEnumerable<Event> GetEventList()
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "SELECT * FROM Event";
            IEnumerable<Event> result = conn.Query<Event>(command);
            return result;
        }

        public IEnumerable<UserFavorite> GetFavoriteList()
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "SELECT Event.name, Event.date, Favorite.userid FROM Event INNER JOIN Favorite ON Event.id = Favorite.eventid Where userid = 'TestUser'";   ///User Input at TestUser
            IEnumerable<UserFavorite> result = conn.Query<UserFavorite>(command);
            return result;
        }

        public int AddFavorite(Favorite f)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "INSERT INTO Favorite (Id, UserId, EventId) VALUES (@Id, @UserId, @EventId)";
            int result = conn.Execute(command, new
            {
                Id = f.Id,
                UserId = f.UserId,
                EventId = f.EventId
            });
            conn.Close();
            return result;
        }

        public Favorite GetFavorite(int id)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "SELECT * FROM Favorite WHERE ID=@id";
            Favorite result = conn.QueryFirst<Favorite>(command, new { id });
            return result;
        }


    }
}
