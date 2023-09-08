## Adding Logic to programs

Here we will add logic through `if`, `else` and `Else If` statements in C#.

The `if` statement evaluates a Boolean expression within parentheses. If the condition is true, then the code within the `if` is executed.

In the MS Tutorial to the If Else, i'll build a game with 3 "dices".

To follow the program:

- Created an Instance of the Random Class to a new Object called `dice`
- called the method .Next() 3 times, storing each value in a variable (`roll1, roll2, roll3`). **NOTE**: in the calling of the .Next() method, i'm passing 2 arguments to it. The lower boundary (1) and the upper boundary (7). The 7 is an exclusive boundary, meaning that the numbers are picked until 7 and it is not included, thus it simulates rolling a dice (1 to 6).
- create a `total` variable to store the sum of the 3 rolls
- Printing on the console each "dice" value and the total
- `if` statement. If statements start with the `if` keyword followed by the condition, a Boolean expression, inside the parentheses and within curly brackets goes the code in case the Boolean expression is true.

### Boolean Expression

A **Boolean Expression** is an expression which has value `true` or `false`. If a code returns these values, it is a boolean expression. Alternatively, a method for strings, the `string.Contains()` can return a boolean value if some string has a matching string inside. Example:
```C#
string message = "Hy! My name is Matheus and I'm from Brazil.";
bool Result = message.Contains("name");
```

Because the result of the `string.Contains()` method is a boolean, it can be used inside an if expression, inside the parentheses.

### Back to the Game

So, the rules of the game are: 
- we roll the dices and sum the total. If the total is greater than an arbitrary number, let's say 15, the user wins, if not greater thatn 15, it loses. But:
- If any 2 dices return the same value, user gets 2 bonus points
- If the 3 dices return the same value, user gets 6 bonus points
- If the sum of the 3 dices PLUS the bonuses (if exists) is greater than 15, user wins

Now, changing the last `if` by an `else`, because everything that don't fit into the conditions stablished before, will be a lost for the user.

To prevent that both bonuses are awarded to the user, we'll nest an if inside other if. Nesting the if for triples inside the if for doubles.

After refactoring the code to put the else, add code to give prizes instead of a Win-Lose message.

The new "rules" are: 
- If player scores >=16, win CAR
- if score >=10 win laptop
- If score == 7, win a trip
- Else wins a kitten

Remember to use as many `if - else if` conditions depending on how many options do you want.

:arrow_right::arrow_right:As a **FINAL EXERCISE**, MS Course asks to build an application that will inform users of a subscription service that their subscription is ending, and will provide some options to renewal. This will be the project **"RenewalSubscriptions"**.:arrow_left::arrow_left:

