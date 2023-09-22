using Godot;
using Zenject;

namespace Game;

[GlobalClass]
public partial class ABTestInstaller : ResourceInstaller
{
    [Export]
    public GameConfiguration configs;

    protected override void InstallBindings( DiContainer container )
    {
        foreach ( var cfg in configs.configs ) {
            GD.Print( $"GameConfiguration: binding type {cfg.GetType().Name} with resource {cfg.ResourcePath}..." );
            container.Bind( cfg.GetType() ).FromInstance( cfg );
            container.QueueForInject( cfg );
        }
    }
}