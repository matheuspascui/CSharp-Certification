using System;

public static void Main(string[] args)
{
    //initializing variables - grade assignments
    int currentAssignments = 5;

    int sophia1 = 93;
    int sophia2 = 87;
    int sophia3 = 98;
    int sophia4 = 95;
    int sophia5 = 100;

    int nicolas1 = 80;
    int nicolas2 = 83;
    int nicolas3 = 82;
    int nicolas4 = 88;
    int nicolas5 = 85;

    int zahirah1 = 84;
    int zahirah2 = 96;
    int zahirah3 = 73;
    int zahirah4 = 85;
    int zahirah5 = 79;

    int jeong2 = 92;
    int jeong1 = 90;
    int jeong3 = 98;
    int jeong4 = 100;
    int jeong5 = 97;

    decimal sophiaGrade = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / 5m;
    decimal nicolasGrade = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / 5m;
    decimal zahirahGrade = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / 5m;
    decimal jeongGrade = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / 5m;

    Console.WriteLine("Student\t\tGrade");
    Console.WriteLine($"Sophia\t\t{sophiaGrade}\tA");
    Console.WriteLine($"Nicolas\t\t{nicolasGrade}\tB");
    Console.WriteLine($"Zahirah\t\t{zahirahGrade}\tB");
    Console.WriteLine($"Jeong\t\t{jeongGrade}\tA");

    /*The Microsoft's Solution to the problem was to assign a variable called studentSum for every student.
    After, create a decimal variable to store the division: studentSum / quantityAssignments.
    After, print all student's grades with string concatenation
    */
}