using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpmeetProject.Models;
using UpmeetProject.Services;

namespace UpmeetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {

        private IDAL dal;
        public FavoriteController(IDAL dal)
        {
            this.dal = dal;
        }
        [HttpGet]
        public IEnumerable<UserFavorite> GetFavoriteList()
        {
            return dal.GetFavoriteList();
        }
        [HttpGet("{id}")]
        public Favorite GetFavorite(int id)
        {
            return dal.GetFavorite(id);
        }

        [HttpDelete("delete/{id}")]
        public void RemoveFavorite(int id)
        {
            dal.RemoveFavorite(id);
        }

        [HttpPost("addfavorite")]
        //Might need [FromBody]
        public void AddEvent(Favorite F)
        {
            dal.AddFavorite(F);
        }
    }
}
