using System;
using System.Collections.Generic;

class VotingSystem
{
    Dictionary<string, int> voteCounts = new Dictionary<string, int>();
    SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
    LinkedList<string> voteOrder = new LinkedList<string>();

    public void CastVote(string candidate)
    {
        if (!voteCounts.ContainsKey(candidate))
            voteCounts[candidate] = 0;
        voteCounts[candidate]++;

        sortedResults[candidate] = voteCounts[candidate];

        voteOrder.AddLast(candidate);
    }

    public void DisplayResults()
    {
        Console.WriteLine("Vote Counts:");
        foreach (var kvp in voteCounts)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    public void DisplaySortedResults()
    {
        Console.WriteLine("\nSorted Results:");
        foreach (var kvp in sortedResults)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var candidate in voteOrder)
            Console.Write($"{candidate} -> ");
        Console.WriteLine("End");
    }
}

class Program
{
    static void Main()
    {
        VotingSystem system = new VotingSystem();

        system.CastVote("Alice");
        system.CastVote("Bob");
        system.CastVote("Alice");
        system.CastVote("Charlie");
        system.CastVote("Alice");
        system.CastVote("Bob");

        system.DisplayResults();
        system.DisplaySortedResults();
        system.DisplayVoteOrder();
    }
}
