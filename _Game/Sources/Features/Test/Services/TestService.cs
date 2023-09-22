using System;

namespace Game;

public class TestService
{
    private readonly Random _random;

    public TestService()
    {
        _random = new Random();
    }

    public int GetTestValue()
    {
        return _random.Next();
    }
}