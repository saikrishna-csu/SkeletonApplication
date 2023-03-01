using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

public class CustomAuthenticationStateProvider: AuthenticationStateProvider {
    public override async Task<AuthenticationState> GetAuthenticationStateAsync(){
        return await Task.FromResult(new AuthenticationState(AnonymousUser));
    }

    private ClaimsPrincipal AnonymousUser => new(new ClaimsIdentity(Array.Empty<Claim>()));

    private ClaimsPrincipal RegularFakedUser{
        get{
            var claims = new[] {
                new Claim(ClaimTypes.Name, "john"),
                new Claim(ClaimTypes.Role, "user"),
            };
            var identity = new ClaimsIdentity(claims, "faked");
            return new ClaimsPrincipal(identity);
        }
    }
    private ClaimsPrincipal AdminFakedUser{
        get{
            var claims = new[] {
                new Claim(ClaimTypes.Name, "sally"),
                new Claim(ClaimType.Role, "admin"),
            };
            var identity = new ClaimsIdentity(claims, "faked");
            return new ClaimsPrincipal(identity);
        }
    }

    public void RegularFakedSignIn(){
        var result = Task.FromResult(new AuthenticationState(RegularFakedUser));
        NotifyAuthenticationStateChanged(result);
    }
    public void AdminFakedSignIn(){
        var result = Task.FromResult(new AuthenticationState(AdminFakedUser));
        NotifyAuthenticationStateChanged(result);
    }
    public void SignOut(){
        var result = Task.FromResult(new AuthenticationState(AnonymousUser));
        NotifyAuthenticationStateChanged(result);
    }
}

