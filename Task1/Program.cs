using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
       
        
            static void Main(string[] args)
            {
                // Массив из пяти различных видов исключений
                Exception[] exceptions = new Exception[]
                {
                new ArgumentException("Ошибка: Некорректный аргумент"),
                new DivideByZeroException("Ошибка: Деление на ноль"),
                new IndexOutOfRangeException("Ошибка: Выход за пределы массива"),
                new NullReferenceException("Ошибка: Ссылка на null объект"),
                new MyCustomException("Ошибка: Мое пользовательское исключение")
                };

                // Итерация по каждому типу исключения
                for (int i = 0; i < exceptions.Length; i++)
                {
                    try
                    {
                        Console.WriteLine($"\n--- Попытка {i + 1} ---");
                        throw exceptions[i]; // Генерируем исключение
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Поймано ArgumentException: {ex.Message}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Поймано DivideByZeroException: {ex.Message}");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine($"Поймано IndexOutOfRangeException: {ex.Message}");
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine($"Поймано NullReferenceException: {ex.Message}");
                    }
                    catch (MyCustomException ex)
                    {
                        Console.WriteLine($"Поймано MyCustomException: {ex.Message}");
                    }
                    finally
                    {
                        Console.WriteLine("Блок finally выполнен");
                    }
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    

