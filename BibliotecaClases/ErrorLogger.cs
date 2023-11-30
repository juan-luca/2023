using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public delegate void ErrorLoggedEventHandler<T>(object sender, ErrorLoggedEventArgs<T> e);

    public class ErrorLogger<T> : IErrorLogger<T>
    {
        public event ErrorLoggedEventHandler<T> ErrorLogged;

        public void LogError(T error)
        {
            LogToFile(error);
            OnErrorLogged(new ErrorLoggedEventArgs<T>(error));
        }

        private void LogToFile(T error)
        {
            string logFilePath = "error_log.txt";
            string logMessage = $"{DateTime.Now}: {error.ToString()}";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }
        }

        protected virtual void OnErrorLogged(ErrorLoggedEventArgs<T> e)
        {
            ErrorLogged?.Invoke(this, e);
        }
    }
}
