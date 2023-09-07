using Godot;
using System;

public partial class Unit : Node2D
{
	private Label HealthLabel;
	private HealthComponent Health;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		HealthLabel = (Label)GetNodeOrNull(new NodePath("Label"));
		Health = (HealthComponent)GetNodeOrNull(new NodePath("HealthComponent"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		HealthLabel.Text = Health.Get_Hitpoints().ToString();
	}

	public HealthComponent GetHealthComponent() {
		return Health;
	}

	// Oof [THIS IS A TEST CODE]
	public void _OofButton() {
		Health.Mod_Hitpoints(-15);
	}
}
