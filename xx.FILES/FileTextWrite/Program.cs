using System;
using System.IO;


namespace TextFileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем файл
            FileInfo f = new FileInfo("Thoughts.txt");
            // Получаем объект StreamWriter и с его помощью записываем в файл 
            // несколько строк текста 
            StreamWriter writer = f.CreateText();
            writer.WriteLine("Don't forget Mother's Day this year...");
            writer.WriteLine("Don't forget Father's Day this year...");
            writer.WriteLine("Don't forget these numbers:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }
            // Вставляем символ начала новой строки
            writer.Write(writer.NewLine);

            // Метод Close() автоматически очищает все буферы!
            writer.Close();
            Console.WriteLine("Created file and wrote some thoughts...");
        }
    }
}
