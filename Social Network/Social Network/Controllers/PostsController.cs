using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Social_Network.Models;

namespace Social_Network.Controllers
{
    public class PostsController : ApiController
    {
        private Social_NetworkContext db = new Social_NetworkContext();

        // GET
        public IEnumerable<Post> Get()
        {
            return db.Posts;
        }

        // CREATE
        public IHttpActionResult Post([FromBody]Post post)
        {
            // Validate data
            if (!ModelState.IsValid)
            {
                return BadRequest("The data format is not valid...");
            }

            db.Posts.Add(post);
            db.SaveChanges();

            return Ok("Post has been added");
        }

        // EDIT
        public IHttpActionResult Put(int id, [FromBody]Post post)
        {
            // Validate data
            if (!ModelState.IsValid)
            {
                return BadRequest("The data format is not valid...");
            }

            var result = db.Posts.Find(id);

            if (result == null)
            {
                return BadRequest("Post was not found...");
            }

            result.Comment = post.Comment;
            result.Like = post.Like;
            result.Ratings = post.Ratings;

            db.SaveChanges();
            return Ok("Post has been updated successfully...");
            
        }

    }
}