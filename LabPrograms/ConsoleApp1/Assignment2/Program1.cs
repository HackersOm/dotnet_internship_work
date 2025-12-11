using System.Linq.Expressions;

namespace Assignment2
{


    internal class Program1
    {
        
        
        public static void Main1(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book{Id = 1,Title = "let's C ",Author = "Joshua Bloch",Price = 2000},
                new Book{Id = 2,Title = "Clean Code",Author = "Robert C. Martin",Price = 1000},
                new Book{Id = 3,Title = "Chip War",Author = "Chris Miller",Price = 5000},
                new Book{Id = 4,Title = "The Innovators",Author = "Walter Isaacson",Price = 200},
                new Book{Id = 5,Title = "Atlas of AI",Author = "Anish Bloch",Price = 100},
                new Book{Id = 6,Title = "Code",Author = "Aditya Surayakar",Price = 2100},
                new Book{Id = 7,Title = "The Machine Is Learning",Author = "Anurag Londe",Price =6000},
                new Book{Id = 8,Title = "Quantum Nation",Author = "L. Venkata Subramaniam",Price = 3000},
                new Book{Id = 9,Title = "Designing Data",Author = "Martin Kleppmann",Price = 9000},
                new Book{Id = 10,Title = "DSA",Author = "Mark Allen Weiss",Price = 95000}
            };

            Console.WriteLine("\n\nDisplaying all record by ascending order of price\n");
          books.Sort((x,y)=> x.Price.CompareTo(y.Price));
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\n\nDisplaying All records that contains a \n");
            foreach(Book book in books)
            {
                if (book.Author.ToLower().Contains('a')) 
                    Console.WriteLine(book);
            }

            Console.WriteLine("Delete record that spacified by User");
            Console.WriteLine("Enter Id");
            int val = int.Parse(Console.ReadLine());


            Book bookToRemove = books.Find(x => x.Id == val);
            if(bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Successfull");
            }
            else
                Console.WriteLine("Failed");

            books.ForEach(x => Console.WriteLine(x));

        }
    }

    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return "Price : "+ Price+"| Id : " + Id +"| Author : "+Author+ "| Title : " + Title;
        }
    }
}
