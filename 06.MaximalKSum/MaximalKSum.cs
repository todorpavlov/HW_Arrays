using System;

//  Problem 6. Maximal K sum

//  Write a program that reads two integer numbers N and K and an array of N elements from the console.
//  Find in the array those K elements that have maximal sum.

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter the number of the array's elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] array1 = new int[n];

        Console.Write("Enter how many numbers you want to calculate: ");
        int k = int.Parse(Console.ReadLine());

        int sum = 0;

        if (k > n)
        {
            Console.WriteLine("This number can't be greater than the elements!");
        }
        else
        {
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                array1[index] = int.Parse(Console.ReadLine());
                
            }
            Array.Sort(array1);
            Array.Reverse(array1);
            for (int i = 0; i < k; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}