// Singleton pattern
class AuthState {
    private _token: string | null = null;
    private static _instance: AuthState | null = null;

    private constructor() {}


    static getInstance(): AuthState {
        if (this._instance === null) {
            this._instance = new AuthState();
        }
        return this._instance;
    }

    setToken(token: string): void {
        if (!token || token !== this._token) {
            this._token = token;
        }
    }

    getToken(): string | null {
        return this._token;
    }
}