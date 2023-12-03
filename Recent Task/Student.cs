using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recent_Task
{
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string specialty { get; set; }
        public string groupNo { get; set; }

        public override string ToString()
        {
            return $"Name: {name}\nSurname: {surname}\nAge: {age}\nSpecialty: {specialty}\nGroupNo: {groupNo}\n";
        }


    }
}
