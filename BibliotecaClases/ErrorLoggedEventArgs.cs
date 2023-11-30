﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    

    public class ErrorLoggedEventArgs<T> : EventArgs
    {
        public T Error { get; }

        public ErrorLoggedEventArgs(T error)
        {
            Error = error;
        }
    }
}
