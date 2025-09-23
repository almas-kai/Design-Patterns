using System;

namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        SimpleSingleton simpleSingleton = SimpleSingleton.GetSimpleSingleton;
        Console.WriteLine(simpleSingleton.Uniqueness);

        SimpleSingleton simpleSingleton2 = SimpleSingleton.GetSimpleSingleton;

        Console.WriteLine(simpleSingleton2.Uniqueness);

        ModernSingleton modernSingleton = ModernSingleton.Instance;
        Console.WriteLine(modernSingleton.UniqueField);
    }
}
