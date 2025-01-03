using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace MoneyMap.Components.Pages;

public partial class Login
{
    private RegisterAccountForm model = new RegisterAccountForm();
    private bool success;

    public class RegisterAccountForm
    {
        [Required]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Username { get; set; }

        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required] [Compare(nameof(Password))] public string Password2 { get; set; }
    }

    private void OnValidSubmit(EditContext context)
    {
        success = true;
        StateHasChanged();
    }
}