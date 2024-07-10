using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Programm 
{
        class Human
    {
        public string Name;
        public void PushName(string name)
        {
            Name = name;
        }
    }
    static void Main(string[] args)
    {
        Human human = new Human();
        human.PushName("Чел");
        Console.WriteLine(human.Name);
    }
}