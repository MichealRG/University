using System;
using System.Collections.Generic;
using System.Text;

namespace Zzadanie2
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public List<Subject> LeadingSubject { get; set; } = new List<Subject>();
        public Teacher(string fName, string lName, string title)
        {
            FirstName = fName;
            LastName = lName;
            Title = title;
        }
        public void SetLeadingSubject(Subject subject)
        {
            LeadingSubject.Add(subject);
        }
        public void SetLeadingSubjects(List<Subject> subjects)
        {
            LeadingSubject.AddRange(subjects);
        }
        public (string,string,string) GetDefaultInfo()
        {
            return (FirstName, LastName, Title);
        }
        public List<Subject> GetSubjects()
        {
            return LeadingSubject;
        }
    }
}
