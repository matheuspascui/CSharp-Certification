using System;

public class GameIFELSE 
{
    public  static void Main(string[] args)
    {
        /* The Game Rules are: the user rolls the 3 dices.
        - If the sum of the dices is greater than 15, you win!
        - If 2 dices return the same value, you get 2 bonus points
        - If all 3 dices return the same value, you get 6 bonus points
        - If the sum of the dices plus the bonus points is greater than or equal to 15, you win! Otherwise, you lose!*/

        Random  dice = new Random();
        int roll1 = dice.Next(1,7);
        int roll2 = dice.Next(1,7);
        int roll3 = dice.Next(1,7);

        roll1 = 6;
        roll2 = 6;
        roll3 = 6;
        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 Bonus Points to the total");
                total +=6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 Bonus Points to the total");
                total +=2;
            }
        }

        Console.WriteLine($"Total: {total}");

        if (total >= 16)
        {
            Console.WriteLine("Congrats! You win a new CAR!!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("Congrats! You win a Laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("Congrats! You win a Trip!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
        
    }
}