using System;
class Program
{
    static Random random=new Random();
    static void Main()
    {
        int low=1,high=100,guess;
        Console.WriteLine("think of a number between 1 and 100. i will try to guess it.");
        while(true)
        {
            guess=GenerateGuess(low,high);
            Console.WriteLine("is it "+guess+"? (H=high, L=low, C=correct)");
            char feedback=GetFeedback();
            if(feedback=='C')
            {
                Console.WriteLine("i guessed it!");
                break;
            }
            else if(feedback=='H')high=guess-1;
            else if(feedback=='L')low=guess+1;
        }
    }
    static int GenerateGuess(int low,int high){return random.Next(low,high+1);}
    static char GetFeedback()
    {
        while(true)
        {
            char input=char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if(input=='H'||input=='L'||input=='C')return input;
            Console.WriteLine("invalid input. enter H, L, or C.");
        }
    }
}

