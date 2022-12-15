using FitnessWebApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Activity> Activities { get; }
        IRepository<Exercise> Exercises { get; }
        IRepository<Food> Foods { get; }
        IRepository<Eating> Eatings { get; }
        IRepository<FoodEating> FoodEatings { get; }

        void Save();
    }
}