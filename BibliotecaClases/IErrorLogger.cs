using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public interface IErrorLogger<T>
    {
        void LogError(T error);
    }
}
