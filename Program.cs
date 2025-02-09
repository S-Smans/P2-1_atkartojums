using System;

class Program
{
    static void Main()
    {
        // 1.uzd
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Ievadi skaitli: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("Lielāks");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Mazāks");
            }
            else
            {
                Console.WriteLine($"Apsveicu! Tu uzminēji skaitli {targetNumber} ar {attempts} mēģinājumiem.");
            }
        } while (guess != targetNumber);



        //2.uzd
        string wordToGuess = "programming";
        char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
        List<char> guessedLetters = new List<char>();
        int attempts = 0;

        Console.WriteLine(guessedWord);

        while (new string(guessedWord) != wordToGuess)
        {
            Console.Write("Ievadi burtu: ");
            char guess = char.Parse(Console.ReadLine());
            attempts++;

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("Šo burtu tu jau esi minējis.");
                continue;
            }

            guessedLetters.Add(guess);

            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedWord[i] = guess;
                    }
                }
                Console.WriteLine($"{new string(guessedWord)}");
            }
            else
            {
                Console.WriteLine("Tāda burta vārdā nav.");
            }
        }

        Console.WriteLine($"Vārds uzminēts ar mēģinājuma skaitu: {attempts}");
    }
}
