using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("Enter a secret message: ");
      string userInput = Console.ReadLine();
      char[] secretMessage = userInput.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++){
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet, letter);
        index = (index + 3) % alphabet.Length;
        char encryptChar = alphabet[index];
        encryptedMessage[i] = encryptChar;
      }
      string cipher = String.Join("", encryptedMessage);
      Console.Write(cipher);

    }
  }
}