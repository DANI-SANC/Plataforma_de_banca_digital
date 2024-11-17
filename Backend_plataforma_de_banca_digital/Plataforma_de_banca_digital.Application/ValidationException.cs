using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application
{
    public sealed class ValidationException : Exception
    {



        public ValidationException(IEnumerable<ValidationError> errors)
        {
            Errors = errors;
        }


        public IEnumerable<ValidationError> Errors { get; }
    }
}
