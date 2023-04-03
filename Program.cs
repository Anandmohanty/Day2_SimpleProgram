namespace Day2_SimpleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IfElse ifElse = new IfElse();
            Console.WriteLine("Enter First value");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            ifElse.EqualorNot(valueOne, valueTwo);

            EvenAndOdd s1 = new  EvenAndOdd();
            Console.WriteLine("Enter First value");
            int valueOne1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value");
            int valueTwo2 = Convert.ToInt32(Console.ReadLine());
            s1.EvenOrOdd(valueOne1, valueTwo2);





        }
    }
}