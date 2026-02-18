// Singleton pattern
public sealed class AuthState
{
    private static AuthState? _instance;
    private string? _token;
    
    private AuthState() {}
    
    public static AuthState GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AuthState();
        }
        return _instance;
    }

    public void SetToken(string token)
    {
        if (!string.IsNullOrEmpty(token) && token != _token)
        {
            _token = token;
        }
    }
    
    public string? GetToken()
    {
        return _token;
    }
}