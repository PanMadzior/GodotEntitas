using System.Collections.Generic;
using Entitas;
using Godot;

namespace Tabasco;

public class TestExecuteSystem : IExecuteSystem
{
    private readonly IGroup<GameEntity> _group;
    private readonly List<GameEntity>   _buffer;

    public TestExecuteSystem()
    {
        _group  = Contexts.sharedInstance.game.GetGroup( GameMatcher.Test );
        _buffer = new List<GameEntity>();
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