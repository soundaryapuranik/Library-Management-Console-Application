using NUnit;
using NUnit.Framework;
using LibraryManagement;

namespace bookManagement{
[TestFixture]
public class testcases : BookManagement
{
    BookManagement b=new BookManagement();

    [Test]
    public void test1()
    { 
        List<BookManagement> bookList = new List<BookManagement>();
        bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
        bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );
        CollectionAssert.AllItemsAreUnique(bookList);
    }

    [Test]
    public void test2()
        {   
            Boolean z = false;
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );  
            String myString = "Mahesh Chand";
            foreach (BookManagement searchId in bookList)
            {
                if(searchId.bookName == myString)
                {
                    z = true;
                }    
            }
            Assert.AreEqual(z,true);
        }


        [Test]
        public void test3()
        {   
            Boolean z = false;
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );
            int myString = 4;
            foreach (BookManagement searchId in bookList)
            {
                if(searchId.bookId == myString)
                {
                    z = true;
                }    
            }
            Assert.AreEqual(z,true);
        }

        [Test]
        public void test4()
        {
            Boolean z = false;
            int myString = 12;
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );

            var found = bookList.FirstOrDefault(c => c.bookId == 2);
            found.bookId = 5;
            foreach (BookManagement searchId in bookList)
            {
                if(searchId.bookId == myString)
                {
                     z = true;
                }      
            }
            Assert.AreEqual(z,true);
        }

        [Test]
        public void test5()
        {
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );
            CollectionAssert.Contains(bookList, "Mah");  
        }

        [Test]
        public void test6()
        {
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );
            CollectionAssert.DoesNotContain(bookList, "x");  
        }

        [Test]
        public void test7()
        {
            List<BookManagement> bookList = new List<BookManagement>();
            bookList.Add(new BookManagement { bookName = "Mahesh Chand", bookId = 3 , bookType = "abc" });
            bookList.Add(new BookManagement { bookName = "Neel Beniwal", bookId = 2, bookType = "abc" } );
            CollectionAssert.AllItemsAreNotNull(bookList);  
        }
    }    
}