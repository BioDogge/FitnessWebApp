using FitnessWebApp.DataAccess.EF;
using FitnessWebApp.DataAccess.Entities;
using FitnessWebApp.DataAccess.Interfaces;
using FitnessWebApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private FitnessContext context;

        private ActivityRepository? activityRepository;
        private EatingRepository? eatingRepository;
        private ExerciseRepository? exerciseRepository;
        private FoodEatingRepository? foodEatingRepository;
        private FoodRepository? foodRepository;
        private UserRepository? userRepository;

        public UnitOfWork() => context = new FitnessContext();

        public IRepository<Activity> Activities
        {
            get
            {
                if (activityRepository == null)
                    activityRepository = new ActivityRepository(context);
                return activityRepository;
            }
        }

        public IRepository<Eating> Eatings
        {
            get
            {
                if (eatingRepository == null)
                    eatingRepository = new EatingRepository(context);
                return eatingRepository;
            }
        }

        public IRepository<Exercise> Exercises
        {
            get
            {
                if (exerciseRepository == null)
                    exerciseRepository = new ExerciseRepository(context);
                return exerciseRepository;
            }
        }

        public IRepository<FoodEating> FoodEatings
        {
            get
            {
                if (foodEatingRepository == null)
                    foodEatingRepository = new FoodEatingRepository(context);
                return foodEatingRepository;
            }
        }

        public IRepository<Food> Foods
        {
            get
            {
                if (foodRepository == null)
                    foodRepository = new FoodRepository(context);
                return foodRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(context);
                return userRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposed)
        {
            if (!this.disposed)
            {
                if (disposed)
                    context.Dispose();
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}