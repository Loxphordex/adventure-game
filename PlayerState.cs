using System;
using System.IO;

public class PlayerState {

    private void InitState(string name) {
        File.WriteAllText(@".\PlayerState.txt", name);
    }
}