using System;

namespace H03_Variables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            valueTypes();
            referenceTypes();
            enums();
            structs();

            Console.ReadLine();
        }

        private static void structs()
        {
            //structs are value types
            //int, double, short, bool and so on are structs

            //we can define our own value types
            //(you can find the definition in the file Bank.cs)

            Bank b1 = new Bank();
            b1.Name = "SimoBank";
            b1.Address = "Utrecht";

            //copied by value
            Bank b2 = b1;
            //if we change b1, b2 is not changed
            b1.Name = "MarioBank";
            System.Console.WriteLine($"b1.Name == {b1.Name}; b2.Name == {b2.Name}"); //different

            //parameters passed by value
            System.Console.WriteLine($"b1.Name == {b1.Name}");
            changeUserDefinedValueType(b1);
            System.Console.WriteLine($"b1.Name == {b1.Name}"); //b1.Name has not been reached
        }

        private static void enums()
        {
            //enums are handy when we have a list of values and we want to pick one from it
            //enums are types (we can declare variables, properties, parameters, return values and so on)
            ConsoleColor oldColor = Console.ForegroundColor;
            //they are value types: 
            //we copied the value of ForegroundColor into oldColor but if we change one of the two, the other remains unchanged
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("I'M SEEING RED!");
            System.Console.WriteLine(oldColor); //still gray
            //we can only assign values picked up from the list, not simple strings or numbers
            //Console.ForegroundColor = "Red"; //does not compile
            //Console.ForegroundColor = 255; //does not compile
            Console.ForegroundColor = ConsoleColor.Cyan; //compiles
            Console.ForegroundColor = oldColor;

            //we can also define our own enums and use them
            //(you can find the definition in the file Enumerations.cs)
            ItalianDays favoriteDay = ItalianDays.Sabato;
            System.Console.WriteLine(favoriteDay); //Sabato
        }


        private static void referenceTypes(){
            //p1 is the reference, new Person() is the object
            Person p1 = new Person() {Id = 1, Name = "Simona", Surname = "Colapicchioni"};

            //copy:
            //p2 is just a reference, it is now pointing to the same and only object pointed by p1
            Person p2 = p1;
            //if we change something on p1, p2 gets changed as well and vice versa
            p1.Name = "Mario";
            System.Console.WriteLine($"p1.Name == {p1.Name}; p2.Name == {p2.Name}"); //both Mario

            //comparison
            //the reference is what gets compared, not the object
            p1 = new Person() {Id = 1, Name = "Simona", Surname = "Colapicchioni"};
            System.Console.WriteLine(p1==p2); //false (different address)
            p1 = p2;
            System.Console.WriteLine(p1==p2); //true (same address)

            //parameters
            System.Console.WriteLine($"p1.Name == {p1.Name}");
            changeReferenceType(p1);
            System.Console.WriteLine($"p1.Name == {p1.Name}"); //p1.Name has been reached and changed
        }
        private static void strings()
        {
            string s1 = "hi"; //it's a reference type (class) but we treat it as a value type
            System.Console.WriteLine(s1);
            //we copy the values
            string s2 = s1;
            System.Console.WriteLine("s1=={s1}; s2=={s2}");
            s1 = ":)";
            System.Console.WriteLine("s1=={s1}; s2=={s2}"); //s2 is still "hi";

            //if we compare strings, they get their values compared instead of their addresses
            s1 = "hi";
            System.Console.WriteLine(s1==s2); //true

            //we pass the value
            System.Console.WriteLine($"s1 == {s1}");
            changeString(s1);
            System.Console.WriteLine($"s1 == {s1}"); //s1 has not been changed
        }

        private static void valueTypes()
        {
            int i; //declaration
            i = 10; //initialization
            Console.WriteLine(i); //10

            bool b = false;  //declaration and initialization on one line
            System.Console.WriteLine(b); //false

            //value types contain their values
            //this affects copies, comparisons,  passing of parameters and so on

            //1) copy by value
            decimal d1 = 10;
            decimal d2 = 20;
            System.Console.WriteLine($"d1 == {d1} ; d2=={d2}");
            d2 = d1;
            System.Console.WriteLine($"d1 == {d1} ; d2=={d2}"); //both 10
            d1 = 30;
            System.Console.WriteLine($"d1 == {d1} ; d2=={d2}"); // d1 is 30, d2 is still 10

            //2) comparison is by value
            d1 = 10;
            d2 = 10;
            System.Console.WriteLine(d1==d2); //true

            //3) passing of parameters is by value
            System.Console.WriteLine($"d1 == {d1}");
            changeValueType(d1);
            System.Console.WriteLine($"d1 == {d1}"); //d1 has not been touched
        }

        private static void changeValueType(decimal parameter){
            System.Console.WriteLine($"parameter == {parameter}");
            parameter++;
            System.Console.WriteLine($"parameter == {parameter}");
        }

        private static void changeString(string parameter){
            System.Console.WriteLine($"parameter == {parameter}");
            parameter += " modified by the changeString";
            System.Console.WriteLine($"parameter == {parameter}");
        }

        private static void changeReferenceType(Person parameter){
            System.Console.WriteLine($"parameter.Name == {parameter.Name}");
            parameter.Name += " modified by the changeReferenceType";
            System.Console.WriteLine($"parameter.Name == {parameter.Name}");
        }

        private static void changeUserDefinedValueType(Bank parameter){
            System.Console.WriteLine($"parameter.Name == {parameter.Name}");
            parameter.Name += " modified by the changeReferenceType";
            System.Console.WriteLine($"parameter.Name == {parameter.Name}");
        }
    }
}
