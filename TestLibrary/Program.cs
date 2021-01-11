using System;
using AClassLibrary;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //LivingPerson p = new LivingPerson();
            LivingPerson person = new LivingPerson(12);
            person.Age = 34;
        }
    }
}
