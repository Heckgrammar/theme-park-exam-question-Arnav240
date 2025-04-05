namespace ThemeParkCalculationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A theme park charges £15 per person for a daily ticket. If there are six or more people in a group, the group is given a £5 discount.
               Write a C# program to calculate the total charge for a group of people visiting the theme park.
               The program must:
                • get the user to enter the number of people in a group
                • calculate the total charge by:
                    ○ charging £15 per person
                    ○ reducing the total charge by £5 if there are six or more people
                • output the total charge.
            You should use meaningful variable name(s) inyour answer.
            */
            // Write your program and test it with the following test data
            // 1: 4 people
            // 2: 10 people
            // 3: 6 people
            // Commit your changes and add screnshot evidence of your program running to the Readme

            Console.WriteLine("Welcome to the theme psrk, how many people are visiting");
            int people = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int cost = 0;

            for (int i = 1; i != people + 1; i++) 
            {
                cost += 15;
            }

            if (people > 5) 
            {
                cost -= 5;
            }
            Console.WriteLine($"There are {people} people and the total cost is £{cost}.");
        }
    }
}
