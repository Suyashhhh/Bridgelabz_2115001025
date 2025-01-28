 using System;

public class StudentVoteChecker {
    public bool CanStudentVote(int age) {
        if (age < 0) return false;
        return age >= 18;
    }

    public static void Main() {
        StudentVoteChecker checker = new StudentVoteChecker();
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++) {
            ages[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(checker.CanStudentVote(ages[i]) ? "can vote" : "cannot vote");
        }
    }
}

