using System;
using System.IO;
using System.Collections.Generic;

public class PlayerState {

    List<string> inventory = new List<string>();

    public void AddItem(string item) {
        inventory.Add(item);
        Console.WriteLine("");
        Console.WriteLine($"~ Added \"{item}\" to your inventory ~");
        Console.WriteLine("");
    }

    public void OpenInventory() {
        Console.WriteLine("");
        Console.WriteLine("Inventory:");
        foreach (string item in inventory) {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
    }

    private void InitState(string name) {
        File.WriteAllText(@".\PlayerState.txt", name);
    }
}