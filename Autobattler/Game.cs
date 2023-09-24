using Godot;
using System;
using System.Text.RegularExpressions;
// Static call to GameState ensures that GameState.cs is 
// a static place in memory for shared data
using static GameState;

public partial class Game : Node2D
{
	private Node[] unitNodes = new Node[3];
	private int x;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		// For the sake of progress, but PLEASE FIX ME THIS SUCKS
		x = 0;
		Godot.Collections.Array<Godot.Node> children = GetChildren();

		// Load all units to GameState
        foreach (Unit child in children) {
			if (child.GetTeam() == 1) {
				unitNodes[x] = child;
				x = x + 1;
			}
		}
		GameState.LoadRedTeam(unitNodes);
		x = 0;
		unitNodes = new Node[3];
		foreach (Unit child in children) {
			if (child.GetTeam() == 0) {
				unitNodes[x] = child;
				x = x + 1;
			}
		}
		GameState.LoadBlueTeam(unitNodes);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		
	}
}
