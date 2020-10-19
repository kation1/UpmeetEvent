using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpmeetProject.Models;

namespace UpmeetProject.Services
{
    public interface IDAL
    {

        IEnumerable<string> GetList();
        //Maybe a class?

        Event AddEvent();

        Event GetEvent(int id);
        //Maybe a long?

        Favorite GetFavorite(int id);

        int AddFavorite(int id);

        int RemoveFavorite(int id);



    }
}
