using System;
using System.IO;

namespace adventure
{
    class Program
    {
        static void Main(string[] args)
        {

            // Object setup
            var mainMenu = new MainMenu();
            var playerState = new PlayerState();
            var testLevel = new TestLevel();

            mainMenu.Header();

            var quitter = Console.ReadLine();
            if (quitter.ToLower() == "quit") {
                return;
            }
            testLevel.FirstTestLevel(playerState);
        }
    }
}
