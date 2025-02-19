using System;
using System.Collections.Generic;

class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; }
    public string CoverageType { get; }
    public DateTime ExpiryDate { get; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(Policy other) => ExpiryDate.CompareTo(other.ExpiryDate);

    public override bool Equals(object obj) => obj is Policy p && PolicyNumber == p.PolicyNumber;
    public override int GetHashCode() => PolicyNumber.GetHashCode();
    
    public override string ToString() => $"{PolicyNumber} ({CoverageType}) - Expires: {ExpiryDate:yyyy-MM-dd}";
}

class InsurancePolicySystem
{
    HashSet<Policy> uniquePolicies = new HashSet<Policy>();
    LinkedList<Policy> orderedPolicies = new LinkedList<Policy>();
    SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>();
    Dictionary<string, List<Policy>> coverageMap = new Dictionary<string, List<Policy>>();
    Dictionary<string, int> policyCount = new Dictionary<string, int>();

    public void AddPolicy(Policy policy)
    {
        if (!uniquePolicies.Add(policy))
            policyCount[policy.PolicyNumber] = policyCount.ContainsKey(policy.PolicyNumber) ? policyCount[policy.PolicyNumber] + 1 : 2;
        else
        {
            orderedPolicies.AddLast(policy);
            sortedByExpiry.Add(policy);
            if (!coverageMap.ContainsKey(policy.CoverageType))
                coverageMap[policy.CoverageType] = new List<Policy>();
            coverageMap[policy.CoverageType].Add(policy);
        }
    }

    public List<Policy> GetAllPolicies() => new List<Policy>(uniquePolicies);
    public List<Policy> GetExpiringSoon()
    {
        DateTime today = DateTime.Today;
        return new List<Policy>(sortedByExpiry.GetViewBetween(new Policy("", "", today), new Policy("", "", today.AddDays(30))));
    }
    public List<Policy> GetPoliciesByCoverage(string coverageType) => coverageMap.ContainsKey(coverageType) ? coverageMap[coverageType] : new List<Policy>();
    public List<string> GetDuplicatePolicies() => new List<string>(policyCount.Keys);
}

class Program
{
    static void Main()
    {
        InsurancePolicySystem system = new InsurancePolicySystem();
        
        system.AddPolicy(new Policy("P001", "Health", DateTime.Today.AddDays(10)));
        system.AddPolicy(new Policy("P002", "Auto", DateTime.Today.AddDays(25)));
        system.AddPolicy(new Policy("P003", "Home", DateTime.Today.AddDays(50)));
        system.AddPolicy(new Policy("P001", "Health", DateTime.Today.AddDays(10))); // Duplicate

        Console.WriteLine("All Policies:");
        foreach (var p in system.GetAllPolicies()) Console.WriteLine(p);

        Console.WriteLine("\nExpiring Soon:");
        foreach (var p in system.GetExpiringSoon()) Console.WriteLine(p);

        Console.WriteLine("\nHealth Policies:");
        foreach (var p in system.GetPoliciesByCoverage("Health")) Console.WriteLine(p);

        Console.WriteLine("\nDuplicate Policies:");
        foreach (var p in system.GetDuplicatePolicies()) Console.WriteLine(p);
    }
}
