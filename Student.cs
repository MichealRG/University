using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Zzadanie2
{
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Grades Grade { get; set; }
        public Groupe Group { get; set; }
        public Student(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetNumberOfGroup(Groupe group)
        {
            Group = group;
        }
        public int GetNumberOfGroup()
        {
            return Group.Number;
        }
        public void SetGrade(Grades grade)
        {
            Grade = grade;
        }
        public BitArray GetGradeFromSubject (string name)
        {
            return Grade.SubGrades[name];
        }
        public (string, string, int) GetDefaultInfo ()
        {
            return (FirstName, LastName, Age);
        }
        public void AddGrades(Subject subject, BitArray pass)
        {
            Grade.SubGrades.Add(subject.Name,pass);
        }
    }
}
