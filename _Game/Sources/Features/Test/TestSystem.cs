using Entitas;

namespace Game;

public class TestSystem : Systems
{
    public TestSystem()
    {
        Add( new TestExecuteSystem() );
        Add( new TestInitSystem() );
    }
}