namespace Inversity_News_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter this link into your web browser and minimise this window: ");
            Console.WriteLine("https://www.youtube.com/watch?v=v7UwbJ8n9L0");
            Thread.Sleep(1000);
            Console.WriteLine("Please press enter to continue when you have watched the video");
            Console.ReadLine();

            int points = 0;
            Console.WriteLine("What was the name of the gas which could help the world reach net zero?");
            string answer1 = Console.ReadLine();
            var answer1ToLower = answer1.ToLower();

            if (answer1ToLower == "hydrogen")
            {
                points++;
            }
        }
    }
}
