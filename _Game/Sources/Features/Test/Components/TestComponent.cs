using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Game;

[Game, Event( EventTarget.Any )]
public class TestComponent : IComponent
{
    public int value;
}