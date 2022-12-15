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
    public class EatingRepository : IRepository<Eating>
    {
        private FitnessContext context;

        public EatingRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(Eating item)
        {
            context.Eatings.Add(item);
        }

        public void Delete(int id)
        {
            var eating = GetById(id);
            if (eating != null)
                context.Eatings.Remove(eating);
        }

        public IEnumerable<Eating> GetAll()
        {
            return context.Eatings;
        }

        public Eating GetById(int id)
        {
            return context.Eatings.Find(id);
        }

        public void Update(Eating item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}