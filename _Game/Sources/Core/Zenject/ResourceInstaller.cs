using System;
using Godot;
using Zenject;

namespace Game;

public partial class ResourceInstaller : Resource
{
    public class ResourceInternalInstaller : Installer
    {
        private readonly Action<DiContainer> _installBindingsCallback;

        public ResourceInternalInstaller( Action<DiContainer> installCallback )
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
            _installer = new ResourceInternalInstaller( InstallBindings );
        return _installer;
    }

    protected virtual void InstallBindings( DiContainer container ) { }
}