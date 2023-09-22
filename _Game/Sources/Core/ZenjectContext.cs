using Godot;
using Zenject;

namespace Tabasco;

public partial class ZenjectContext : Node
{
    public DiContainer Container { get; private set; }

    public override void _Ready()
    {
        CreateContainer();
        InjectSceneNodes();
        Container.ResolveRoots();
    }

    private void CreateContainer()
    {
        Container = new DiContainer();
        Container.Install<CoreInstaller>();
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