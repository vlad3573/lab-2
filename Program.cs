﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login = "Toyeo";
            user.Name = "John";
            user.Surname = "Wick";
            user.Age = 56;

            Console.WriteLine(" **User data** " +
                "\n\nLogin: {0};" +
                "\nName: {1};" +
                "\nSurname: {2};" +
                "\nAge: {3};" +
                "\nTime: {4}.", 
                user.Login, user.Name, user.Surname, user.Age, DateTime.Now);
        }
    }
}
