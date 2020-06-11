using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[]{
        "Plato is very good at eating.",
        "Plato isn't a shit tier runner.",
        "Plato does do the needful",
        "Plato can swim faster than you"
      };

            bool[] answers = new bool[]{
        true,
        true,
        true,
        true
      };
            bool[] responses = new bool[questions.Length];
            if (questions.Length != answers.Length)
            {
                Console.Write("QUESTIONS AND ANSWERS ARRAYS HAVE DIFFERENT LENGTHS! FIX IT");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.Write(question);
                Console.Write("True or False? ");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.Write("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            foreach (bool response in responses)
            {
                Console.Write(response);
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool userAnswer = responses[scoringIndex];
            }




        }
    }
}
