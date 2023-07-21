/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/
using System.Collections.Generic;
using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // Create an instance of LargeDataCollection
        var largeCollection = new LargeDataCollection(new List<int> { 1, 2, 3, 4, 5 });
        try
        {
        start:
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add element");
            Console.WriteLine("2. Remove element");
            Console.WriteLine("3. Access element");
            Console.WriteLine("4. Display elements");
            Console.Write("Your choice: ");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    {
                        Console.WriteLine("Enter element to add");
                        int addele = int.Parse(Console.ReadLine());
                        largeCollection.Add(addele);
                        largeCollection.Add(6);
                        largeCollection.Add(7);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Enter index of element to remove");
                        int remove = int.Parse(Console.ReadLine());
                        largeCollection.Remove(remove);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Enter searching index");
                        int ele = int.Parse(Console.ReadLine());
                        int element = largeCollection.GetElementAt(ele);
                        Console.WriteLine($"Element at index {ele} : " + element);
                        break;
                    }
                case "4": largeCollection.Display(); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
            Console.WriteLine("Do you want to continue : Enter 1");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                goto start;
            }
            else { Console.WriteLine("End of program"); }
        }catch (Exception ex) { Console.WriteLine(ex.Message); }
        // Accessing an element in the collection
       /* Console.WriteLine("Enter searching index");
        int ele=int.Parse(Console.ReadLine());
        int element = largeCollection.GetElementAt(ele);
        Console.WriteLine($"Element at index {ele} : " + element);*/

        // Adding elements to the collection
       /* Console.WriteLine("Enter element to add");
        int addele = int.Parse(Console.ReadLine());
        largeCollection.Add(addele);
        largeCollection.Add(6);
        largeCollection.Add(7);*/

        // Removing an element from the collection
        /*Console.WriteLine("Enter index of element to remove");
        int remove=int.Parse(Console.ReadLine());
        largeCollection.Remove(remove);*/
        //Display item
        //largeCollection.Display();
        // Dispose the LargeDataCollection object to release resources
        largeCollection.Dispose();
        Console.ReadKey();
    }
}