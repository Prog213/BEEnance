﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BEEnance.Models
{
    internal class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
