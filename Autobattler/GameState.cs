using Godot;
using System;

public static class GameState : Object {
    private static Node2D[] PlayerTeam = new Node2D[3];
    private static Node2D[] EnemyTeam = new Node2D[3];

    public static int funNum;

    // Loads a new team of units into the player's array.
    // Requires a complete array of units to load.
    // Will only take the first three units in an oversized list.
    public static void loadTeam(Node2D[] Units) {
        for(int i = 0; i < 3; i++) {
            PlayerTeam[i] = Units[i];
        }
    }

    public static Node2D[] GetPlayerTeam() {
        return PlayerTeam;
    }

    public static Node2D[] GetEnemyTeam() {
        return EnemyTeam;
    }
}
