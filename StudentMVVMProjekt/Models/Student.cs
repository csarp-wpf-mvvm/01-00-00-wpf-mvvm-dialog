using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace StudentMVVMProjekt.Models
{
    public enum SchoolClassType { CLASS_A, CLASS_B, CLASS_C }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateAndTime BirthsDay { get; set; }
        public int Year { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public List<string> EducationLevel { get; set; }


    }
}