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
    public class ActivityRepository : IRepositoryRead<Activity>
    {
        private FitnessContext context;

        public ActivityRepository(FitnessContext context)
        {
            this.context = context;
        }

        public IEnumerable<Activity> GetAll()
        {
            return context.Activities;
        }

        public Activity GetById(int id)
        {
            return context.Activities.Find(id);
        }
    }
}