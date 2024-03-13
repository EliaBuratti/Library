namespace Library
{
    internal class Program
    {
        static string Title;
        static string Author;
        static string Publisher;
        static int Year;
        static int Rack;
        static int Floor;
        static bool ConfirmChoice;
        static int Counter = 0;

        static Book[] Books = new Book[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int choice;
            bool inputCheck = false;
            string BookTitle;

            do
            {
                try
                {
                    Console.WriteLine("Choose options:\n1 Insert book.\n2 Search Book by title.\n3 Search by author.\n4 exit.");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            AddBook();
                            RegisterData();
                            break;

                        case 2:

                            /*  
                             *  print all books
                             *  
                             *  foreach(Book singlebook in Books)

                            if (singlebook != null)
                            {
                             Console.WriteLine(Books[i].PrintBooks());                                    
                            }
                            */

                            // search book by title
                            Console.WriteLine("Type a book title:");
                            BookTitle = Console.ReadLine().ToLower();

                            for (int i = 0; i < Books.Length; i++)
                            {
                                if (Books[i] != null && Books[i].SearchTitle(BookTitle))
                                {
                                    Console.WriteLine(Books[i].PrintBooks());                                    
                                }
                            }

                            break;

                        case 3:
                            //class search author

                            Console.WriteLine("Type an author name:");
                            BookTitle = Console.ReadLine().ToLower();

                            for (int i = 0; i < Books.Length; i++)
                            {
                                if (Books[i] != null && Books[i].SearchAuthor(BookTitle))
                                {
                                    Console.WriteLine(Books[i].PrintBooks());
                                }
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exit.");
                            inputCheck = true;
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            } while (!inputCheck);
        }

        public static void AddBook()
        {
            Console.WriteLine("Title:");
            Title = Console.ReadLine();

            Console.WriteLine("Author:");
            Author = Console.ReadLine();

            Console.WriteLine("Publisher:");
            Publisher = Console.ReadLine();

            Console.WriteLine("Year:");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rack:");
            Rack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Floor:");
            Floor = Convert.ToInt32(Console.ReadLine());

            
        }

        static public void RegisterData()
        {
            Console.WriteLine("Do you want to save the data? (Y/N)");
            ConfirmChoice = Console.ReadLine().ToLower() == "y" ? true : false;

            if (ConfirmChoice)
            {
                Books[Counter] = new Book(Title, Author, Publisher, Year, Rack, Floor);
                Counter++;
                Console.WriteLine("Book registered!");
            }
            else
            {
                Console.WriteLine("Book not registered.\n");
            }
        }

    }
}
