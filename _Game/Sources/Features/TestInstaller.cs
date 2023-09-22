using Zenject;

namespace Tabasco;

public class TestInstaller : Installer<TestInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<TestService>().AsSingle().NonLazy();
    }
}