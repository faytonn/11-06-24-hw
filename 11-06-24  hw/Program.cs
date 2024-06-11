using _11_06_24__hw;
using System.Data;

User[] users = new User[3];
bool systemProcess = true;

for (int i = 0; i < users.Length; i++)
{
    Console.Write("Enter full name: ");
    string fullName = Console.ReadLine();

    Console.Write("Enter email: ");
    string email = Console.ReadLine();

    while (true)
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        User temporaryUser = new User(fullName, email, password);
        if (temporaryUser.PasswordChecker(password))
        {
            users[i] = temporaryUser;
            break;
        }
        else
        {
            Console.WriteLine("Invalid password written. \n(At least 1 digit & capital and lowercase letter.");

        }
    }

    while (systemProcess)
    {
        Console.WriteLine("Commands:");
        Console.WriteLine("1. Show all users     OR     /show");
        Console.WriteLine("2. Get info by ID     OR     /info");
        Console.WriteLine("0. Quit               OR     /exit");

        Console.Write("Select a command: ");
        string command = Console.ReadLine();

        if (command == "1" || command == "/show")
        {
            foreach (User user in users)
            {
                user.GetInfo();
            }
        }

        else if (command == "2" || command == "/info")
        {
            Console.Write("Enter user ID: ");
            int _id = int.Parse(Console.ReadLine());

           string result = User.FindUserByID(_id, users);
        }
        else if (command == "3" || command == "/exit") 
        {
            systemProcess = false;
            break;
        }
        else
        {
            Console.WriteLine("Please write a valid command");
        }
    }
}
