﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTesting.Models
{
    public class MovieModel
    {
        public MovieModel()
        {

        }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
        public string imdbID { get; set; }
    }
}
