using Entitas;

namespace Game;

public class TestSystem : InjectableFeature
{
    public TestSystem( Contexts contexts )
    {
        Add( new TestExecuteSystem( contexts ) );
        Add( new TestInitSystem( contexts ) );
    }
}