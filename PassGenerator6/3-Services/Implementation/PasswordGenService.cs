using PassGenerator._3_Services.Interface;
using System;

namespace PassGenerator._3_Services
{


    public class PasswordGenService : IPasswordGenService
    {
       
        
            public List<string> GenerateRandomPasswords(int passLength, int numberOfPasswords)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&ç.,*_-";
                Random random = new Random();
                List<string> passwords = new List<string>();

                for (int j = 0; j < numberOfPasswords; j++)
                {
                    char[] password = new char[passLength];

                    for (int i = 0; i < passLength; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    passwords.Add(new string(password));
                }

                return passwords;
            }


        }
}