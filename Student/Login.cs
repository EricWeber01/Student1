using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Student
{
    class Account
    {
        string Login { get; set; }
        string Password { get; set; }
        string PasswordCheck { get; set; }
        public bool SetLogin()
        {
            bool check = false;
            var Lpattern = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})";
            do
            {
                Console.Write("\nEnter your email: ");
                Login = Console.ReadLine();
            } while (!Regex.IsMatch(Login, Lpattern));
            check = true;
            return check;
        }
        public bool SetPassword()
        {
            bool check = false;
            var Ppattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}";
            do
            {
                Console.Write("\nEnter your password: ");
                Password = Console.ReadLine();
                Console.Write("\nConfirm your password: ");
                PasswordCheck = Console.ReadLine();
            } while (Password != PasswordCheck || !Regex.IsMatch(Password, Ppattern));
            check = true;
            return check;
        }
        public void SetUser()
        {
            using (StreamWriter write = new StreamWriter("database.txt", true))
            {
                if (SetLogin() && SetPassword())
                {
                    write.WriteLine($"Login: {Login}\nPassword: {Password}");
                }
            }
        }
    }
}
