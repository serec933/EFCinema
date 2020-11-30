using System;
using System.Collections.Generic;

#nullable disable

namespace EFCinema
{
    public partial class Programmazione
    {
        public Programmazione()
        {
            Prenotaziones = new HashSet<Prenotazione>();
        }

        public int Id { get; set; }
        public int MovieId { get; set; }
        public int? SalaId { get; set; }
        public TimeSpan? Orario { get; set; }
        public decimal? Prezzo { get; set; }
        public int? PostiDisponibili { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Sale Sala { get; set; }
        public virtual ICollection<Prenotazione> Prenotaziones { get; set; }
    }
}
