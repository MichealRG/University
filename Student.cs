using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Zzadanie2
{
    class Student:IDisplayingInfo
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Grades Grade { get; set; } = new Grades();
        public Groupe Group { get; set; }  
        public Student(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetGroup(Groupe group)
        {
            Group = group;
        }
        public int GetNumberOfGroup()
        {
            return Group.Number;
        }

        public BitArray GetGradeFromSubject (string name)
        {
            return Grade.SubGrades[name];
        }
        public (string, string, string) GetDefaultInfo ()
        {
            return (FirstName, LastName, Age.ToString());
        }
        public void AddGrades(Subject subject, BitArray pass)
        {
            Grade.SubGrades.Add(subject.Name,pass);
        }
    }
}
