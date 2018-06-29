using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MycollectionTest
{
    public static class ArrayHelper
    {
        static void Main()
        {
            //Defining Size
            Console.WriteLine("Enter no of records");
            int size = Convert.ToInt16(Console.ReadLine());

            Person[] array = new Person[size];

            //Input Data
            for (int i = 0; i < size; i++)
            {
                if (array[i] == null)
                {
                    Console.Write("Enter User id:");
                    var s = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter Name:");
                    string n = Console.ReadLine();
                    Console.Write("Enter Age:");
                    int A = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter rollNo:");
                    int R = Convert.ToInt16(Console.ReadLine());

                    InputDetails(s, n, A, R, array, i);
                }

                 xprintDetails(array);
            }

            Console.WriteLine("Array is already full");
            Console.ReadLine();
        }

        private static void xprintDetails(Person[] array)
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

        private static void InputDetails(string s, string n, int A, int R, Person[] array, int i)
        {
            Person Pname = new Person();

            Pname.UserId = s;
            Pname.Pname = n;
            Pname.Age = A;
            Pname.RollNo = R;

            //Store value in array 
            array[i] = Pname;
        }

       
    }
}