using System;
using System.IO;

namespace adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                
                // Object setup
                var mainMenu = new MainMenu();
                var playerState = new PlayerState();

                mainMenu.Header();

                var quitter = Console.ReadLine();
                if (quitter.ToLower() == "quit") {
                    return;
                }
            }
        }
    }
}
