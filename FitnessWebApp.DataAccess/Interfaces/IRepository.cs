using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get all data from the database table specifed in the generic type parameter.
        /// </summary>
        /// <returns>All data from the table</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Get one element
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

        //TODO: Need to comment this.
    }
}