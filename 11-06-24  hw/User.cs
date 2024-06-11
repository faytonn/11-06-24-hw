namespace _11_06_24__hw
{
    public class User
    {
        int i = 0;
        private static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string _password
        {
            get
            {
                return _password;
            }
            set
            {
                while (true)
                {

                    if (PasswordChecker(value))
                    {
                        _password = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password written. \n(At least 1 digit & capital and lowercase letter.");
                        break;
                    }
                }
            }


        }
        public User(string fullName, string email, string password)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Email = email;
            _password = password;
        }

        public bool PasswordChecker(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            if (password.Length < 8)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        public string GetInfo()
        {
            return $"ID: {Id} \nFullName: {FullName} \nEmail: {Email}";
        }

        public static string FindUserByID(int id, User[] users)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    return user.GetInfo();
                }

            }

            return "User is not found";

        }

    }
}
