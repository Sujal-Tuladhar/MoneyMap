using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MoneyMap.Components.Pages;

public partial class Login
{
    private LoginModel model = new LoginModel();
    private string? message;
    [Inject] private IJSRuntime JSRuntime { get; set; }

    private async Task OnValidSubmit()
    {
        try
        {
// Authenticate the user
            var user = await UserService.GetUserAsync(model.Username);
            if (user != null && UserService.ValidateUser(user, model.Password))
            {
// Successful login
                message = "Login successful!";

// Save username and currency to local storage
                await JSRuntime.InvokeVoidAsync("localStorage.setItem", "username", model.Username);
                await JSRuntime.InvokeVoidAsync("localStorage.setItem", "currency", user.Currency);

// Navigate to the dashboard or home page
                NavigationManager.NavigateTo("/dashboard");
            }
            else
            {
// Invalid credentials
                message = "Invalid username or password.";
            }
        }
        catch (Exception ex)
        {
            message = $"Error: {ex.Message}";
        }
    }

    private class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;
    }
}