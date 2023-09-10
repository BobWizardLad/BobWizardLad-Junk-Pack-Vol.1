using Godot;
using System;

public partial class Unit : Node2D
{
	private Label HealthLabel;

	[Export]
	protected int hitpoints = 100;
	[Export]
	private const int MAX_HITPOINTS = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		HealthLabel = (Label)GetNodeOrNull(new NodePath("Label"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		HealthLabel.Text = Get_Hitpoints().ToString();
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

	// Oof [THIS IS A TEST CODE]
	public void _OofButton() {
		Mod_Hitpoints(-15);
	}
}