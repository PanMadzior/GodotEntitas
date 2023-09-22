using Entitas;

namespace Game;

public class FixedStepSystems : InjectableFeature
{
    public FixedStepSystems( Contexts contexts )
    {
        Add( new TestSystem( contexts ) );
        Add( new GameEventSystems( contexts ) );
    }
}