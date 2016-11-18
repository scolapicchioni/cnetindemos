namespace Constructors
{
    public class ClassWithOverloadedConstructors{
        public ClassWithOverloadedConstructors()
        {
            System.Console.WriteLine("This is a default constructor we wrote");
        }
        public ClassWithOverloadedConstructors(int someValue)
        {
            System.Console.WriteLine("This is a constructor with an int that we wrote");
        }
    }
}