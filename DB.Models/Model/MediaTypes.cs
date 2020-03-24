using System;
using System.Collections.Generic;

namespace DB.Models.Model
{
    public partial class MediaTypes
    {
        public MediaTypes()
        {
            Tracks = new HashSet<Tracks>();
        }

        public long MediaTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tracks> Tracks { get; set; }
    }
}
