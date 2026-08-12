using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    internal class DataBase
    {
        public static string connectionString;
        public int age;

        static DataBase(){
            connectionString = "Some connection";
        }

        public DataBase(int age) { 
            this.age = age;
        }
    }
}
