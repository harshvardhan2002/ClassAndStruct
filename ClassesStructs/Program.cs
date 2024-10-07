namespace ClassesStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeperateClass seperateClass = new SeperateClass();
            SeperateStruct seperateStruct = new SeperateStruct();

            seperateStruct.Name = "Actual Struct.";
            seperateClass.Name = "Actual Class";

            Console.WriteLine("actual name in case of class: "+seperateClass.Name);
            Console.WriteLine("actual name in case of structs: "+seperateStruct.Name);

            StructAndClass.ChangeNameStruct(ref seperateStruct); // passed it by reference
            SeperateClass.ChangeNameClass(seperateClass);
//The call to SeperateClass.ChangeNameClass(seperateClass) also changes the name in the class to "Changed Class" without needing ref because it’s a reference type.
            Console.WriteLine("current name in case of class: " + seperateClass.Name);
            Console.WriteLine("current name in case of structs: " + seperateStruct.Name);
        }
    }
}
