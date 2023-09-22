using Entitas;
using Godot;

namespace Game;

public class TestInitSystem : IInitializeSystem
{
    public void Initialize()
    {
        Contexts.sharedInstance.game.CreateEntity().AddTest( 1 );
        GD.Print( "Initialize system!" );
    }
}