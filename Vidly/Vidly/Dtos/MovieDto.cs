﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Required]
        public Byte GenreId { get; set; }


        public DateTime DateAdded { get; set; }


        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}