namespace LibraryManagement
{
    public class Bookchild : bookfunctions
    {
        static List<BookManagement> bookList = new List<BookManagement>();
            
        public int bookId;
        public string bookName;
        public string bookType;
                
        public string updatename;

        public string orignalname;
        public void GetBook()
        {
            BookManagement book = new BookManagement();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Type:");
            book.bookType = Console.ReadLine();
            bookList.Add(book);
        }
        
        public void RemoveBook()
        {
            BookManagement book = new BookManagement();
            Console.Write("Enter Book id to be deleted : ");
            int Del = int.Parse(Console.ReadLine());
            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }
            bookList.Add(book);
        }
                                
        public void SearchBook() 
        {
            BookManagement book = new BookManagement();
            Console.WriteLine("1 - search by id or 2 - search by name");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.Write("Search by BOOK id :");
                int ids = int.Parse(Console.ReadLine());
                SearchBookbyid(ids);
            }
            else if (a == 2)
            {
                Console.WriteLine("enter the  book name ");
                string name = Console.ReadLine();
                SearchBook(name);
            }
            else{
                Console.WriteLine("wrong input");
            }            
        }
                                        
        public void SearchBookbyid(int find)
        {
            BookManagement book = new BookManagement();
            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (BookManagement searchId in bookList)
                {
                    if (searchId.bookId == find)
                        {
                            Console.WriteLine("Book id :{0}\n" +
                                            "Book name :{1}\n" +
                                            "Book type :{2} "
                                            , searchId.bookId, searchId.bookName, searchId.bookType);
                        }
                                        
                }
                        
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void SearchBook(string nametofind)
        {
            BookManagement book = new BookManagement();
            if(bookList.Exists(x => x.bookName == nametofind))
            {
                foreach (BookManagement searchId in bookList)
                {
                    if(searchId.bookName == nametofind)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                                        "Book name :{1}\n" +
                                        "Book type :{2} "
                                        , searchId.bookId, searchId.bookName, searchId.bookType);
                    }    
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void updatebook()
        {
            BookManagement book = new BookManagement();
            Console.Write("enter the  book Id which has to be updated :");
            int find = int.Parse(Console.ReadLine());
            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (BookManagement searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("enter the original book name ");
                        book.orignalname = Console.ReadLine();
                        Console.WriteLine("enter the updated book name ");
                        book.updatename = Console.ReadLine();
                        foreach (var Book in bookList.Where( w => w.bookName == book.orignalname)) 
                        {
                            Book.bookName = book.updatename;
                        }

                        Console.WriteLine("Updated Book Name is\n"+
                                        "Book id :{0}\n" +
                                        "Book name :{1}\n" +
                                        "Book type :{2}\n" 
                                        , searchId.bookId, book.updatename, searchId.bookType);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }

        }


        public void BookList()
        {
            BookManagement book = new BookManagement();
            Console.Write("Here is list of Books : ");
            foreach (BookManagement bookID in bookList)
            {
                Console.WriteLine("Book id :{0}\n" +
                                "Book name :{1}\n"+
                                "Book type :{2}\n", bookID.bookId, bookID.bookName,bookID.bookType);   
            } 
        }   
    }
}
        

