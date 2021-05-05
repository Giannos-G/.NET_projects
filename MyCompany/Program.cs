using System;   //namespace

namespace MyCompany  // build your own namespace
{                   // curly bracket 
    class Program           // ti tha exei mesa i klasi  
    {                       
        static void Main(string[] args)         //method signature, anafora tis klasis, panta proti
        {
            Person person = new Person
            {
                Name = "Giannos"        // an eixa alla variables diaxorizo me komma
            };
            person.Name="Giannos";
            Console.WriteLine(person.Name);
            Console.WriteLine("Hello World!");
        }
    }
}
