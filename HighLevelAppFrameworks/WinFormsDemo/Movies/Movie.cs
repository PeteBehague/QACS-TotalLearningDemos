﻿using System;
using System.Collections.Generic;

namespace WinFormsDemo.Movies
{
    public partial class Movie
    {
        public Movie()
        {
            Companies = new HashSet<ProductionCompany>();
             Genres = new HashSet<Genre>();
        }

        public int MovieId { get; set; }
        public string? Title { get; set; }
        public int? Budget { get; set; }
        public string? Homepage { get; set; }
        public string? Overview { get; set; }
        public decimal? Popularity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public long? Revenue { get; set; }
        public int? Runtime { get; set; }
        public string? MovieStatus { get; set; }
        public string? Tagline { get; set; }
        public decimal? VoteAverage { get; set; }
        public int? VoteCount { get; set; }

        public virtual ICollection<ProductionCompany> Companies { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
     }
}
