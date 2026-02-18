# Singleton pattern
class AuthState:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super().__new__(cls)
        return cls._instance

    def __init__(self):
        if not hasattr(self, "_token"):
            self._token = None

    def set_token(self, token: str) -> None:
        if token and token != self._token:
            self._token = token

    def get_token(self) -> str | None:
        return self._token