using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace encodingDecoding
{
    class Program
    {
        static void TestFileStreamText()
        {
            // Получить объект FileStream.
            using (FileStream fStream = File.Open(@"myMessage.dat", FileMode.Create))
            {
                // Закодировать строку в виде массива байт.
                string msg = "Простая строка текста";
                byte[] msgAsByteArray = Encoding.UTF8.GetBytes(msg);
                // Записать byte[] в файл.
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
                fStream.Position = 0; // Сбросить внутреннюю позицию потока.
                                      // Прочитать типы из файла и вывести на консоль.
                Console.Write("Your message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }
                //fStream.Read(bytesFromFile, 0,(int) fStream.Length); //Вывести декодированные сообщения
                Console.Write("\nDecoded Message: ");
                Console.WriteLine(Encoding.UTF8.GetString(bytesFromFile));
            }
        }

        static void Main(string[] args)
        {


            TestFileStreamText();
            Console.ReadKey();
        }
    }
}
