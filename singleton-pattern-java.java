// Singleton pattern
public final class AuthState {

    private static AuthState instance;
    private String token;

    private AuthState() {
    }

    public static AuthState getInstance() {
        if (instance == null) {
            instance = new AuthState();
        }
        return instance;
    }

    public void setToken(String token) {
        if (token != null && !token.isEmpty() && !token.equals(this.token)) {
            this.token = token;
        }
    }

    public String getToken() {
        return token;
    }
}
