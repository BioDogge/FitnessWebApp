using FitnessWebApp.DataAccess.EF;
using FitnessWebApp.DataAccess.Entities;
using FitnessWebApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.DataAccess.Repositories
{
    public class FoodEatingRepository : IRepository<FoodEating>
    {
        private FitnessContext context;

        public FoodEatingRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(FoodEating item)
        {
            context.FoodEatings.Add(item);
        }

        public void Delete(int id)
        {
            var foodEating = GetById(id);
            if (foodEating != null)
                context.FoodEatings.Remove(foodEating);
        }

        public IEnumerable<FoodEating> GetAll()
        {
            return context.FoodEatings.Include(e => e.Eating).Include(f => f.Food);
        }

        public FoodEating GetById(int id)
        {
            return context.FoodEatings.Find(id);
        }

        public void Update(FoodEating item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}