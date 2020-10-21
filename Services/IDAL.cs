using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpmeetProject.Models;

namespace UpmeetProject.Services
{
    public interface IDAL
    {

        IEnumerable<Event> GetEventList();
        //Maybe a class?

        IEnumerable<UserFavorite> GetFavoriteList();

        void AddEvent(Event e);

        Event GetEvent(long id);
        //Maybe a long?

        Favorite GetFavorite(int id);

        int AddFavorite(Favorite f);

        void RemoveFavorite(long id);



    }
}
