using Godot;
using Zenject;

namespace Game;

[GlobalClass]
public partial class GameController : Node
{
    private Contexts         _contexts;
    private DiContainer      _container;
    private FixedStepSystems _fixedStepSystems;

    public override void _Ready() { }

    [Inject]
    private void Init( Contexts contexts, DiContainer container )
    {
        GD.Print( "Inject works!" );
        _contexts         = contexts;
        _container        = container;
        _fixedStepSystems = new FixedStepSystems( contexts );
        _fixedStepSystems.InjectSelfAndChildren( container );
        _fixedStepSystems.Initialize();
    }

    public override void _Process( double delta ) { }

    public override void _PhysicsProcess( double delta )
    {
        if ( _fixedStepSystems == null )
            return;
        _fixedStepSystems.Execute();
        _fixedStepSystems.Cleanup();
    }
}