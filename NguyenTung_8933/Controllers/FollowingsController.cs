using Microsoft.AspNet.Identity;
using NguyenTung_8933.DTOs;
using NguyenTung_8933.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace NguyenTung_8933.Controllers
{
    public class FollowingsController : ApiController
    {
        // GET: Followings
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }


        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var folowing = new Following
            {
                FollowerId = followingDto.FolloweeId,
                FolloweeId = userId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}