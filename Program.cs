using System;
public class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string[] Town = new string[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write("Input Town name:");
            Town[i] = Console.ReadLine();
            int NumberOfClosedTown = int.Parse(Console.ReadLine());
            closedTown(NumberOfClosedTown, i, number);
        }
        for (int i = 0; i < number; i++){
        int Covid = 0;
        Console.WriteLine("{0} {1} {2}", i,Town[i],Covid);    
        }
        
    }

    static void closedTown(int number, int Town, int total)
    {
        int[] closedTown = new int[number];
        for (int i = 0; i < number; i++)
        {
            int ClosedTown = int.Parse(Console.ReadLine());
            if (CheckAll(ClosedTown,total,Town))
            {
                closedTown[i] = ClosedTown;
                if (i > 0){
                    for(int j = i-1; j >= 0; j--){
                    closedTown[i] = CheckSame(ClosedTown, closedTown[j]);
                    }
                }
                
            }
            else {
                i--;
            }
        }

        static int CheckSame(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Invalid ID");
                a = int.Parse(Console.ReadLine());
                int c = CheckSame(a, b);
                return c;
            }
            return a;
        }
        static bool CheckAll(int closed, int number, int Town)
        {
            if (closed < number)
            {
                if (closed != Town)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid ID");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid ID");
                return false;
            }
        }
    }
}