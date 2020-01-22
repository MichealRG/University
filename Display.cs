using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Zzadanie2
{
    class Display
    {
        public void DisplayData(object toDisplay)
        {
            switch (toDisplay)
            {
                case string t:
                    Console.WriteLine(t);
                    break;
                case int t:
                    Console.WriteLine(t);
                    break;
                case List<Subject> t:
                    foreach (var item in t)
                    {
                        Console.WriteLine(item.Name);
                    }
                    break;
                case BitArray t:
                    for (int i = 0; i < t.Length; i++)
                    {
                        Console.WriteLine("{0}: {1}",i,t[i]);
                    }
                    break;
                case var t: //XXX
                    Console.WriteLine(t);
                    break;
            }
        }
    }
}
