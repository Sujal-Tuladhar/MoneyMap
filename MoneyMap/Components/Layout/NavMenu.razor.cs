using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MoneyMap.Components.Layout
{
    public partial class NavMenu
    {
        [Inject] private IJSRuntime JSRuntime { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; } // Inject NavigationManager

        private async Task OnLogout()
        {
            // Clear local storage
            await JSRuntime.InvokeVoidAsync("localStorage.removeItem", "username");
            await JSRuntime.InvokeVoidAsync("localStorage.removeItem", "currency");

            // Log to console
            await JSRuntime.InvokeVoidAsync("console.log", "Logout successful");
            // Redirect user to login page
            NavigationManager.NavigateTo("/login");
        }
        private string Username { get; set; }
        private string Currency { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Retrieve data from localStorage
            Username = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "username");
            Currency = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "currency");

            // Optionally, you can log it to the console
            Console.WriteLine($"Username: {Username}, Currency: {Currency}");
        }
    }
}