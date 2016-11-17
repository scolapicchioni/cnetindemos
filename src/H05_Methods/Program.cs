using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //we define our methods with a signature
            //then we have to invoke the method in order to execute it
            //when the method is over, we continue where we left
            System.Console.WriteLine("Hi from Main");
            Method01();
            System.Console.WriteLine("Hi from Main");

            //we can pass arguments to method that accept parameters.
            //the types must mach
            int argument1 = 10;
            MethodWithOneParameter(argument1);

            //traditionally, we have to pass the arguments in the same order as they are defined
            int argument2 = 20; 
            string argument3 = "hi";
            MethodWithThreeParameters(argument1, argument2, argument3);

            //but we could also specify the name of the parameters
            MethodWithThreeParameters(parameter3: argument3, parameter2: argument1, parameter1: argument2);

            //this goes well in conjunction with optional parameters (with default values)
            MethodWithOptionalParameters(parameter3: "Something completely different"); //parameter1 and parameter2 get their value from the definition of the method

            //we can also return a value from a method
            string returnValue = SayHi(5);
            System.Console.WriteLine(returnValue);

            //we can pass a variable length list of parameters if they have been defined with the params keyword
            long result = Sum(10,20,30,40,50);
            System.Console.WriteLine(result);

             //to pass by reference, we use the ref keyword
             int originalValueTypeArgument = 10; //we are responsible to initialize it
             changeOriginalNumber(ref originalValueTypeArgument);
             System.Console.WriteLine(originalValueTypeArgument); //changed to 110

             //to use an argument as an output parameter, we use the out keyword
             //we are not responsible of initializing the argument, the method is
             int outArgument;
             writeOnOutputParameter(out outArgument);
             System.Console.WriteLine(outArgument); //initialized to 100 by the method

        }

        //method definition
        static void Method01(){
            System.Console.WriteLine("Hi from Method01");
        }

        //the signature can specify zero or more parameters
        static void MethodWithOneParameter(int parameter1){
            System.Console.WriteLine($"parameter1 == {parameter1}");
        }

        static void MethodWithThreeParameters(int parameter1, int parameter2, string parameter3){
            System.Console.WriteLine($"parameter1 == {parameter1}, parameter2 == {parameter2}, parameter3 == {parameter3}");
        }

        static void MethodWithOptionalParameters(int parameter1 = 100, int parameter2 = 50, string parameter3 = ""){
            System.Console.WriteLine($"parameter1 == {parameter1}, parameter2 == {parameter2}, parameter3 == {parameter3}");
        }

        static string SayHi(int exclamationMarks){ //our return type is string
            string result = "Hi";
            if(exclamationMarks>10){
                result += " (chill out man...)";
            }
            else{
                for (int i = 0; i < exclamationMarks; i++)
                {
                    result += "!";
                }
            }
            return result; //we need to return a string because the signature promised it
        }

        //the params keyword gathers all the parameters into one array
        //we can call this method like this
        //Sum(10,20,30,40,5);
        static long Sum( params int[] listOfNumbers){
            long total = 0;
            foreach (int item in listOfNumbers)
            {
                total += item;
            }
            return total;
        }

        //to pass a parameter by reference, we defined it and pass it with the ref keyword
        static void changeOriginalNumber(ref int referenceToValueType){
            referenceToValueType += 100; //the original int argument has been changed
        } 

        static void writeOnOutputParameter(out int referenceToValueType){
            //referenceToValueType += 100; //we cannot read the original int argument
            //we are responsible to initialize the parameter
            referenceToValueType = 100; //if we dont' do it, it won't compile
            //the original argument has been initialized
        }
    }
}
