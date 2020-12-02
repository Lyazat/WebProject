using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummyset.Pages.Model;

namespace Yummyset.Database
{
    public interface IFoodRepository
    {
        public Food FindFoodByName(string NameOfFood, string DetailsOfFood);
    }
}
