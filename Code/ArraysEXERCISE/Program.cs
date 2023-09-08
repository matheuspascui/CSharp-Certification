using System;
public class ArraysEXERCISE
{
    public static void Main(string[] args)
    {
        //This exercise uses arrays to store and retrieve data to simulate a store department looking for fraudulent orders
        /* using string[] we tell the compiler that the variable fraudulentOrders will be an array of strings,
        but the second pair of brackets is the one that tells the number of elements that this array will hold 
        (in this case, 3 strings). */
        string[] fraudulentOrdersID = new string[3];
        fraudulentOrdersID[0] = "A123";
        fraudulentOrdersID[1] = "B456";
        fraudulentOrdersID[2] = "C789";
        //attempting to access an invalid index, the 4th position, that does not exist
        //it will build, but not run. Throw error "IndexOutOfRange" - index was outside bounds of the array
        fraudulentOrdersID[3] = "D000";

    }
}