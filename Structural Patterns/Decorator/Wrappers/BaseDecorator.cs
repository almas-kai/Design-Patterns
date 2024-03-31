using Decorator.PrimaryObject;

namespace Decorator.Wrappers;

/// <summary>
///     Represents the base decorator class.
/// </summary>
public class BaseDecorator : AbstractPrinter
{
    private AbstractPrinter Printer { get; set; }
    public BaseDecorator(AbstractPrinter printer){
        Printer = printer;
    }
    public override void Print(string message)
    {
        Printer.Print(message);
    }
}