using Godot;
using Godot.Collections;

namespace Game;

[GlobalClass]
public partial class GameConfiguration : Resource
{
    [Export]
    public Array<Resource> configs;

    public T GetConfig<T>() where T : class
    {
        foreach ( var c in configs ) {
            if ( c is T ) {
                return c as T;
            }
        }

        return null;
    }

    public void SetConfig<T>( T config ) where T : Resource
    {
        for ( int i = 0; i < configs.Count; i++ ) {
            if ( configs[i] is T ) {
                configs[i] = config;
                return;
            }
        }

        configs.Add( config );
    }
}