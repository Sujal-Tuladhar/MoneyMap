using System.ComponentModel.DataAnnotations;
using MoneyMap.Data.Models;

namespace MoneyMap.Components.Pages;

public partial class Register
{
    private RegisterModel model = new RegisterModel();
    private string? message;

    private async Task OnValidSubmit()
    {
        try
        {
            var newUser = new User(model.Username, model.Password, model.Currency);
            await UserService.RegisterUser(newUser);
            message = "Registration successful!";
            NavigationManager.NavigateTo("/login");
        }
        catch (Exception ex)
        {
            message = ex.Message; // Display error (e.g., "Username already exists.")
        }
    }

    private class RegisterModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Currency is required.")]
        public string Currency { get; set; } = string.Empty;
    }
}