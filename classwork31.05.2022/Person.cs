using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork31._05._2022
{
    class Person
    {
        public int Age { get; set; }
        public static int _age;
        public Person() 
        {
            _age++;
            Age = _age;
        }
        
    }
}
