/* This code simulates a dice roll using Random.Next() method to generate a number, and Console.WriteLine() method to output
the result.*/

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


/* OBS: Attention to the fact that i call the methods Console.WriteLine and Random.Next() in different ways. WHY?
Because some methods are STATEFUL and others are STATELESS.*/