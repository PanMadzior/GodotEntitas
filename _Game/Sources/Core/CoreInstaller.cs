using Zenject;

namespace Game;

public class CoreInstaller : Installer
{
    public override void InstallBindings()
    {
        Container.BindInstance( Contexts.sharedInstance ).AsSingle().NonLazy();
        InstallFeatures();
    }

    private void InstallFeatures()
    {
        TestInstaller.Install( Container );
    }
}