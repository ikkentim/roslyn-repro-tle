using System.Collections.Immutable;

Foo.Create();
Console.WriteLine("Hello, World!");


public struct Foo
{
    // This is fine
    public ImmutableArray<Foo> Prop { get; }

    public static ImmutableArray<Foo> Create()
    {
        return default;
    }
}