//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.TestComponent test { get { return (Game.TestComponent)GetComponent(GameComponentsLookup.Test); } }
    public bool hasTest { get { return HasComponent(GameComponentsLookup.Test); } }

    public void AddTest(int newValue) {
        var index = GameComponentsLookup.Test;
        var component = (Game.TestComponent)CreateComponent(index, typeof(Game.TestComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest(int newValue) {
        var index = GameComponentsLookup.Test;
        var component = (Game.TestComponent)CreateComponent(index, typeof(Game.TestComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest() {
        RemoveComponent(GameComponentsLookup.Test);
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

    static Entitas.IMatcher<GameEntity> _matcherTest;

    public static Entitas.IMatcher<GameEntity> Test {
        get {
            if (_matcherTest == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Test);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTest = matcher;
            }

            return _matcherTest;
        }
    }
}
