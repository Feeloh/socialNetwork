using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Social_Network.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please type in your comment...")]
        public string Comment { get; set; }

        public bool Like { get; set; }

        [Range(1, 5, ErrorMessage = "Ratings value should from 1 to 5...")]
        public int Ratings { get; set; }
    }
}