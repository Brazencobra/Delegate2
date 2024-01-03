using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2.Models
{
    internal class Student
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                if (value.Trim().Length <= 15 && value.Trim().Length >= 3)
                {
                    _name = value.Trim();
                }
            } 
        }
        //public string Surname { get; set; }
        //public int Age { get; set; }

        public Student(string name/*,string surname,int age*/)
        {
            Name = name;
            //Surname = surname;
            //Age = age;
        }
    }
}
