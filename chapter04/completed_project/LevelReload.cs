using Godot;
using System;

public class LevelReload : Timer
{
	public void _on_Timer_timeout()
	{
		GetTree().ReloadCurrentScene();
	}
	
	public void _on_Timer_ready()
	{
		GD.Print("Level Started.");
	}
	
	public override void _PhysicsProcess(float delta)
	{
		GD.Print("Level Timeleft: " + this.GetTimeLeft());
	}
}
