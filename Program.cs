using System;

namespace Introdução_a_linguagem_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string aFriend = "Bill";
            Console.WriteLine($"Olá {aFriend}");
            aFriend = "Maria";
            Console.WriteLine("Olá " + aFriend);
            aFriend = "Juliana";
            Console.WriteLine("Olá " + aFriend);
            aFriend = "Luis";
            Console.WriteLine($"Hello {aFriend}");


            string firstFriend = "Maria";
            string secondFriend = "Du";
            Console.WriteLine($"Meus amigos são {firstFriend} e {secondFriend}");


            Console.WriteLine($"O nome {firstFriend} tem {firstFriend.Length} letras.");
            Console.WriteLine($"O nome {secondFriend} tem {secondFriend.Length} letras");

            string greeting = "    Olá mundo!        ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Olá Mundo!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Olá", "Saudações");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());


            string songLyrics = "Você diz adeus e eu digo olá";
            Console.WriteLine(songLyrics.Contains("adeus"));
            Console.WriteLine(songLyrics.Contains("saudações"));


            songLyrics = "Você diz adeus e eu digo olá";
            Console.WriteLine(songLyrics.StartsWith("Voce"));
            Console.WriteLine(songLyrics.EndsWith("olá"));

        }
    }
}
