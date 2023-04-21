using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }

        public ValidationException(string[] errors) : base("Multiple errors.")
        {
            Errors = errors;
        }

        public string[] Errors { get; set; }
    }
}
