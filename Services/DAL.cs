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

        public void AddEvent(Event e)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "INSERT INTO Event (Name, Date) VALUES (@Name, @Date)";
            conn.Execute(command, new
            {
                Name = e.Name,
                Date = e.Date
            });
            //return result; Changed to Void
        }

        public void RemoveFavorite(long id)
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
            string command = "SELECT Favorite.id, Event.name, Event.date, Favorite.userid FROM Event INNER JOIN Favorite ON Event.id = Favorite.eventid Where userid = 'TestUser'";   ///User Input at TestUser
            IEnumerable<UserFavorite> result = conn.Query<UserFavorite>(command);
            return result;
        }

        public void AddFavorite(Favorite f)
        {
            SqlConnection conn = new SqlConnection(connString);
            string command = "INSERT INTO Favorite (UserId, EventId) VALUES (@UserId, @EventId)";
            conn.Execute(command, new
            {
                UserId = f.UserId,
                EventId = f.EventId
            });
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
