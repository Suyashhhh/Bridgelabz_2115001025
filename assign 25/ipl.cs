using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

class IPLMatch
{
    public int MatchId { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public Dictionary<string, int> Score { get; set; }
    public string Winner { get; set; }
    public string PlayerOfMatch { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            string jsonPath = "ipl_matches.json";
            string csvPath = "ipl_matches.csv";
            string outputJsonPath = "ipl_matches_censored.json";
            string outputCsvPath = "ipl_matches_censored.csv";

            List<IPLMatch> matches = ReadJson(jsonPath);
            matches.AddRange(ReadCsv(csvPath));

            List<IPLMatch> censoredMatches = ApplyCensorship(matches);

            WriteJson(outputJsonPath, censoredMatches);
            WriteCsv(outputCsvPath, censoredMatches);

            Console.WriteLine("Censorship applied. Files saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static List<IPLMatch> ReadJson(string filePath)
    {
        if (!File.Exists(filePath)) return new List<IPLMatch>();

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<IPLMatch>>(json) ?? new List<IPLMatch>();
    }

    static List<IPLMatch> ReadCsv(string filePath)
    {
        if (!File.Exists(filePath)) return new List<IPLMatch>();

        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<IPLMatch>().ToList();
    }

    static List<IPLMatch> ApplyCensorship(List<IPLMatch> matches)
    {
        foreach (var match in matches)
        {
            match.Team1 = MaskTeamName(match.Team1);
            match.Team2 = MaskTeamName(match.Team2);
            match.Winner = MaskTeamName(match.Winner);
            match.PlayerOfMatch = "REDACTED";

            var newScore = new Dictionary<string, int>();
            foreach (var entry in match.Score)
                newScore[MaskTeamName(entry.Key)] = entry.Value;

            match.Score = newScore;
        }
        return matches;
    }

    static string MaskTeamName(string team)
    {
        var words = team.Split(' ');
        if (words.Length > 1) words[1] = "***";
        return string.Join(" ", words);
    }

    static void WriteJson(string filePath, List<IPLMatch> matches)
    {
        string json = JsonConvert.SerializeObject(matches, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    static void WriteCsv(string filePath, List<IPLMatch> matches)
    {
        using var writer = new StreamWriter(filePath);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(matches);
    }
}
