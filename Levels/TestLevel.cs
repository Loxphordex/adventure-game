using System;

public class TestLevel {
    public void FirstTestLevel(PlayerState player) {
        var playerInput = new PlayerInput();

        Console.WriteLine("");
        Console.WriteLine("This is the first instance of testing a paragraph. I am not sure how this will work.");
        Console.WriteLine("");

        Console.WriteLine("You're in the first instance of a hypothetical room, performing an unassuming hypothetical task.");
        Console.WriteLine("Unaware of the amazing adventure that awaits you, you look at your desk and notice two objects.");
        Console.WriteLine("One object is a book, the other is a pair of glasses. Which do you pick up?");

        string BookOrGlasses = "";
        
        while (!BookOrGlasses.Contains("book") || !BookOrGlasses.Contains("glasses")) {
            BookOrGlasses = playerInput.GetInput(player);

            if (BookOrGlasses.Contains("book")) {
                Console.WriteLine("You picked up the book before picking up the glasses.");
                Console.WriteLine("How do you plan on reading the book if you need glasses?");
                Console.WriteLine("You should just quit this game now.");
                player.AddItem("Book");
                break;
            }
            if (BookOrGlasses.Contains("glasses")) {
                Console.WriteLine("You pick up the glasses...");
                player.AddItem("Glasses");
                break;
            }

            else if (BookOrGlasses != "") {
                Console.WriteLine("Should you pick up the book, or the glasses?");
            }
        }


        Console.WriteLine("Now that you've made your choice, you look around the room.");
        Console.WriteLine("You sit inside a private study, surrounded by books, maps, a desk, a rug,");
        Console.WriteLine("and an empty chair.");
        Console.WriteLine("");
        Console.WriteLine("What would you like to do?");

        string StudyMoves = "";

        while (!StudyMoves.Contains("leave")) {
            StudyMoves = playerInput.GetInput(player);

            if (StudyMoves.Contains("books")) {
                Console.WriteLine("The shelves around you climb far beyond your reach.");
                Console.WriteLine("Your collections includes hundreds of volumes of fiction,");
                Console.WriteLine("history, science and mathematics.");
            }

            if (StudyMoves.Contains("maps") || StudyMoves.Contains("map")) {
                Console.WriteLine("In the corner of your study sits a collection of loosely rolled maps.");
                Console.WriteLine("They remind you of your journies as a young man.");
            }

            if (StudyMoves.Contains("desk")) {
                Console.WriteLine("The desk is covered in loose papers and small personal objects.");
                Console.WriteLine("Its lamp supplies the only light in the room, with the help of");
                Console.WriteLine("a few candles on the wall.");
            }

            else if (StudyMoves != "" && !StudyMoves.Contains("leave")) {
                Console.WriteLine("There is not much to see here...");
            }
        }

        Console.WriteLine("You open the creeky door and peer down the dark hall.");
        Console.WriteLine("You can't see anything beyond a few feet.");

        string HallwayInput = "";
        while (!HallwayInput.Contains("light")) {
            
        }
        
    }
}