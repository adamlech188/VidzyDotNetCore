using System;
using System.Collections.Generic;

namespace VidzyLibrary.Models
{
    public partial class Videos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte? GenreId { get; set; }
        public Classification Classification { get; set; }

        public virtual Genres Genre { get; set; }
    }
}
