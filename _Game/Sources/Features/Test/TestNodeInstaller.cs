﻿using Godot;
using Zenject;

namespace Game;

[GlobalClass]
public partial class TestNodeInstaller : NodeInstaller
{
    protected override void InstallBindings( DiContainer container )
    {
        //container.Bind<TestService>().AsSingle().NonLazy();
    }
}