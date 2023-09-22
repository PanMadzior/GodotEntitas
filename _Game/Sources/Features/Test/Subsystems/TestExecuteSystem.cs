using System.Collections.Generic;
using Entitas;
using Godot;
using Zenject;

namespace Game;

public class TestExecuteSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _group;
    private readonly List<GameEntity>   _buffer;

    public TestExecuteSystem( Contexts contexts )
    {
        _group  = Contexts.sharedInstance.game.GetGroup( GameMatcher.Test );
        _buffer = new List<GameEntity>();
    }

    [Inject]
    private void Init( TestConfig testConfig )
    {
        GD.Print( $"Test config injected to system through GameConfiguration. TestString={testConfig.testString}" );
    }

    public void Execute()
    {
        GD.Print( "Execute system!" );
        foreach ( var entity in _group.GetEntities( _buffer ) ) {
            entity.test.value++;
            if ( entity.test.value % 10 == 0 )
                entity.ReplaceTest( 1 );
        }
    }
}