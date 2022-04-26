using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    interface IBook
    {
        string this[int index] { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        string ISBN { get; set; }
        int Year { get; set; }
        void Show();

    }

    class Book : IBook, IComparable<Book>
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        private ArrayList chapter = new ArrayList();

        public int CompareTo(Book other)
        {
            return this.title.CompareTo(other.title);
        }
        public string this[int index] {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            } 
        }

        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ISBN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("--------------------------");

        }

        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Input chapter (finshish whit empty string) ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);

        }

    }
    class BookList
    {
        private List<Book> list = new List<Book>();
        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void ShowList()
        {

            list.Sort();
            foreach (Book b in list)
                b.Show();   
        }
        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while(n> 0)
            {
                AddBook();
                n--;
            }
        }
    }
   
    class Program
    {
        static void Main(string[] arg)
        {
            BookList bl = new BookList();
            bl.InputList();
            bl.ShowList();
            
            Console.ReadLine();
            
        }
    }
}
