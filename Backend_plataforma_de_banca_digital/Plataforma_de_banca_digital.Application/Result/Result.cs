using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Application.Result
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }

        public T? Value { get; set; }

        public string? Error { get; set; }

        //var successResult = Result<string>.Success("Operación exitosa");
        // Crea un Result<string> con IsSuccess = true y Value = "Operación exitosa"

        //var resultado = Result<int>.Success(42); // Sin crear una instancia de Result<int>
        /*var resultado = new Result<int>
        {
            IsSuccess = true,
            Value = 42
        };*/

        public static Result<T> Success(T value) => new Result<T>
        {
            IsSuccess =true,
            Value = value
        };

        /*
         public static Result<T> Success(T value)
{
    return new Result<T>
    {
        IsSuccess = true,
        Value = value
    };
}

         */

        public static Result<T> Failure(string error) => new Result<T>
        {
            IsSuccess = false,
            Error = error
        };
    }
}
