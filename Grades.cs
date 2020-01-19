using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Zzadanie2
{
    class Grades
    {
        public Dictionary<string, BitArray> SubGrades { get; set; } 
        public Grades()
        {
            SubGrades = new Dictionary<string, BitArray>();
        }
        public void AddGrades(Subject sub, BitArray grades)
        {
            SubGrades.Add(sub.Name, grades);
        }
        
    }
}
