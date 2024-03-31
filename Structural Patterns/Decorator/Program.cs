using Decorator.PrimaryObject;
using Decorator.Wrappers;

namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        string message = "Hello, World!";

        // Default implementation: just prints text. No decorators so far.
        AbstractPrinter printable = new ConsolePrinter();
        printable.Print("Printing text (no decorators): " + message);

        // Default and bold (simply put bold): prints test in bold. Applying bold decorator.
        printable = new BoldDecorator(printable);
        printable.Print("Printing text in bold (applied bold decorator): " + message);

        // Default + Bold + Italic: prints text in bold & in italic. Added one more decorator.
        printable = new ItalicDecorator(printable);
        printable.Print("Printing text in italic & bold (Added one more decorator): " + message);

        // Default and italic: prints text in italic. New fresh object with only one decorator.
        AbstractPrinter printable2 = new ConsolePrinter();
        printable2 = new ItalicDecorator(printable2);
        printable2.Print("Printing text in italic (applied italic decorator): " + message);
    }
}
