using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCinema
{
    public class Esercizi
    {
        //Lettura 
        public static void fetchMovies()
        {
            //inizializzo il context
            using (var cxt = new CinemaDBContext())
            {


                foreach (var item in cxt.Movies)
                {
                    Console.WriteLine("ID: {0}, Titolo: {1}",item.Id,item.Title);
                }

            }

        }

        //aggiunger film
        public static void insertMovie(Movie m)
        {
            using (var cxt = new CinemaDBContext())
            {
                cxt.Movies.Add(m);
                cxt.SaveChanges();
            }
        }
        //Delete modalità connessa
        public static void deleteMovie()
        {
            using (var ctx = new CinemaDBContext())
            {
                var f = ctx.Movies.Find(7);
                Console.WriteLine("Sto eleiminando il film: {0}", f.Title);

                ctx.Movies.Remove(f);
                ctx.SaveChanges();
            }
        }
        //Delete modalità disconnessa
        public static void deleteMovieD()
        {
            var f = new Movie();
            using (var ctx = new CinemaDBContext())
            {
                f = ctx.Movies.Find(10);
            }

            using (var ctx = new CinemaDBContext())
            {
                ctx.Entry<Movie>(f).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }
    }
}
