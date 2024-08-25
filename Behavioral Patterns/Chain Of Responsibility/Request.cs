class Request
{
    public readonly string AuthenticationMode;
    public readonly string Path;
    public readonly string Method;
    public readonly string? Data;

    public Request(string authenticationMode, string path, string method, string data = "")
    {
        AuthenticationMode = authenticationMode;
        Path = path;
        Method = method;
        Data = data;
    }
}