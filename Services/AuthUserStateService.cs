using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace Connect4.Services
{
    public class AuthUserStateService
    {
        private readonly AuthenticationStateProvider _authProvider;

        public AuthUserStateService(AuthenticationStateProvider authProvider)
        {
            _authProvider = authProvider;
        }
        public async Task<ClaimsPrincipal> GetUserAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            return authState.User;
        }

        public async Task<string?> GetUserIdAsync()
        {
            var user = await GetUserAsync();
            return user.Identity?.IsAuthenticated == true
                ? user.FindFirst(ClaimTypes.NameIdentifier)?.Value
                : null;
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            var user = await GetUserAsync();
            return user.Identity?.IsAuthenticated ?? false;
        }

        //Para foto
        public event Action? OnUserProfileChanged;

        private string? _fotoBase64;
        public string? FotoBase64
        {
            get => _fotoBase64;
            set
            {
                if (_fotoBase64 != value)
                {
                    _fotoBase64 = value;
                    OnUserProfileChanged?.Invoke();
                }
            }
        }

        public void NotifyProfileChanged()
        {
            OnUserProfileChanged?.Invoke();
        }
    }
}
