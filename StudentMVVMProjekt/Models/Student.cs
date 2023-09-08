using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace StudentMVVMProjekt.Models
{
    public enum SchoolClassType { CLASS_A, CLASS_B, CLASS_C }

    public class Student
    {
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.CLASS_A;
            EducationLevel = new List<string>();
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int year, SchoolClassType schoolClass)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = year;
            SchoolClass = schoolClass;
            EducationLevel = AllEducationLevel;
        }



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public List<string> EducationLevel { get; set; }       
    }
}