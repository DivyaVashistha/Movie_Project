using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPIDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateReleased { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        [ForeignKey("Genre")]
        public int Genre_Id { get; set; }
    }
}