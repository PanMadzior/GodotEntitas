using Godot;

namespace Game;

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