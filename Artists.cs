using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace secrets
{
    public partial class Artists
    {
        public Artists()
        {
            Albums = new HashSet<Albums>();
        }

        public long ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Albums> Albums { get; set; }
    }
}
