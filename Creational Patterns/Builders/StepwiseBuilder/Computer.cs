namespace StepwiseBuilder.ProductToBuild;

public sealed class Computer
{
    public string CPU { get; set; } = string.Empty;
    public string GPU { get; set; } = string.Empty;
    public string SSD { get; set; } = string.Empty;
    public string RAM { get; set; } = string.Empty;

    public override string ToString()
    {
        return @$"
            CPU: {CPU}
            GPU: {GPU}
            SSD: {SSD}
            RAM: {RAM}
        ";
    }
}