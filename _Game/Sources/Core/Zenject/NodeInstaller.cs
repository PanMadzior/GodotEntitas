using System;
using Godot;
using Zenject;

namespace Game;

public partial class NodeInstaller : Node
{
    public class NodeInternalInstaller : Installer
    {
        private readonly Action<DiContainer> _installBindingsCallback;

        public NodeInternalInstaller( Action<DiContainer> installCallback )
        {
            _installBindingsCallback = installCallback;
        }

        public override void InstallBindings()
        {
            _installBindingsCallback.Invoke( Container );
        }
    }

    protected Installer _installer;

    public Installer GetInstaller()
    {
        if ( _installer == null )
            _installer = new NodeInternalInstaller( InstallBindings );
        return _installer;
    }

    protected virtual void InstallBindings( DiContainer container ) { }
}