using System;
using System.Collections.Generic;

#nullable disable

namespace EFCinema
{
    public partial class Prenotazione
    {
        public int Nposti { get; set; }
        public string Mail { get; set; }
        public int ProgramId { get; set; }
        public int Id { get; set; }

        public virtual Programmazione Program { get; set; }
    }
}
