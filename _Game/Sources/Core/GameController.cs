using Godot;
using Tabasco;

public partial class GameController : Node
{
	private FixedStepSystems _fixedStepSystems;

	public override void _Ready()
	{
		_fixedStepSystems = new FixedStepSystems();
		_fixedStepSystems.Initialize();
	}

	public override void _Process(double delta)
	{
	}

	public override void _PhysicsProcess( double delta )
	{
		_fixedStepSystems.Execute();
		_fixedStepSystems.Cleanup();
	}
}
