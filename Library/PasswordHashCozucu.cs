using System;
using System.Security.Cryptography;
using System.Text;

public class PasswordHasheCozucu
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
            string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);
            return hashedPassword;
        }
    }

    public static bool VerifyPassword(string enteredPassword, string savedHashedPassword)
    {
        string hashedEnteredPassword = HashPassword(enteredPassword);
        return (hashedEnteredPassword == savedHashedPassword);
    }
}