namespace Decorator.PrimaryObject;

/// <summary>
///     Represents common logic for printing text.
/// </summary>
public abstract class AbstractPrinter {

    /// <summary>
    ///     Prints <paramref name="message" />.
    /// </summary>
    /// <param name="message">
    ///     The message to print.
    /// </param>
    public abstract void Print(string message);
}