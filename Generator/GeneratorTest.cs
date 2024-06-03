using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Generator
{
    [Generator]
    public class GeneratorTest : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // ERROR
            //
            // CSC : warning CS8784: Generator 'GeneratorTest' failed to initialize.
            // It will not contribute to the output and compilation errors may occur as a result.
            // Exception was of type 'TypeLoadException' with message 'Could not load type 'Generator.Bar' from assembly
            // 'Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.'.

            _ = Bar.Create();
        }
    }

    public struct Bar
    {
        public ImmutableArray<Bar> Prop { get; }

        public static ImmutableArray<Bar> Create()
        {
            return default;
        }
    }
}
