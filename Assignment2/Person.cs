using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Person
    {
        public string firstName { get; set; }   //  Class member
        public string lastName { get; set; }    //  Class member

        public abstract void SayName();         //  Creted a method called SayName


    }
}
