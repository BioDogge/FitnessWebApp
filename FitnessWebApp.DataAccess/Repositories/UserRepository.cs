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
    public class UserRepository : IRepositoryCrud<User>
    {
        private FitnessContext context;

        public UserRepository(FitnessContext context)
        {
            this.context = context;
        }

        public void Create(User item)
        {
            context.Users.Add(item);
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
                context.Users.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users.Include(u => u.Gender);
        }

        public User GetById(int id)
        {
            return context.Users.Find(id);
        }

        public void Update(User item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}