using Godot;

namespace Tabasco;

public partial class TestListener : Node, IAnyTestListener
{
    public override void _Ready()
    {
        Contexts.sharedInstance.game.CreateEntity().AddAnyTestListener( this );
    }

    public void OnAnyTest( GameEntity entity, int value )
    {
        GD.Print( "Event!!" );
    }
}