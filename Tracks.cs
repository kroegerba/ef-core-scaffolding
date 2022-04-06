using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace secrets
{
    public partial class Tracks
    {
        public Tracks()
        {
            InvoiceItems = new HashSet<InvoiceItems>();
            PlaylistTrack = new HashSet<PlaylistTrack>();
        }

        public long TrackId { get; set; }
        public string Name { get; set; }
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public byte[] UnitPrice { get; set; }

        public virtual Albums Album { get; set; }
        public virtual Genres Genre { get; set; }
        public virtual MediaTypes MediaType { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<PlaylistTrack> PlaylistTrack { get; set; }
    }
}
