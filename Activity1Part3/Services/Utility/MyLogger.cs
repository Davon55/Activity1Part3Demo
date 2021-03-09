using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity1Part3.Services.Utility
{
    public class MyLogger : ILogger
    {
        //singleton pattern example, Only one instance of this class can be instanciated 
        private static MyLogger instance; // singleton design patern. single instance of this class
       // private static Logger logger;








        public void Debug(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, string arg = null)
        {
            throw new NotImplementedException();
        }
    }
}
