using System;
using System.Collections.Generic;

namespace VidzyLibrary.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Videos = new HashSet<Videos>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Videos> Videos { get; set; }
    }
}
