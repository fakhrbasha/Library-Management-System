namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Library System");

            Library library = new Library();

            Console.WriteLine("Are You Librarian Or Regular User (L/R) ");
            var userType=Console.ReadLine().ToUpper()[0]; // [0] need the first char

            
                if (userType == 'L')
                {
                    Console.WriteLine("Welcome Librarian , Enter Your Name");

                    string libName = Console.ReadLine();

                    Libraryin l1 = new Libraryin(libName);
                    Console.WriteLine($"Welcome  {l1.Name}");
                    while (true)
                    {
                        Console.WriteLine("Please Choose to Add book (A) / Remove book (R) / Display book (D)");

                        char choise = Console.ReadLine().ToUpper()[0];
                        switch (choise)
                        {
                            case 'A':
                                Console.WriteLine("Enter Book Detalis");
                                Console.Write("Book Name : ");
                                string bookName = Console.ReadLine();
                                Console.Write("Book Auther : ");
                                string bookAuther = Console.ReadLine();
                                Console.Write("Book Year : ");
                                int bookYear = Convert.ToInt32(Console.ReadLine());
                                Book book = new Book()
                                {
                                    Title = bookName,
                                    Auther = bookAuther,
                                    Year = bookYear,
                                };

                                l1.AddBook(book, library);
                                break;
                            case 'R':
                                Console.WriteLine("Enter Book Detalis To Remove");
                                Console.Write("Book Name : ");
                                bookName = Console.ReadLine();
                                Console.Write("Book Auther : ");
                                bookAuther = Console.ReadLine();
                                Console.Write("Book Year : ");
                                bookYear = Convert.ToInt32(Console.ReadLine());
                                book = new Book()
                                {
                                    Title = bookName,
                                    Auther = bookAuther,
                                    Year = bookYear,
                                };

                                l1.RemoveBook(book, library);
                                break;
                            case 'D':
                                Console.WriteLine("The Book list : ");
                                l1.DisplayBook(library);
                                break;
                            default:
                                Environment.Exit(0);
                                break;


                        }
                    }
                    

                }

                else if (userType == 'R')
                {
                    Console.WriteLine("Welcome User , Enter Your Name");

                    string name = Console.ReadLine();

                    Library_User u1 = new Library_User(name);
                    Console.WriteLine($"Welcome  {u1.Name}");

                while (true)
                {
                    Console.WriteLine("Please Choose to Display book (D) / Borrow Book (B)");

                    char choise = Console.ReadLine().ToUpper()[0];
                    switch (choise)
                    {
                        case 'B':
                            Console.WriteLine("Enter Book Detalis");
                            Console.Write("Book Name : ");
                            string bookName = Console.ReadLine();
                            Console.Write("Book Auther : ");
                            string bookAuther = Console.ReadLine();
                            Console.Write("Book Year : ");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Auther = bookAuther,
                                Year = bookYear,
                            };
                            u1.BorrowBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The Book list : ");
                            u1.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;


                    }
                }
            }
                else
                {
                    Console.WriteLine("Please Enter Correct Value (L/R)");
                }
            

        }
    }
}
