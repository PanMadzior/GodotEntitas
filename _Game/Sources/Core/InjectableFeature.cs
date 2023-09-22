using System.Collections;
using System.Collections.Generic;
using Entitas;
using Zenject;

namespace Game;

public class InjectableFeature : Feature
{
    public void InjectSelfAndChildren( DiContainer container )
    {
        InjectOrQueue( container, this );
        var systems = new HashSet<ISystem>();
        foreach ( var sys in _cleanupSystems )
            if ( !systems.Contains( sys ) )
                systems.Add( sys );
        foreach ( var sys in _executeSystems )
            if ( !systems.Contains( sys ) )
                systems.Add( sys );
        foreach ( var sys in _initializeSystems )
            if ( !systems.Contains( sys ) )
                systems.Add( sys );
        foreach ( var sys in _tearDownSystems )
            if ( !systems.Contains( sys ) )
                systems.Add( sys );
        InjectInChildren( systems, container );
    }

    private void InjectInChildren( IEnumerable collection, DiContainer container )
    {
        foreach ( var sys in collection ) {
            var injectableFeature = sys as InjectableFeature;
            if ( injectableFeature != null )
                injectableFeature.InjectSelfAndChildren( container );
            else
                InjectOrQueue( container, sys );
        }
    }

    private void InjectOrQueue( DiContainer container, object obj )
    {
        if ( container.IsInstalling )
            container.QueueForInject( obj );
        else
            container.Inject( obj );
    }
}