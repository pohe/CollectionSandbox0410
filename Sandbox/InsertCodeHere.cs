using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> myFirstList = new List<int>();
            myFirstList.Add(123);
            myFirstList.Add(124);//tilføjer i slutning af listen
            myFirstList.Insert(1,125); //indsætter på en specifik position, de andre rykkes
            myFirstList[1] = 126; //overskriver
            myFirstList.Add(128);
            myFirstList.Add(129);
           
            myFirstList.RemoveAt(2);

            bool removed = myFirstList.Remove(126);
            Console.WriteLine($"Fik fjernet 126 {removed}");
            Console.WriteLine(myFirstList[1]);

            Console.WriteLine("Udskrivning af liste vha foreach");
            foreach (int i in myFirstList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Udskrivning af liste vha while");
            int j = 0;
            while (j <myFirstList.Count)
            {
                Console.WriteLine( myFirstList[j] );
                j++;
            }


            Console.WriteLine("Hello world!");


            List<Book> myBookList = new List<Book>(){ new Book("Pascal book", "121331", "Peter Pascal"), new Book("C++ book", "121331", "Peter Plus") };

            Book aBook = new Book("C# programming", "1212132", "John Sharp");

            myBookList.Add(aBook);
            myBookList.Add(new Book("Scrum book", "121331", "Peter Scrum"));


            

            // The LAST line of code should be ABOVE this line
        }
    }
}