using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a string:");
        string input=Console.ReadLine().ToLower();
        int vowels=CountVowels(input);
        int consonants=CountConsonants(input);
        Console.WriteLine("vowels: "+vowels+"\tconsonants: "+consonants);
    }
    static int CountVowels(string s)
    {
        int count=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u')count++;
        }
        return count;
    }
    static int CountConsonants(string s)
    {
        int count=0;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]>='a'&&s[i]<='z'&&!(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'))count++;
        }
        return count;
    }
}

