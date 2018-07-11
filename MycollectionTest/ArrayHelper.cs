using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MycollectionTest
{
    public class ArrayHelper
    {
        static Person[] array;
        static int size;
        
        public static void Main()
        {
            size = getsize();
            intializer(size);
            insertDetails();
            printDetails(array);
        }


        public static void intializer(int size)
        {
            array = new Person[size];
        }

        public static int getsize()
        {
            Console.WriteLine("Enter no of records");
            size = Convert.ToInt16(Console.ReadLine());
            return size;
        }

        public static void insertDetails()
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == null)
                {
                    Console.Write("Enter User id:");
                    var userId = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter rollNo:");
                    int rollNo = Convert.ToInt32(Console.ReadLine());

                    InputDetailsInArray(userId, name, age, rollNo, array, i);
                }
            }
            Console.WriteLine("Array is already full");
            Console.ReadLine();
        }

        public static void InputDetailsInArray(string userId, string name, int age, int rollNo, Person[] array, int i)
        {
            Person det = new Person();
            det.UserId = userId;
            det.Pname = name;
            det.Age = age;
            det.RollNo = rollNo;

            //Store value in array 
            array[i] = det;
        }

        public static void printDetails(Person[] array)
        {
            var list = array.ToList();

            foreach (var value in list)
            {
                Console.WriteLine(value.UserId);
                Console.WriteLine(value.Pname);
                Console.WriteLine(value.Age);
                Console.WriteLine(value.RollNo);
            }
        }

    }
}