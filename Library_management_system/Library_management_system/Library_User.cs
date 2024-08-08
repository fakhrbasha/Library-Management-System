using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Library_User : User
    {
        public Library_Card Card { get; set; }
        public Library_User(string name)
        {
            Name = name;
        }


        public void BorrowBook(Book book , Library library)
        {
            library.BorrowBook(book);
        }
    }
}
