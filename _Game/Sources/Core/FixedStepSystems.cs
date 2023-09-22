using Entitas;

namespace Game;

public class FixedStepSystems : Systems
{
    public FixedStepSystems()
    {
        Add( new TestSystem() );
        Add( new GameEventSystems( Contexts.sharedInstance ) );
    }
}