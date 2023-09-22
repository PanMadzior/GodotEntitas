using Entitas;

namespace Tabasco;

public class FixedStepSystems : Systems
{
    public FixedStepSystems()
    {
        Add( new TestSystem() );
        Add( new GameEventSystems( Contexts.sharedInstance ) );
    }
}