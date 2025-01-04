namespace MoneyMap.Data.Models
{
    // The User class represents a user with basic authentication and currency preferences
    public class User
    {
        // Properties for User credentials and settings
        public string Username { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }

        // Constructor to initialize the User object with username, password, and currency
        public User(string username, string password, string currency)
        {
            Username = username;
            Password = password;
            Currency = currency;
        }

        // Method to check if the password matches the provided one
        public bool ValidatePassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        // Method to update the user's currency
        public void UpdateCurrency(string newCurrency)
        {
            Currency = newCurrency;
        }

        // Override the ToString() method to return a string representation of the user
        public override string ToString()
        {
            return $"Username: {Username}, Currency: {Currency}";
        }
    }
}