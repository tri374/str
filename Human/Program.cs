using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

public class Programm 
{
        class Human
    {
        public class Passport;
    }
    class Passport
    {
        public string Name;
    }
    static void Main(string[] args)
    {
        Human human = new Human();
        Passport passport = new Passport();
        passport.Name = "Чел";
        Console.WriteLine(passport.Name);
    }
}