using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Core.Interfaces;

namespace UserLogin.Infrastructure.Logger
{
    class DebugLogger : ILogger
    {
        public void Error(string message)
        {
            Write(message, "Error");
        }

        public void Info(string message)
        {
            Write(message, "Info");
        }

        public void Warning(string message)
        {
            Write(message, "Warning");
        }

        private void Write(string message, string level)
        {
            Debug.WriteLine(string.Format("{0}: {1} {2}", level, message, DateTime.Now.ToString("yyyyMMdd hh:mm:ss")));
        }
    }
}
