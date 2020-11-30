using System;
using System.Collections.Generic;

namespace EFCinema
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------");

            var movie = new Movie()
            {
                Title = "La donna che visse due volte",
                Durata = 125,
                Genere = "Azione"
            };

            Esercizi.fetchMovies();


        }
    }
}
