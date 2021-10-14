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
            myFirstList.Insert(1, 125); //indsætter på en specifik position, de andre rykkes
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
            while (j < myFirstList.Count)
            {
                Console.WriteLine(myFirstList[j]);
                j++;
            }

            



            //Console.WriteLine("Hello world!");


            //List<Book> myBookList = new List<Book>(){ new Book("Pascal book", "121331", "Peter Pascal"), new Book("C++ book", "121331", "Peter Plus") };

            //Book aBook = new Book("C# programming", "1212132", "John Sharp");

            //myBookList.Add(aBook);
            //myBookList.Add(new Book("Scrum book", "121331", "Peter Scrum"));

            //List<string> names = new List<string>() {"Mikkel", "Emil"};
            //names.Add("Hannibal");
            //names.Insert(1, "Poul");

            //Console.WriteLine("Names udskrevet forfra");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            ////0     , 1    , 2   ,3
            ////Mikkel, Poul, Emil, Hannibal 

            //Console.WriteLine("Names udskrevet bagfra");
            //for( int c = names.Count-1;c > -1; c--)
            //{
            //    Console.WriteLine(names[c]);
            //}

            Dictionary<int, Player> players = new Dictionary<int, Player>();
            Player p1 = new Player(1, "Emil", "vej 123");
            Player p2 = new Player(2, "Mikkel", "gade 123");
            players.Add(p1.Id, p1);
            players.Add(p2.Id, p2);
            players.Add(3, new Player(3, "Hannibal", "Alleen 5"));

            Console.WriteLine("Udskrevet key ");
            foreach (var playerKeyValue in players)
            {
                //Console.WriteLine(playerKeyValue.ToString());
                Console.WriteLine(playerKeyValue.Key);
            }

            Console.WriteLine("Udskrift af values");
            foreach (Player playersValue in players.Values)
            {
                Console.WriteLine(playersValue);
            }

            Player p = players[3];
            Console.WriteLine($"Udskrift af player med key 3 {p}");

            players.Remove(2);
            Console.WriteLine("Udskrift af values efter remove med key 2");
            foreach (Player playersValue in players.Values)
            {
                Console.WriteLine(playersValue);
            }

            if (players.ContainsKey(5))
            {
                Player p5 = players[5];
                Console.WriteLine($"Udskrift af player med key 5 {p}");
            }
            else
            {
                Console.WriteLine("Indeholder ikke en player med key 5");
            }

            bool removedPlayer5 = players.Remove(5);
            if (removedPlayer5)
            {
                Console.WriteLine("Player med key 5 er fjernet");
            }
            else
            {
                Console.WriteLine("Player med key 5 kunne ikke fjernes");
            }

            Dictionary<string, Player> dictionaryByName = new Dictionary<string, Player>();
            dictionaryByName.Add(p1.Name, p1);
            dictionaryByName.Add(p2.Name, p2);
            Console.WriteLine("Udskrevet mikkel fra dictionaryByName");
            if (dictionaryByName.ContainsKey("mikkel"))
            {
                Player p6 = dictionaryByName["mikkel"];
                Console.WriteLine(p6.ToString());
            }
            else
            {
                Console.WriteLine("Der findes ikke en med key mikkel");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}