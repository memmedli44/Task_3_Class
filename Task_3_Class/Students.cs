using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_3_Class
{
    internal class Students
    {
        public string name;
        public string surname;
        public int age;
        public string speciality;
        public int  groupNo;

        public override string ToString()
        {
            return $"{name} {surname} {age} {speciality} {groupNo}";
        }
        //public void printInfo()
        //{
        //    Console.WriteLine(name); 
        //    Console.WriteLine(surname);
        //    Console.WriteLine(age);
        //    Console.WriteLine(speciality);
        //    Console.WriteLine(groupNo);
        //}
    }
}
