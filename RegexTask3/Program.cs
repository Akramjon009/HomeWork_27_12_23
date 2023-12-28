using System.Text.RegularExpressions;

namespace RegexTask3
{
    internal class Task3
    {
        public Task3(string userSelection)
        {
            Console.Write(">> ");
            string user = Console.ReadLine()!;

            if (userSelection == "1")
            {
              
                IsEmailValidation(user);
            }
            else if (userSelection == "2")
            {
                
                IsPhoneNumberValidation(user);
            }
            else if (userSelection == "3")
            {
           
                IsPasswordValidation(user);
            }
            else if (userSelection == "4")
            {
      
                IsBirthdayValidation(user);
            }
        }

        public bool IsEmailValidation(string email)
        {
            string pattern = @"^[a-z0-9_-]+@[a-z0-9]+\.[a-z]{2,}$";
            bool isValidEmail = Regex.IsMatch(email, pattern);
            Console.WriteLine(isValidEmail);
            return true;
        }
        public bool IsPhoneNumberValidation(string phoneNumber)
        {
            string pattern = @"^[+]998\s(\d{2})\s(\d{3})\s(\d{2})\s(\d{2})$";
            bool isValidPhoneNumber = Regex.IsMatch(phoneNumber, pattern);
            Console.WriteLine(isValidPhoneNumber);
            return true;
        }
        public void IsPasswordValidation(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{9,16}$";
            bool isValidPassword = Regex.IsMatch(password, pattern);
            if (isValidPassword)
            {
                Console.WriteLine("Success!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not success!!!");
                Console.ReadKey();
            }
        }
        public bool IsBirthdayValidation(string birthday)
        {
            string pattern = @"^(\d{2})-(\d{2})-(\d{4})$";
            bool isValidEmail = Regex.IsMatch(birthday, pattern);
            Console.WriteLine(isValidEmail);
            return true;
        }

    }
}