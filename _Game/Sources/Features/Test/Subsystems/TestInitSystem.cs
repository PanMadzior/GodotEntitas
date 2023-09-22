using Entitas;
using Godot;

namespace Game;

public class TestInitSystem : IInitializeSystem
{
    public TestInitSystem( Contexts contexts ) { }

    public void Initialize()
    {
        Contexts.sharedInstance.game.CreateEntity().AddTest( 1 );
        GD.Print( "Initialize system!" );
    }
}