using System;

public class 
{
    public static void Main(string[] args)
    {
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;
        int leadingDigit = (int) gradePointAverage; //casting the integer part of GPA
        int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);//gets the 2 decimal digits of GPA

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
        Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
        Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");
        /* The number of \t or tabs is different because the tab adds 4 spaces each one. If the word has more space, the tab adds 2 spaces because the rest is the
        space of the word, for example. To see this, count the characters and see the strings moving adding or deleting tabs*/
    }
}