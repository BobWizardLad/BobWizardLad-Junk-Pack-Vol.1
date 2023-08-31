using Godot;
using System;

public partial class Unit : Node2D
{
	private NodePath HealthLabelPath;
	private Label HealthLabel;
	private NodePath HealthPath;
	private HealthComponent Health;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		HealthLabelPath = new NodePath("Label");
		HealthLabel = (Label)GetNodeOrNull(HealthLabelPath);
		HealthPath = new NodePath("Label");
		Health = (HealthComponent)GetNodeOrNull(HealthPath);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		Console.Out.WriteLine(Health.Get_Hitpoints().ToString());
		HealthLabel.Text = Health.Get_Hitpoints().ToString();
	}
}
