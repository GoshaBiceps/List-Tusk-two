using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace List_Tusk__two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToAddDossier = "1";
            const string CommandToDisplayAllDossier = "2";
            const string CommandToDossierDelite = "3";
            const string CommandToExsit = "4";

            List<string> names = new List<string>(0);
            List<string> positions = new List<string>(0);
            bool isExitProgram = true;

            while (isExitProgram)
            {
                Console.WriteLine($"{CommandToAddDossier} <- Добавить досье.");
                Console.WriteLine($"{CommandToDisplayAllDossier} <- Вывести все досье.");
                Console.WriteLine($"{CommandToDossierDelite} <- Удалить досье.");
                Console.WriteLine($"{CommandToExsit} <- Выход.");

                switch (Console.ReadLine())
                {
                    case CommandToAddDossier:
                        AddDossier(names, positions);
                        break;

                    case CommandToDisplayAllDossier:
                        ShowAllDossiers(names, positions);
                        break;

                    case CommandToDossierDelite:
                        DeleteDossier(names, positions);
                        break;

                    case CommandToExsit:
                        isExitProgram = false;
                        break;

                    default:
                        Console.WriteLine("Неверная команда");
                        break;
                }

                Console.WriteLine("Нажмите любую кнопку:");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddDossier(List<string> names, List<string> positions)
        {
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();

            Console.WriteLine("Введите должность сотрудника");
            string position = Console.ReadLine();

            names.Add(name);
            positions.Add(position);
        }

        static void ShowAllDossiers(List<string> names, List<string> positions)
        {
            
            if (names.Count > 0)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    int index = i + 1;
                    Console.WriteLine($" Индекс [ {index} ] | ФИО : {names[i]} | должность : {positions[i]}");
                }
            }
            else
            {
                Console.WriteLine("Заполните досъе!");
            }
        }

        static void DeleteDossier(List<string> names, List<string> positions)
        {
            if (names.Count > 0)
            {
                Console.WriteLine("Введите номер досъе.");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number))
                {
                    number--;

                    if (number >= 0 && number < names.Count)
                    {
                        names.RemoveAt(number);
                        positions.RemoveAt(number);
                    }
                    else
                    {
                        Console.WriteLine("Нечего удалять!");
                    }
                }
            }
        }
    }
}
