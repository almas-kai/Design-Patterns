using Decorator.PrimaryObject;

namespace Decorator.Wrappers;

/// <summary>
///     The decorator that prints text in italic.
/// </summary>
public class ItalicDecorator : BaseDecorator {
    public ItalicDecorator(AbstractPrinter printer) : base(printer){}

    public override void Print(string message)
    {
        Console.Write("\u001b[3m");
        base.Print(message);
        Console.Write("\u001b[0");
    }
}