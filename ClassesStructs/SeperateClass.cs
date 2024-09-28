using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructs
{
    internal class SeperateClass
    {
        public string Name { get; set; }
        public SeperateClass()
        {
           
        }

        public static void ChangeNameClass(SeperateClass seperateClass)
        {
            seperateClass.Name = "Changed Class";
        }
    }
}
