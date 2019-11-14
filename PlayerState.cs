using System;
using System.IO;
using System.Collections.Generic;

public class PlayerState {

    List<string> inventory = new List<string>();

    private void InitState(string name) {
        File.WriteAllText(@".\PlayerState.txt", name);
    }
}