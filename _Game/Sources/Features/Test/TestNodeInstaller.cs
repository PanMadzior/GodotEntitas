using Zenject;

namespace Game;

public partial class TestNodeInstaller : NodeInstaller
{
    protected override void InstallBindings( DiContainer container )
    {
        container.Bind<TestService>().AsSingle().NonLazy();
    }
}