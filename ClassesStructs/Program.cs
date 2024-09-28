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

            StructAndClass.ChangeNameStruct(ref seperateStruct);
            SeperateClass.ChangeNameClass(seperateClass);

            Console.WriteLine("current name in case of class: " + seperateClass.Name);
            Console.WriteLine("current name in case of structs: " + seperateStruct.Name);
        }
    }
}
