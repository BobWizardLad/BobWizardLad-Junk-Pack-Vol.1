using Godot;
using System;

public partial class AttackComponent : Node2D {	
	[Export]
	private int attack_value;
	
	public override void _Ready() {
		attack_value = 20;
	}

	
	public override void _Process(double delta) {
	}

	public void attack(Node2D target) {
		Godot.Collections.Array<Godot.Node> target_info = target.GetChildren();
		foreach(Godot.Node child in target_info) {
			if(child.Name == "HealthComponent") {
				child.Mod_Hitpoints(-1*attack_value);
			}
		}
	}
}
