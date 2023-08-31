using Godot;
using System;

public partial class HealthComponent : Node
{
	[Export]
	private int hitpoints = 100;
	[Export]
	private const int MAX_HITPOINTS = 100;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
	}

	public void Set_Hitpoints(int value) {
		if(value > MAX_HITPOINTS) {
			hitpoints = MAX_HITPOINTS;
		}
		else {
			hitpoints = value;
		}
	}

	public int Get_Hitpoints() {
		return hitpoints;
	}
}
