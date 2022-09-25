using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число, необходимое для сдвига символов вправо:");
        int x = Convert.ToInt16(Console.ReadLine());//число, определяющее, на сколько каждый символ смещен вправо
        Console.WriteLine("Введите количество строк в сообщении:");
        int y = Convert.ToInt16(Console.ReadLine());//вводим количество строк в сообщении

        string[] message = new string[y];
        for (var i = 0; i < message.Length; i++)
        {
            Console.WriteLine($"Введите строку #{i+1}");
            message[i] = Console.ReadLine();//строка сообщения. Нужно вводить столько раз, сколько мы указали в переменной y
            char[] messageChars = message[i].ToCharArray();//создаем массив символов, который заполняем символами строки, введенной в данной итерации
            Array.Reverse(messageChars);//разворачиваем массив задом-наперед
            for (var j = 0; j < messageChars.Length; j++)
            {
                var someChar = (int)messageChars[j];
                messageChars[j] = (char)(someChar - x);//смещаем каждый символ в массиве на количество, заданное в переменную x
            }
            message[i] = new string(messageChars);//присваиваем строке преобразованный вид
        }
        for (var i = 0; i < message.Length; i++)
        {
            Console.WriteLine(message[i]);
        }
    }
}