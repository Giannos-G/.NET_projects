using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class Person
    {
        //Properties
        public string Name { get; set; } // gia na mporo na ta kalo me tin telia "."

        public void SetName (string _name)
        {
            name = _name;
        }

        public void GetName()
        {
            return name;
        }
    }
}
