namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public static class UserSession
    {
        /*
        EmployeeNumber = employeeNumber,
        EmployeeName = fullName,
        Birthdate = birthdate,
        Salt = salt,
        SaltedPassword = saltedPassword,
        CreatedAt = DateTime.Now,
        JobPosition = jobposition,
        Schedule = schedule,
        ProfilePicture = defaultProfilePicture
        */

        public static string EmployeeNumber { get; set; }
        public static string EmployeeName { get; set; }
        public static string Birthdate { get; set; }
        public static string JobPosition { get; set; }
        public static string Schedule { get; set; }
        public static byte[] ProfilePicture { get; set; }

        public static void Clear()
        {
            EmployeeNumber = string.Empty;
            EmployeeName = string.Empty;
            Birthdate = string.Empty;
            JobPosition = string.Empty;
            Schedule = string.Empty;
            ProfilePicture = null;
        }
    }
}
