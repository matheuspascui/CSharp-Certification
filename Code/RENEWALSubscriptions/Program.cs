public class RENEWALSubscriptions
{
    public static void Main(string[] args)
    {
        /* The first portion will generate a random number between 0 - 11. This will be days until expiration.
        Discount % is initialized as 0.
        Rules:
        1) Code should display only 1 message
        2) If expire date is 10 or less days, display the first message.
        3) If expire date is 5 or less days, display 2nd msg with daysUntilExp. displayed.
        4) If expire date is in 1 day, message 3, 20% discount
        5) If subscription is expired, display expired
        6) If expireDate is more than 10 days, display NOTHING */
        
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if ((daysUntilExpiration <=10) && (daysUntilExpiration > 5))
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if ((daysUntilExpiration <=5) && (daysUntilExpiration > 1))
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
        }
        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else
        {
            Console.WriteLine("");
        }

        /* MICROSOFT SOLUTION (i forgot to use variable discountPercentage an implemented all using strings):
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
        */

    }
}