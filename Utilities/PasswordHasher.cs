namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class PasswordHasher
    {
        public static string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }

        public static string HashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password + salt);
        }

        public static bool VerifyPassword(string password, string salt, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password + salt, hashedPassword);
        }
    }
}
