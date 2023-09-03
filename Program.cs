using System;
using System.Collections;
using System.Collections.Generic;

namespace Zzadanie2
{
    class Program
    {
        static void Main()
        {
            //przedmioty
            Subject sub1 = new Subject("Bazy danych");
            Subject sub2 = new Subject("Sieci");
            Subject sub3 = new Subject("Programowanie");
            List<Subject> subjectList = new List<Subject>
            {
                sub1,
                sub2,
                sub3
            };
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
            stud1.SetGroup(groupe1);
            stud2.SetGroup(groupe2);
            stud3.SetGroup(groupe1);
            stud4.SetGroup(groupe2);
            stud5.SetGroup(groupe1);
            stud6.SetGroup(groupe2);
            //Oceny


            stud1.AddGrades(sub1, GetRandomGrade());
            stud1.AddGrades(sub2, GetRandomGrade());
            stud1.AddGrades(sub3, GetRandomGrade());

            stud2.AddGrades(sub1, GetRandomGrade());
            stud2.AddGrades(sub2, GetRandomGrade());
            stud2.AddGrades(sub3, GetRandomGrade());

            stud3.AddGrades(sub1, GetRandomGrade());
            stud3.AddGrades(sub2, GetRandomGrade());
            stud3.AddGrades(sub3, GetRandomGrade());

            stud4.AddGrades(sub1, GetRandomGrade());
            stud4.AddGrades(sub2, GetRandomGrade());
            stud4.AddGrades(sub3, GetRandomGrade());

            stud5.AddGrades(sub1, GetRandomGrade());
            stud5.AddGrades(sub2, GetRandomGrade());
            stud5.AddGrades(sub3, GetRandomGrade());

            stud6.AddGrades(sub1, GetRandomGrade());
            stud6.AddGrades(sub2, GetRandomGrade());
            stud6.AddGrades(sub3, GetRandomGrade());

            //DisplayCLass
            Display Displaying = new Display();
            Displaying.DisplayData(tech1.GetDefaultInfo());
            Displaying.DisplayData(tech1.GetSubjects());
            Console.WriteLine();
            Displaying.DisplayData(stud3.GetDefaultInfo());
            Displaying.DisplayData(stud3.GetGradeFromSubject("Programowanie"));
            Displaying.DisplayData(stud3.GetNumberOfGroup());

            //Console.WriteLine(stud1.GetNumberOfGroup());
            //Console.WriteLine(stud2.GetNumberOfGroup());
            //Console.WriteLine(stud3.GetNumberOfGroup());
            //Console.WriteLine(stud4.GetNumberOfGroup());
            //Console.WriteLine(stud5.GetNumberOfGroup());
            //Console.WriteLine(stud6.GetNumberOfGroup());
        }
        public static BitArray GetRandomGrade()
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
