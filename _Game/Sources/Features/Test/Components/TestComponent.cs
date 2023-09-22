using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Tabasco;

[Game, Event( EventTarget.Any )]
public class TestComponent : IComponent
{
    public int value;
}