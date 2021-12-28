using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmKutuphanesi.Models.Database
{
    public class GloriaContext: DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source  = .\SQLEXPRESS; Initial Catalog = MovieLibrary; Integrated Security = SSPI");
        }
    }
}