﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummyset.Pages.Model
{
    public abstract class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string FoodPic { get; set; }
    }
}
