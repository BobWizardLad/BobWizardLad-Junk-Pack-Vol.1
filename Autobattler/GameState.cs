using Godot;
using System;

public static class GameState : Object {
    private static Node[] BlueTeam = new Node[3];
    private static Node[] RedTeam = new Node[3];

    // Loads a new team of units into a team's array.
    // Requires a complete array of units to load.
    // Will only take the first three units in an oversized list.
    public static void LoadRedTeam(Node[] Units) {
        for(int i = 0; i < 3; i++) {
            RedTeam[i] = Units[i];
        }
        GD.Print(RedTeam);
    }
    public static void LoadBlueTeam(Node[] Units) {
        for(int i = 0; i < 3; i++) {
            BlueTeam[i] = Units[i];
        }
        GD.Print(BlueTeam);
    }

    public static Unit GetRedTeam(int index) {
        return (Unit)RedTeam[index];
    }
    public static Unit GetBlueTeam(int index) {
        return (Unit)BlueTeam[index];
    }
}
