//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyTestListenerComponent anyTestListener { get { return (AnyTestListenerComponent)GetComponent(GameComponentsLookup.AnyTestListener); } }
    public bool hasAnyTestListener { get { return HasComponent(GameComponentsLookup.AnyTestListener); } }

    public void AddAnyTestListener(System.Collections.Generic.List<IAnyTestListener> newValue) {
        var index = GameComponentsLookup.AnyTestListener;
        var component = (AnyTestListenerComponent)CreateComponent(index, typeof(AnyTestListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyTestListener(System.Collections.Generic.List<IAnyTestListener> newValue) {
        var index = GameComponentsLookup.AnyTestListener;
        var component = (AnyTestListenerComponent)CreateComponent(index, typeof(AnyTestListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyTestListener() {
        RemoveComponent(GameComponentsLookup.AnyTestListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnyTestListener;

    public static Entitas.IMatcher<GameEntity> AnyTestListener {
        get {
            if (_matcherAnyTestListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyTestListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyTestListener = matcher;
            }

            return _matcherAnyTestListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyTestListener(IAnyTestListener value) {
        var listeners = hasAnyTestListener
            ? anyTestListener.value
            : new System.Collections.Generic.List<IAnyTestListener>();
        listeners.Add(value);
        ReplaceAnyTestListener(listeners);
    }

    public void RemoveAnyTestListener(IAnyTestListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyTestListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyTestListener();
        } else {
            ReplaceAnyTestListener(listeners);
        }
    }
}
