namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string teamName = "49ers";
            int score49Ers = 30;
            char a = 'a';
            bool ball = true;
            double winningMargin = 21;
            decimal timeToFirstTD = 3.1m;

            Console.WriteLine($"The following statement may be {ball}\nThe {teamName} will win their first playoff game by {winningMargin}, with {a} score of {score49Ers} and will score their first touchdown {timeToFirstTD} seconds in to the game");
            
        }

    }
}

