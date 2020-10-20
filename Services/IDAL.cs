using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpmeetProject.Models;

namespace UpmeetProject.Services
{
    public interface IDAL
    {

        IEnumerable<string> GetEventList();
        //Maybe a class?

        int AddEvent(Event e);

        Event GetEvent(int id);
        //Maybe a long?

        Favorite GetFavorite(int id);

        int AddFavorite(Favorite f);

        int RemoveFavorite(int id);



    }
}
