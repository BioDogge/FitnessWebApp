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
        IRepositoryCrud<User> Users { get; }
        IRepositoryRead<Activity> Activities { get; }
        IRepositoryCrud<Exercise> Exercises { get; }
        IRepositoryRead<Food> Foods { get; }
        IRepositoryCrud<Eating> Eatings { get; }
        IRepositoryCrud<FoodEating> FoodEatings { get; }

        void Save();
    }
}