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
    public class ActivityRepository : IRepository<Activity>
    {
        private FitnessContext context;

        public ActivityRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(Activity item)
        {
            context.Activities.Add(item);
        }

        public void Delete(int id)
        {
            var activity = GetById(id);
            if (activity != null)
                context.Activities.Remove(activity);
        }

        public IEnumerable<Activity> GetAll()
        {
            return context.Activities;
        }

        public Activity GetById(int id)
        {
            return context.Activities.Find(id);
        }

        public void Update(Activity item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}