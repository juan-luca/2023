using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class CustomError
    {
        public string ErrorMessage { get; set; }

        public CustomError(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public override string ToString()
        {
            return ErrorMessage;
        }
    }
}
