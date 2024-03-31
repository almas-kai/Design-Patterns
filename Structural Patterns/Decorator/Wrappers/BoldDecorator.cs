using Decorator.PrimaryObject;

namespace Decorator.Wrappers;

/// <summary>
///     The decorator that prints text in bold.
/// </summary>
public class BoldDecorator : BaseDecorator {
    public BoldDecorator(AbstractPrinter printer) : base(printer){}
    public override void Print(string message){
        Console.Write("\u001b[1m");
        base.Print(message);
        Console.Write("\u001b[0m");
    }
}