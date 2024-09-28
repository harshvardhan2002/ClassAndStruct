using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructs
{
    internal struct SeperateStruct
    {
        public string Name {  get; set; }

        //No constructor in structs
    }
    internal static class StructAndClass
    {
        internal static void ChangeNameStruct(ref SeperateStruct seperateStruct)
        {
            seperateStruct.Name = "Changed Struct";
        }
    }
}
