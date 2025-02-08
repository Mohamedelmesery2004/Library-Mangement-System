using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Liberian : User
    {
        public int EmployeeNumber { get; set; }

        public Liberian(string name)
        {
            Name = name;
        }
        public void AddBook(Book book ,Library library)
        {
            library.Add(book);
        }

        public void RemoveBook(Book book , Library library)
        {
            library.Remove(book);
        }

    }
}
