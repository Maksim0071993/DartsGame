using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Сыграем в игру ?");
            Console.WriteLine("Выбирай — камень, ножницы или бумага ? Для завершения игры, введи — выход");
            string userChoise = Console.ReadLine();//переменная содержащая выбор пользователя
                                       //прописываем завершение программы
            
            
            String[] items = new String[3];
            items[0] = "Stone";
            items[1] = "Scissors";
            items[2] = "Paper";
        }
    }
}
