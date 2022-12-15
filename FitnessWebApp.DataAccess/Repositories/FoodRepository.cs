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
    public class FoodRepository : IRepository<Food>
    {
        private FitnessContext context;

        public FoodRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(Food item)
        {
            context.Foods.Add(item);
        }

        public void Delete(int id)
        {
            var food = GetById(id);
            if (food != null)
                context.Foods.Remove(food);
        }

        public IEnumerable<Food> GetAll()
        {
            return context.Foods.Include(f => f.Vitamin);
        }

        public Food GetById(int id)
        {
            return context.Foods.Find(id);
        }

        public void Update(Food item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}