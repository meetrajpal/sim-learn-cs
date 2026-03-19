using System;
using System.Drawing;
using System.Linq;
using ClassLibrary1;

namespace ConsoleApp1 
{

    class Test
    {
        int totalMarks;
        int marksGained;
        string id = "";

        public Test()
        {
            totalMarks = 100;
            //MainClass.MyEvent("Hello"); // The event 'MainClass.MyEvent' can only appear on the left hand side of += or -= (except when used from within the type 'MainClass')
        }

        public Test(string id) : this()
        {
            this.id = id;
        }

        public Test(int marks, string id) : this(id)
        {
            marksGained = marks;
        }
    }

    interface A
    {
        public void Show()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public void Show()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public void Show()
        {
            Console.WriteLine("C");
        }
    }

    public delegate void MyDelegate(string msg);

    public class MyEventArgs : EventArgs
    {
        required public string Msg { get; set; }
    }

    partial class MainClass
    {
        public static event MyDelegate? MyEvent;

        public static event EventHandler<MyEventArgs>? MyEvent2;

        public static void MyEventMethod(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void MyEventMethod2(object? sender, MyEventArgs obj)
        {
            Console.WriteLine(sender);
            Console.WriteLine(obj.Msg);
        }


        public abstract class Car
        {
            public abstract void Drive();
        }

        class ManualCar : Car
        {
            public override void Drive()
            {
                Console.WriteLine("Driving car manually.");
            }
        }

        class AutoCar : Car
        {
            public override void Drive()
            {
                Console.WriteLine("Driving car auto.");
            }
        }


        public static void DriveCar<T>(T obj) where T : Car
        {
            obj?.Drive();
        }

        static void Main(string[] args)
        {
            //DriveCar<AutoCar>(new AutoCar());
            

            //Class1.Class1Method();

            // ==================== Normal coding ====================
            //Console.Write("Hello, User! Please enter total number of entries you will enter[max allowed 100]: ");

            //int size = Convert.ToInt32(Console.ReadLine());
            //if (size <= 100)
            //{
            //    int[] arr = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter {i + 1} value: ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine("\nThe original entries are: ");

            //    //MyClass obj = new MyClass(); // new()
            //    //obj.PrintArray(arr);
            //    PrintArray(arr);

            //    Console.WriteLine("\nAsscending Sorted entries are: ");
            //    Array.Sort(arr);
            //    PrintArray(arr);

            //    Console.WriteLine("\nDescending Sorted entries are: ");
            //    Array.Reverse(arr);
            //    PrintArray(arr);

            //    Console.WriteLine($"\nMaximum from entries is: {arr.Max()} and minimum from entries is: {arr.Min()}");

            //}
            //else
            //    Console.WriteLine("More than 100 entries are not allowed.");


            // ==================== Constructors ====================
            //Test obj = new Test(85);
            //Console.WriteLine(obj.)


            // ==================== Indexers with Generic Type ====================
            //Console.WriteLine("Select by entering numbers which type of data you want to enter:\n1 Numbers only\n2 Letters");
            //int choice = Convert.ToUInt16(Console.ReadLine());

            //Console.Write("Hello, User! Please enter total number of entries you will enter: ");
            //int size = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        DataStore<int> arr = new DataStore<int>(size);
            //        for (int i = 0; i < size; i++)
            //        {
            //            Console.Write($"Enter {i + 1} value: ");
            //            arr[i] = Convert.ToInt32(Console.ReadLine());
            //        }

            //        Console.WriteLine("\nThe original entries are: ");

            //        arr.PrintItems();

            //        Console.WriteLine("\nAsscending Sorted entries are: ");
            //        arr.Sort();
            //        arr.PrintItems();

            //        Console.WriteLine("\nDescending Sorted entries are: ");
            //        arr.Reverse();
            //        arr.PrintItems();

            //        Console.WriteLine($"\nMaximum from entries is: {arr.Max()} and minimum from entries is: {arr.Min()}");
            //        break;

            //    case 2:
            //        DataStore<string> arr2 = new DataStore<string>(size);
            //        for (int i = 0; i < size; i++)
            //        {
            //            Console.Write($"Enter {i + 1} value: ");
            //            arr2[i] = Console.ReadLine();
            //        }

            //        Console.WriteLine("\nThe original entries are: ");

            //        arr2.PrintItems();

            //        Console.WriteLine("\nAsscending Sorted entries are: ");
            //        arr2.Sort();
            //        arr2.PrintItems();

            //        Console.WriteLine("\nDescending Sorted entries are: ");
            //        arr2.Reverse();
            //        arr2.PrintItems();

            //        //Console.WriteLine($"\nMaximum from entries is: {arr2.Max()} and minimum from entries is: {arr2.Min()}");
            //        break;

            //    default:
            //        Console.WriteLine("You may have entered wrong selection. Enter only numbers 1 or 2.");
            //        break;
            //}


            // ==================== Method Hiding and Overriding ====================
            //A obj = new C();
            //obj.Show();


            // ==================== Extension method for string class ====================
            //string myWord = "Hello User!";
            //int wordCount = myWord.GetWordCount();
            //Console.WriteLine("string : " + myWord);
            //Console.WriteLine("Count : " + wordCount);


            // ==================== Extension method for Array class ====================
            //int[] arr = new int[10
            //Console.WriteLine(arr.MyGetLength());


            // ==================== Delegates and Event ====================
            //MyDelegate delObj = new MyDelegate(MyMethod);
            //delObj?.Invoke("sad");

            //MyEvent += MyEventMethod;
            //MyEvent?.Invoke("hello");

            //MyEvent2 += MyEventMethod2;
            //MyEvent2?.Invoke(new MainClass(), new MyEventArgs() { Msg = "Meet" });

            // ==================== Non Generic Collections ====================
            //NonGenericCollections.ArrayListDemo();

            // ==================== Generic Collections ====================
            //GenericCollections.ListDemo();
            GenericCollections.SortedListDemo();
            Console.ReadKey();
        }
    }
}