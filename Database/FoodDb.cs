using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummyset.Pages.Delivery;
using Yummyset.Pages.Model;

namespace Yummyset.Database
{
    public class FoodDb : IFoodRepository

    {
        private readonly AppDbContext _context;

        public FoodDb(AppDbContext context)
        {
            _context = context;
        }
        public Food FindFoodByName(string NameOfFood, string DetailsOfFood)
        {
            if (NameOfFood == null) { return null; }
            if (NameOfFood.Equals("Burger"))
            {
                Food food = _context.Burgers.Where(x => x.Name.Contains(DetailsOfFood)).FirstOrDefault(x => x.Id == 1);
                return food;
            }
            if (NameOfFood.Equals("Sushi"))
            {
                Food food = _context.Sushis.Where(x => x.Name.Contains(DetailsOfFood)).FirstOrDefault(x => x.Id == 1);
                return food;
            }
            if (NameOfFood.Equals("Pizza"))
            {
                Food food = _context.Pizza.Where(x => x.Name.Contains(DetailsOfFood)).FirstOrDefault(x => x.Id == 1);
                return food;
            }
            else return null;
        }
    }
}
