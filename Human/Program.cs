using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Programm 
{
        class Human
    {
        public string Name = "Not";
    }

    class List
    {
        public Human Humans;
        public string GetName()
            {
                return Humans.Name;
            }
        public void PushName(string Name)
        {
            Humans = new Human{ Name = Name }; //Если писать Humans.Name = Name Ругается на то что Human остаётся null.
            }
    }
    static void Main(string[] args)
    {
        List list = new List();
        list.PushName("Человечек");
        Console.WriteLine(list.GetName());
        list.PushName("Чел");
        Console.WriteLine(list.GetName());
    }
}