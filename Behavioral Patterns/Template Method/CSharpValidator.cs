class CSharpValidator : CodeValidatorAbstract
{
    protected override void AnalyzeFile()
    {
        Console.WriteLine("Analyzing the C# file.");
    }

    protected override void BeforeCloseHook()
    {
        Console.WriteLine("Turn off the anti-virus system!");
    }

    protected override void Log()
    {
        Console.WriteLine("Sending logging data to the server.");
    }

    protected override void ShowResults()
    {
        Console.WriteLine("No errors were detected. Work on clean code recommended.");
    }
}