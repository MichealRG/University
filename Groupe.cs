using System;
using System.Collections.Generic;
using System.Text;

namespace Zzadanie2
{
    class Groupe
    {
        public int Number { get; set; }
        public List<Subject> Subjects { get; set; }
        public Groupe(int num, List<Subject> list)
        {
            Number = num;
            Subjects = new List<Subject>();
            foreach (var item in list)
            {
                Subjects.Add(item);
            }
            
        }
    }
}
