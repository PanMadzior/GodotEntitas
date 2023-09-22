using Entitas;

namespace Tabasco;

public class TestSystem : Systems
{
    public TestSystem()
    {
        Add( new TestExecuteSystem() );
        Add( new TestInitSystem() );
    }
}