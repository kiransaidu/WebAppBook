﻿using System;
using System.Collections.Generic;

namespace WebAppBook.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double? Price { get; set; }
        public string? Author { get; set; }
    }
}
