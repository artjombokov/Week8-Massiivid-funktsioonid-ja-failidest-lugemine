using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChuckNorrisJoke;
            randomChuckNorrisJoke = GetRandomJokeFromFile("chuck.txt");

            Console.WriteLine($"Here's a joke for you: {randomChuckNorrisJoke}.");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomJokeFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\samplestktk\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
