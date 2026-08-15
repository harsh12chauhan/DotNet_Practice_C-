using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsTryCatchFinally
{
    internal class MyCustomException : Exception
    {

        public MyCustomException(string message):base(message) { 
                   
        }

    }
}
