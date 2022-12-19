using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebApp.BL.Infrastructure
{
    public class ValidationException : Exception
    {
        public string NameOfProperty { get; set; } = string.Empty;

        public ValidationException(string message, string nameOfProperty)
            : base(message)
        {
            NameOfProperty = nameOfProperty;
        }
    }
}