using Godot;
using System;

public static class GameState : Object {
    private static Node[] GameUnits = new Node[6];

    // Loads a new team of units into the player's array.
    // Requires a complete array of units to load.
    // Will only take the first three units in an oversized list.
    public static void loadTeam(Node[] Units) {
        for(int i = 0; i < 6; i++) {
            GameUnits[i] = Units[i];
        }
    }

    public static Node[] GetGameUnits() {
        return GameUnits;
    }
}
