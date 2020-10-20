﻿using System;
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
        public IEnumerable<Favorite> GetFavoriteList()
        {
            return dal.GetFavoriteList();
        }
        [HttpGet("{id}")]
        public Favorite GetFavorite(int id)
        {
            return dal.GetFavorite(id);
        }
    }
}