using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace body_members
{
    public class Student
    {
        public string Name { get; set; }
        public string SubName { get; set; }
        //public string FullName { get; set; }
        public string Age { get; set; }

        public string FullName => $"{Name}, {Age}";


        /*
        public override string ToString()
        {
            return $"{FullName}, {Age}";
        }*/

        public override string ToString()=> $"{FullName}, {Age}";

        private int age;
        public int Age2
        {
            get => age;
            set => age= value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
        }

       /* public Student(string name, string surname, int age)
        {
            Name = name;
            SubName = surname;
            Age = age;

        }*/

        public Student(string name, string surname, string age) => (Name, SubName, Age) = (name, surname, age);

        ~Student()
        {
            Name = "";

        }


    }
}
