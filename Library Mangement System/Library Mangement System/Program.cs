namespace Library_Mangement_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("Welcome to Library_Mangement_System");
            Console.WriteLine("Are you librarian OR user (l/U) ");

            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                Console.WriteLine("Welcome librarian , enter your name");
                string librarianName = Console.ReadLine();

                Liberian l1 = new Liberian(librarianName);

                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please enter to Add book (A) OR Remove book (R) OR display (D)");

                    char userOption = Console.ReadLine().ToUpper()[0];

                    switch (userOption)
                    {
                        case 'A':
                            Console.WriteLine("Enter Book definition");
                            string bookTitle = Console.ReadLine();
                            string author = Console.ReadLine();
                            int year = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = bookTitle,
                                Author = author,
                                Year = year

                            };
                            l1.AddBook(book, library);

                            break;

                        case 'R':
                            Console.WriteLine("Enter Book definition");
                            bookTitle = Console.ReadLine();
                            author = Console.ReadLine();
                            year = int.Parse(Console.ReadLine());

                            book = new Book()
                            {
                                Title = bookTitle,
                                Author = author,
                                Year = year

                            };
                            l1.RemoveBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("the Book list : ");
                            l1.DisplayBooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            else if (userType == 'U')
            {

                Console.WriteLine("Welcome User , enter your name");
                string Name = Console.ReadLine();

                LibraryUser U1 = new LibraryUser(Name);

                Console.WriteLine($"Welcome {U1.Name}");
                while (true)
                {
                    Console.WriteLine("Please enter to display (D) OR Borrow (B)");

                    char userOption = Console.ReadLine().ToUpper()[0];


                    switch (userOption)
                    {
                        

                        case 'B':
                            Console.WriteLine("Enter Book definition to Borrow");
                            string bookTitle = Console.ReadLine();
                            string author = Console.ReadLine();
                            int  year = int.Parse(Console.ReadLine());

                           Book book = new Book()
                            {
                                Title = bookTitle,
                                Author = author,
                                Year = year

                            };
                            U1.BorrowBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("the Book list : ");
                            U1.DisplayBooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}