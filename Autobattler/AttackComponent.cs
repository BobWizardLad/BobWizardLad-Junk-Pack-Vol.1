using Godot;
using System;
using static CustomMathFunc;

public partial class AttackComponent : Node2D {	
	[Export]
	private int attack_value;
	private RayCast2D attack_cast;
	
	public override void _Ready() {
		attack_value = 20;

		attack_cast = (RayCast2D)GetNodeOrNull(new NodePath("RayCast2D"));
	}
	
	public override void _Process(double delta) {
		attack_cast.TargetPosition = DegreesToUnitVector(Rotation) * 50;
	}

	public void attack(Unit target) {
		target.GetHealthComponent().Mod_Hitpoints(-1*attack_value);
	}
}
