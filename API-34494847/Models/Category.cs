﻿using System;
using System.Collections.Generic;

namespace _34494847_API.Models
{
    public partial class Category
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
