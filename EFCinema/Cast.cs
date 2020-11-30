using System;
using System.Collections.Generic;

#nullable disable

namespace EFCinema
{
    public partial class Cast
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
