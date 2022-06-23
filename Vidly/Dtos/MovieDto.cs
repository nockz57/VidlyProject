﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
        
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "The Number in Stock must be between 1 and 20")]
        public short NumberInStock { get; set; }

    }
}