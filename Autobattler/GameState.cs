using Godot;
using System;

public partial class GameState : Resource {
    private Node2D[] PlayerTeam = new Node2D[3];
    private Node2D[] EnemyTeam = new Node2D[3];

    // Loads a new team of units into the player's array.
    // Requires a complete array of units to load.
    // Will only take the first three units in an oversized list.
    public void loadTeam(Node2D[] Units) {
        for(int i = 0; i < 3; i++) {
            PlayerTeam[i] = Units[i];
        }
    }

    public Node2D[] GetPlayerTeam() {
        return PlayerTeam;
    }

    public Node2D[] GetEnemyTeam() {
        return EnemyTeam;
    }
}
