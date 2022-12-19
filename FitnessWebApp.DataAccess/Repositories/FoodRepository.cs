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
    public class FoodRepository : IRepositoryRead<Food>
    {
        private FitnessContext context;

        public FoodRepository(FitnessContext context)
        {
            this.context = context;
        }

        public IEnumerable<Food> GetAll()
        {
            return context.Foods.Include(f => f.Vitamin);
        }

        public Food GetById(int id)
        {
            return context.Foods.Find(id);
        }
    }
}