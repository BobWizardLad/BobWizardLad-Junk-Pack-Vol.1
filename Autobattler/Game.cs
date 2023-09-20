using Godot;
using System;
using System.Text.RegularExpressions;
// Static call to GameState ensures that GameState.cs is 
// a static place in memory for shared data
using static GameState;

public partial class Game : Node2D
{
	private Node[] unitNodes = new Node[6];
	private int x;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		// For the sake of progress, but PLEASE FIX ME THIS SUCKS
		x = 0;
		Godot.Collections.Array<Godot.Node> children = GetChildren();

		// Iterate through the children and sort into list
        foreach (Node child in children) {
			if (child is Unit) {
				unitNodes[x] = child;
				x = x + 1;
			}
		}
		GameState.loadTeam(unitNodes);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		
	}
}
