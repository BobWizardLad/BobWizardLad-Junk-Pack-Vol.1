using Godot;
using System;
using System.Runtime.ExceptionServices;

public partial class HealthComponent : Node
{
	[Export]
	protected int hitpoints = 100;
	[Export]
	private const int MAX_HITPOINTS = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
	}

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

	// Getter for hitpoints
	public int Get_Hitpoints() {
		return hitpoints;
	}
}
