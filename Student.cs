using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Student(RegistrationNumber regNumber, PlainText name)
        {
            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(regNumber, name)
        {
            Credits = credits;
        }

        public override string ToString()
         {
             return string.Format("{0}:{1}", RegNumber, Name);
        }
    }
}
