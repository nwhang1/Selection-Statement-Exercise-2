using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject? Math, Science, History, English, or Gym?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is important for all parts of our lives, good choice!");
                    break;
                case "science":
                    Console.WriteLine("Science breathes innovation into our lives, great choice!");
                    break;
                case "history":
                    Console.WriteLine("Those who do not study history are doomed to repeat it, good choice!");
                    break;
                case "english":
                    Console.WriteLine("Interesting choice, I'll refrain from commenting further");
                    break;
                case "gym":
                    Console.WriteLine("That's not a subject and you know it...");
                    break;

            }
        }
    }
}