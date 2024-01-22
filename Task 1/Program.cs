namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 //

            Console.WriteLine("Enter a low Number: ");
            int lowNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a High Number: ");
            int highNumber = Convert.ToInt32(Console.ReadLine());

            int subtraction = highNumber - lowNumber;
            Console.WriteLine("The Subtraction of " + highNumber + " and " + lowNumber + " is: " + subtraction);
        }
    }
}
