using System;
using System.Collections.Generic;

#nullable disable

namespace EFCinema
{
    public partial class Movie
    {
        public Movie()
        {
            Casts = new HashSet<Cast>();
            Programmaziones = new HashSet<Programmazione>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genere { get; set; }
        public int? Durata { get; set; }

        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Programmazione> Programmaziones { get; set; }
    }
}
