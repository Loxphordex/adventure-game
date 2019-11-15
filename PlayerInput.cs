using System;

public class PlayerInput {
    public string GetInput(PlayerState player) {
        while(true) {
            // Get input from console
            Console.WriteLine("");
            var input = Console.ReadLine().ToLower();
            Console.WriteLine("");

            // Quit Game
            if (input == "quit" 
                || input == "exit" 
                || input == "quit game" 
                || input == "exit game") {
                    QuitGame();
                }

            else if (input.Contains("inventory")) {
                player.OpenInventory();
            }

            else {
                return input;
            }

        }
    }

    private void QuitGame() {
        return;
    }
}