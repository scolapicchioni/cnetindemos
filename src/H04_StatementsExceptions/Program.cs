using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ifStatement();
            switchStatement();
            forStatement();
            whileStatement();
            doWhileStatement();
            forEachStatement();
            exceptions();
        }

        private static void exceptions()
        {
            //when a statement throws an exception, we have to catch it,
            //otherwise it will automatically go to our caller
            //which will have to catch it, otherwise it will go to its caller and so on,
            //until it reaches the user
            //int.Parse("hi!"); //uncomment this line to have stop this application

             //we can catch an exception in a try/ catch block
             try{
                 int.Parse("hi");
             }catch{
                 System.Console.WriteLine("Problem handled, we can continue");
             }

             //if we want info on the problem, we have to catch it and give it a name
             try{
                 int.Parse("hi");
             }catch(Exception error){
                 System.Console.WriteLine($"Problem {error.Message} handled, we can continue");
             }

             //we can contain our "happy path" in the try block,
             //because we're sure to continue only if each previous statement succeded
             try{
                 System.Console.Write("Please write your age: ");
                 int age = int.Parse(Console.ReadLine());
                 //if we're here, everything went fine
                 if(age>18)
                    System.Console.WriteLine("Welcome Master Jedi");
                else
                    System.Console.WriteLine("Welcome Young Padawan");
             } catch(Exception ex){ //this is the most generic handler of all, meaning we could handle anything
                 System.Console.WriteLine($"Something went wrong... {ex.Message}");
             }

             //we can also handle different problems in different ways,
             //as long as we know what tye of problems we could face
             try{
                 System.Console.Write("Please write your age: ");
                 int age = int.Parse(Console.ReadLine());
                 //if we're here, everything went fine
                 if(age>18)
                    System.Console.WriteLine("Welcome Master Jedi");
                else
                    System.Console.WriteLine("Welcome Young Padawan");
             } catch(FormatException ex){ //we only handle a specific problem of type FormatException here
                 System.Console.WriteLine($"You did not write a number: {ex.Message}");
             } catch(OverflowException ex){ //here we handle OverflowExceptions
                 System.Console.WriteLine($"Your number was out of range: {ex.Message}");
             }catch(Exception ex){
                 System.Console.WriteLine($"I don't know what happened here, but that's ok: {ex.Message}");
             }

             //we can only catch from most specific to more generic and not the other way around
             try{
                 System.Console.Write("Please write your age: ");
                 int age = int.Parse(Console.ReadLine());
                 //if we're here, everything went fine
                 if(age>18)
                    System.Console.WriteLine("Welcome Master Jedi");
                else
                    System.Console.WriteLine("Welcome Young Padawan");
             }catch(Exception ex){
                 System.Console.WriteLine($"I don't know what happened here, but that's ok: {ex.Message}");
            } //catch(FormatException ex){ //this does not compile
            //      System.Console.WriteLine($"You did not write a number: {ex.Message}");
            //  } catch(OverflowException ex){ //wrong order, we already handled this exception in the Exception base type
            //      System.Console.WriteLine($"Your number was out of range: {ex.Message}");
            //  }

            //we can also throw exceptions in order to signal that something went wrong
            //throw new FormatException("This has to be handled by our caller");
        }

        private static void forEachStatement()
        {
            //every "Enumerable" can be scrolled with a foreach loop
            //arrays, lists, strings, collections and so on
            //the foreach fills a variable with each item of our lists
            int[] listOfInts = new int[10]{10,20,30,40,50,60,70,80,90,100};
            foreach (int item in listOfInts) //item is of type int because the list contains int
            {
                System.Console.WriteLine(item);
            }

            string listOfChar = "Hi how are you";
            foreach (char item in listOfChar) //item is of type string because a string is a list that contains char
            {
                System.Console.WriteLine(item);
            }


        }

        private static void doWhileStatement()
        {
            //the do while block checks the condition at the bottom
            //meaning that at least it gets executed once
            string exit;
            do{
                Console.WriteLine("Write X to exit:");
                exit = Console.ReadLine();
            } while(exit!="X");
        }

        private static void whileStatement()
        {
            int i = 0;
            //the while block is like the if, but once at the end it goes back to the top to check the condition again
            while(i<10) //condition has to be enclosed in parenthesis
            { //the block needs to be enclosed in curly brackets only if it contains more than one line
                System.Console.WriteLine(i); //0 to 9
                System.Console.WriteLine("This statement gets repeated as well");
            }

            i = 10;
            //if the condition is already false, the loop does not get executed at all
            while(i<10)
                System.Console.WriteLine("This block will never be executed");

            //while(true) 
            //  System.Console.WriteLine("infinite loop");
        }

        private static void forStatement()
        {
            //loop with 3 section separated by semicolons
            //for(statement executed at the beginning; test evaluated before every iteration; statement executed after every operation) {}
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i); //0 to 9
            }
            //i does not exists, because C# has block scope for variables

            //we could use a for like this if we wanted
            //for(open a file; if the file is not finished; read the next line){}

            //for(;;) //infinite loop    
        }

        private static void switchStatement()
        {
            //check one variable against multiple values with the switch statement
            System.Console.Write("1 for Monday, 2 for Tuesday, 3 for Wednesday, yadayadayada, 7 for Suday: " );
            string input = Console.ReadLine();
            switch(input){
                case "1":
                    System.Console.WriteLine("YOU LIKE MONDAYS?!?! YOU CRAZY?!?!");
                    break;// we may not forget the break is the case is not empty
                case "2":
                case "3"://2 and 3 will fall through to 4
                case "4":
                    System.Console.WriteLine("normal weekday");
                    break;
                case "5":
                    System.Console.WriteLine("TGIF");
                    break;
                case "6":
                case "7":
                    System.Console.WriteLine("WEEEEEEEEEKEEEEEEEEND");
                    break;
                default: //not mandatory
                    System.Console.WriteLine("sorry, what?");
                    break;// break mandatory even in the default
            }
        }

        private static void ifStatement()
        {
            //decision making

            System.Console.WriteLine("Please Enter your age");
            int age = int.Parse(Console.ReadLine());
            //we hope everything is fine (more on handling exceptions later)
            if(age>=18) //condition has to be enclosed in parenthesis
            { //the block needs to be enclosed in curly brackets only if it contains more than one line
                System.Console.WriteLine("You can continue.");
                System.Console.WriteLine("But I'm watching you.");
            }
            else //else is not mandatory 
                System.Console.WriteLine("You're too young to be here"); //not using curly brackets but it's ok because there's only one line
        }
    }
}
