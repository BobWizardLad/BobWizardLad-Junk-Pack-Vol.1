using Godot;
using System;
using static GameState;

[GlobalClass]
public partial class Unit : Node2D {
	// Node/Resource references
	private Label healthLabel;
	
	// Const
	private const int MAX_HITPOINTS = 100;

	// Mutables
	[Export]
	private int hitpoints = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		// Connect resources and nodes
		healthLabel = (Label)GetNodeOrNull(new NodePath("Label"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		Get_Hitpoints().ToString();
	}

	// -- HEALTH --

	// Set hitpoints to value, always bounded by MAX_HITPOINTS and zero
	public void Set_Hitpoints(int value) {
		if(value > MAX_HITPOINTS) {
			hitpoints = MAX_HITPOINTS;
		} else if(value < 0) {
			hitpoints = 0;
		} else {
			hitpoints = value;
		}
	}

	// Modify HP by value, always bounded by MAX_HITPOINTS and zero
	public int Mod_Hitpoints(int value) {
		if(value + hitpoints > MAX_HITPOINTS) {
			hitpoints = MAX_HITPOINTS;
		} else if(value + hitpoints < 0) {
			hitpoints = 0;
		} else {
			hitpoints += value;
		}
		return hitpoints;
	}

	// -- GETTERS --

	// Getter for hitpoints
	public int Get_Hitpoints() {
		return hitpoints;
	}

}