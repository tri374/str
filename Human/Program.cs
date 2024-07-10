using System; //Использование библиотеки System
using System.Collections.Generic; //Использование библиотеки System.Collections.Generic
using System.Security.Cryptography; //Использование библиотеки System.Security.Cryptography
using System.Xml.Linq; //Использование библиотеки System.Xml.Linq

public class Programm //Общий класс, Структура даных
{
    class Passport //Переменная содержащая, так и другие переменные, так и функции.
    {
        public string Name = "not"; //Переменная string с именем "Name" которой присвоено строчка "not". Public окрывает доступ к переменной для других классов.
        public void PushName(string name) //Функция для присвоении имени.
        {
            Name = name; //Присвоение новой строчки к переменной Name.
        }
    }
    class Human //Tоже самое что и у 7 строки.
    {
        Passport passport = new Passport(); //Создание объекта отссылающая на класс Passport.
        public string ToName() //Класс который возращает переменую string.
        {
            string name = passport.Name; //Присвоение Name взятая из passport к переменной name.
            return name; //Возращение переменной name.
        }
        public void PushName(string name) //Класс void к которому можно дальше ссылаться для работы команд, также он не возвращает значения.
        {
            passport.PushName(name); //ССылка к функции внутри объекта passport.
        }
    }
    static void Main(string[] args) //static обозначает что у этого класса не может быть копий.
    {
        Human human = new Human(); //Создание объекта отссылающая на класс Human.
        human.PushName("Чел"); //Присвоение строки для переменной name в функции PUshName.
        Console.WriteLine(human.ToName()); //Выводит строку которое возвращается из функции ToName. 
        human.PushName("Челик"); //↑↑
        Console.WriteLine(human.ToName()); //↑↑
    }
}