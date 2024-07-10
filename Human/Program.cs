using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Programm 
{
        class Human
    {
        public class Passport
        {
            public string Name;
        }
    }
    static void Main(string[] args)
    {
        Human.Passport passport = new Human.Passport();
        passport.Name = "Чел";
        Console.WriteLine(passport.Name);
    }
}