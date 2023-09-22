using Godot;
using Zenject;

namespace Game;

[GlobalClass]
public partial class TestResourceInstaller : ResourceInstaller
{
    protected override void InstallBindings( DiContainer container )
    {
        container.Bind<TestService>().AsSingle().NonLazy();
    }
}