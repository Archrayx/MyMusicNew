﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyMusic.Core.Models
{
    public class Artist
    {
        public Artist()
        {
            Musics = new Collection<Music>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; }

    }
}
