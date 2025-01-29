using System;
class Program
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        int start = 0;
        int oldWordLength = oldWord.Length;
        while (start < sentence.Length)
        {
            bool matchFound = true;
            for (int i = 0; i < oldWordLength; i++)
            {
                if (start + i >= sentence.Length || sentence[start + i] != oldWord[i])
                {
                    matchFound = false;
                    break;
                }
            }

            if (matchFound)
            {
                result += newWord;
                start += oldWordLength;
            }
            else
            {
                result += sentence[start];
                start++;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}

