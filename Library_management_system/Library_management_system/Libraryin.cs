using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Libraryin : User
    {
        public int EmployeeNumber { get; set; }
        public Libraryin (string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook , Library library)
        {
            library.Add(newBook);
        } 
        public void RemoveBook(Book book , Library library)
        {
            library.Remove(book);
        }
    }
}
