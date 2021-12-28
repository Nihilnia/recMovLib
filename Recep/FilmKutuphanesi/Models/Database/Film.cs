using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmKutuphanesi.Models.Database
{
    public class Film
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public double Sure { get; set; }
    }
}