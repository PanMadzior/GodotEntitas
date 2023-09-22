using Godot;
using Godot.Collections;
using Zenject;

namespace Game;

public partial class ZenjectContext : Node
{
    [Export]
    public Array<NodeInstaller> nodeInstallers;

    public DiContainer Container { get; private set; }

    public override void _Ready()
    {
        CreateContainer();
        InstallNodeInstallers();
        InjectSceneNodes();
        Container.ResolveRoots();
    }

    private void CreateContainer()
    {
        Container = new DiContainer();
        Container.Install<CoreInstaller>();
    }

    private void InstallNodeInstallers()
    {
        foreach ( var nodeInstaller in nodeInstallers ) {
            GD.Print( $"Installing {nodeInstaller.Name} node installer..." );
            var installer = nodeInstaller.GetInstaller();
            Container.Inject( installer );
            installer.InstallBindings();
        }
    }

    private void InjectSceneNodes()
    {
        var rootNode = GetParent() ?? this;
        GD.Print( $"Injecting nodes form root={rootNode.Name}..." );
        InjectNode( rootNode );
    }

    private void InjectNode( Node node )
    {
        foreach ( var child in node.GetChildren() ) {
            Container.Inject( child );
            GD.Print( $"Injecting {child.Name}..." );
            if ( child.GetChildCount() > 0 )
                InjectNode( child );
        }
    }
}