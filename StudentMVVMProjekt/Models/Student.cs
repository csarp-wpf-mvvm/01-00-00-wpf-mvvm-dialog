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
            Year = 9;
            SchoolClass = SchoolClassType.CLASS_A;
            EducationLevel = new List<string>();
        }

        public Student(string firstName, string lastName, DateTime birthsDay, int year, SchoolClassType schoolClass, List<string> educationLevel)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            Year = year;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int Year { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public List<string> EducationLevel { get; set; }       
    }
}