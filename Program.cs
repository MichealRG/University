using System;
using System.Collections;
using System.Collections.Generic;

namespace Zzadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //przedmioty
            Subject sub1 = new Subject("Bazy danych");
            Subject sub2 = new Subject("Sieci");
            Subject sub3 = new Subject("Programowanie");
            List<Subject> subjectList = new List<Subject>();
            subjectList.Add(sub1);
            subjectList.Add(sub2);
            subjectList.Add(sub3);
            //grupy
            Groupe groupe1 = new Groupe(1, subjectList);
            Groupe groupe2 = new Groupe(2, subjectList);
            //Nauczyciele
            Teacher tech1 = new Teacher("Jan", "Nowak", "Prof");
            Teacher tech2 = new Teacher("Kazimierz", "Kowalski", "Prof");
            Teacher tech3 = new Teacher("Robert", "Król", "Dr");
            tech1.SetLeadingSubjects(subjectList);
            tech2.SetLeadingSubject(sub2);
            tech3.SetLeadingSubject(sub1);
            tech3.SetLeadingSubject(sub3);
            //Studenci
            Student stud1 = new Student("Anna", "K", 20);
            Student stud2 = new Student("Kasia", "S", 19);
            Student stud3 = new Student("Ola", "T", 19);
            Student stud4 = new Student("Andrzej", "O", 20);
            Student stud5 = new Student("Michal", "L", 27);
            Student stud6 = new Student("Marek", "K", 21);
            stud1.SetNumberOfGroup(groupe1);
            stud2.SetNumberOfGroup(groupe2);
            stud3.SetNumberOfGroup(groupe1);
            stud4.SetNumberOfGroup(groupe2);
            stud5.SetNumberOfGroup(groupe1);
            stud6.SetNumberOfGroup(groupe2);
            //Oceny

            stud1.AddGrades(sub1, getRandomGrade());
            stud1.AddGrades(sub2, getRandomGrade());
            stud1.AddGrades(sub3, getRandomGrade());

            stud2.AddGrades(sub1, getRandomGrade());
            stud2.AddGrades(sub2, getRandomGrade());
            stud2.AddGrades(sub3, getRandomGrade());

            stud3.AddGrades(sub1, getRandomGrade());
            stud3.AddGrades(sub2, getRandomGrade());
            stud3.AddGrades(sub3, getRandomGrade());

            stud4.AddGrades(sub1, getRandomGrade());
            stud4.AddGrades(sub2, getRandomGrade());
            stud4.AddGrades(sub3, getRandomGrade());

            stud5.AddGrades(sub1, getRandomGrade());
            stud5.AddGrades(sub2, getRandomGrade());
            stud5.AddGrades(sub3, getRandomGrade());

            stud6.AddGrades(sub1, getRandomGrade());
            stud6.AddGrades(sub2, getRandomGrade());
            stud6.AddGrades(sub3, getRandomGrade());

        }
        public static BitArray getRandomGrade()
        {
            var rnd = new Random();

            BitArray grade = new BitArray(
            new[] {
                        (rnd.Next(100) < 50 ? false : true),
                        (rnd.Next(100) < 50 ? false : true),
                        (rnd.Next(100) < 50 ? false : true),
            });
            return grade;
        }
    }
}
