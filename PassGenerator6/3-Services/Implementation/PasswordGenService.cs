﻿using PassGenerator._3_Services.Interface;
using System;

namespace PassGenerator._3_Services
{
    public class PasswordGenService : IPasswordGenService
    {
        public string GenerateRandomPassword(int passLength)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] password = new char[passLength];
            char[] password1 = new char[passLength];
            char[] password2 = new char[passLength];
            char[] password3 = new char[passLength];
            char[] password4 = new char[passLength];
            for (int i = 0; i < passLength; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
                password[i] = chars[random.Next(chars.Length)];
                password[i] = chars[random.Next(chars.Length)];
                password[i] = chars[random.Next(chars.Length)];
                password[i] = chars[random.Next(chars.Length)];

            }
            return new string(password) + " - " + new string(password) + " - " + new string(password) + " - " + new string(password) + " - " + new string(password); 
        }
    }
}