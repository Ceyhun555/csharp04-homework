using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);

        void Update(Book book);

        void Delete(int id);

        Book? GetById(int id);

        List<Book> GetAll();

        Book? FindBy(string title, string author, int year);
        
    }
}
