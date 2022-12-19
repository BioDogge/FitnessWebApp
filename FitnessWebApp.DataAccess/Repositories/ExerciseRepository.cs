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
    public class ExerciseRepository : IRepositoryCrud<Exercise>
    {
        private FitnessContext context;

        public ExerciseRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(Exercise item)
        {
            context.Exercises.Add(item);
        }

        public void Delete(int id)
        {
            var exercise = GetById(id);
            if (exercise != null)
                context.Exercises.Remove(exercise);
        }

        public IEnumerable<Exercise> GetAll()
        {
            return context.Exercises.Include(e => e.Activity);
        }

        public Exercise GetById(int id)
        {
            return context.Exercises.Find(id);
        }

        public void Update(Exercise item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}