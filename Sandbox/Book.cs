using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public enum GenreType {Fantasy, Thriller, Crime}
    public class Book
    {
        //instance fields - gemmer tilstanden over tid
        private string _titel;
        private string _isbn;
        private string _author;
        private GenreType _genre;

        //constructor - bruges til at initialisere et objekt
        public Book(string titel, string isbn, string author, GenreType genre)
        {
            _titel = titel;
            _isbn = isbn;
            _author = author;
            _genre = genre;
        }

        public GenreType Genre
        {
            get { return _genre; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Isbn
        {
            get { return _isbn; }
        }

        public string Author
        {
            get { return _author; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Titel {_titel  } ISBN {_isbn} Author {_author}");
        }

        public override string ToString()
        {
            return $"Titel {_titel  } ISBN {_isbn} Author {_author} Genre {_genre}";
        }
    }
}
