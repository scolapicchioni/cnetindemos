using System;
using Constructors;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //a class without constructors gets a default constructor from the compiler
            ClassWithoutConstructors c1 = new ClassWithoutConstructors(); //we can invoke this method even if it's not in our source code
            
            //we can redefine the default constructor if we want
            ClassWithDefaultConstructor c2 = new ClassWithDefaultConstructor(); //prints to the console

            //we can overload the constructors if necessary
            ClassWithOverloadedConstructors c3 = new  ClassWithOverloadedConstructors();// first constructor (default we wrote)
            ClassWithOverloadedConstructors c4 = new  ClassWithOverloadedConstructors(10);// second constructor (with an int, that we wrote)
            
            ClassWithoutDefaultConstructor c5 = new ClassWithoutDefaultConstructor(5); //we cannot make any instance unless we pass an int, because we don't have the default constructor

        }
    }
}
