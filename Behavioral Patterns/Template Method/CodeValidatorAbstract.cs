abstract class CodeValidatorAbstract
{
    // Template Method.
    public void ValidateCode()
    {
        if (IsEnableAntiVirusSystem())
        {
            EnableAntiVirusSystem();
        }
        LoadFile();
        AnalyzeFile();
        Log();
        ShowResults();
        CloseFile();
    }

    // The loading step is the same for all.
    protected void LoadFile()
    {
        Console.WriteLine("Loading the file into the system");
    }

    // The virus checking system is enabled by default using this hook. But it can be disabled if the file is from the trusted source, thus winning in performance front.
    protected bool IsEnableAntiVirusSystem()
    {
        return true;
    }
    protected void EnableAntiVirusSystem()
    {
        Console.WriteLine("Anti-Virus system online.");
    }

    protected abstract void AnalyzeFile();
    protected abstract void Log();
    protected abstract void ShowResults();

    // This hook does nothing but optionally can be used.
    protected abstract void BeforeCloseHook();

    // This step is the same for all file types.
    protected void CloseFile()
    {
        BeforeCloseHook();
        Console.WriteLine("Closing the file.");
    }
}