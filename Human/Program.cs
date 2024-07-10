using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

public class Programm 
{
    public class Passport
    {
        public string Name = "not";
        public void PushName(string name)
        {
            Name = name;
        }
    }
    class Human
    {
        Passport passport = new Passport();
        public string ToName()
        {
            string name = passport.Name;
            return name;
        }
        public void PushName(string name)
        {
            passport.PushName(name);
        }
    }
    static void Main(string[] args)
    {
        Human human = new Human();
        human.PushName("Чел");
        Console.WriteLine(human.ToName());
        human.PushName("Челик");
        Console.WriteLine(human.ToName());
    }
}