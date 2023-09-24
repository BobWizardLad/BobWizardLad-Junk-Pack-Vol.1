using Godot;
using System;
using static GameState;

[GlobalClass]
public partial class Unit : Node2D {
	// Node/Resource references
	private Label healthLabel;
	private Timer AtkTimer;
	
	// Const
	private const int MAX_HITPOINTS = 100;
	enum Team {Blue, Red}

	// Mutables
	[Export]
	private int hitpoints = 100;
	[Export]
	private Team team = Team.Blue;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		// Connect resources and nodes
		healthLabel = (Label)GetNodeOrNull(new NodePath("Label"));
		AtkTimer = (Timer)GetNodeOrNull(new NodePath("AtkTimer"));

		// Random seed from datetime string hash.
		GD.Seed(Godot.Time.GetDateStringFromSystem().Hash());
		GD.Randomize();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		// Screen Calculation
		healthLabel.Text = GetHitpoints().ToString();

		// Unit Death
		if(hitpoints <= 0) {
			QueueFree();
		}
	}

	// -- ATTACK --

	public void OnAtkTimeout() {
		// Unit Actions
		Unit target = null;

		// randomly pick target not on same team
		if(team == Team.Blue) {
			target = GameState.GetRedTeam((int)GD.Randi() % 3);
		} else if(team == Team.Red) {
			target = GameState.GetBlueTeam((int)GD.Randi() % 3);
		}

		// make attack action
		Attack(target, 15);
	}

	// Basic attack calculation
	public void Attack(Unit target, int damage) {
		target.Mod_Hitpoints(-damage);
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
	public int GetHitpoints() {
		return hitpoints;
	}

	public int GetTeam() {
		return (int)team;
	}

}