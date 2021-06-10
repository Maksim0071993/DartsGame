using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Logic
    {
        
        
        

       private string UserChoise(string message)
        {
           string choise;
            switch (message)
            {
                
                case "Камень": 
                    Console.WriteLine("Ваш выбор Камень");
                    choise = "Камень";
                    return choise;
                case "Ножницы":
                    Console.WriteLine("Ваш выбор Ножницы");
                    choise = "Ножницы";
                    return choise;
                case "Бумага":
                    Console.WriteLine("Ваш выбор Бумага");
                    choise = "Бумага";
                    return choise;
                default:
                    Console.WriteLine("Неверный ввод. Допустимые варианты : Камень, Ножницы, Бумага");
                    break;
            }
            return choise;

        }
    }
}
