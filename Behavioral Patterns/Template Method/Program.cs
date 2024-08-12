namespace Template_Method;

class Program
{
    static void Main()
    {
        CodeValidatorAbstract codeValidator = new CSharpValidator();
        codeValidator.ValidateCode();
    }
}
