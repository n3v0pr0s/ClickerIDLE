using ClickerIDLE.Entities;

namespace ClickerIDLE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var store = new List<ActionCard>
            {
                new ActionCard("fox", "Fox", 100, 2000),
                new ActionCard("dog", "Dog", 220, 4500),
                new ActionCard("rat", "Rat", 99, 1800),
                new ActionCard("cat", "Cat", 299, 5500),
                new ActionCard("shrek", "Shrek", 400, 6350),
                new ActionCard("farkuad", "Farkuad", 625, 8000)
            };

            var game = new GameProcess(store);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(game));
        }
    }
}