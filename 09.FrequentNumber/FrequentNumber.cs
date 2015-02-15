using System;

//    Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

class FrequentNumber
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            
            int m = 0;
            int currentCount = 1;
            int newCount = 1;
          
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());

           
            }
            Array.Sort(arr);
            for (int i = 0; i < n - 1; i++)
            {
             
                    if (arr[i] == arr[i + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > newCount)
                    {
                        newCount = currentCount;
                        m = arr[i];
                    }
            }
            if (newCount > 1)
            {
                Console.WriteLine("The most frequent number is {0} ({1} times).", m, newCount);
            }
            else
            {
                Console.WriteLine("There aren't any equal elements.");
            }
        }
    }

