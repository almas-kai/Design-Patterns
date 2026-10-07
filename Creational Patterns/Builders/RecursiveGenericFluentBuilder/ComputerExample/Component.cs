namespace RecursiveGenericFluentBuilder.ComputerExample;

public class Computer
{
    public string CPU { get; set; } = string.Empty;
    public string GPU { get; set; } = string.Empty;
    public string RAM { get; set; } = string.Empty;
    public string SSD { get; set; } = string.Empty;
    public class Builder : SSDBuilder<Builder> { }
    public static Builder New => new();
    public override string ToString()
    {
        return $"""
            {nameof(CPU)}: {CPU}
            {nameof(GPU)}: {GPU}
            {nameof(RAM)}: {RAM}
            {nameof(SSD)}: {SSD}
        """;
    }
}