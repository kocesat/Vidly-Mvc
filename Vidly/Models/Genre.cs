﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public short Id { get; set; }
    }
}