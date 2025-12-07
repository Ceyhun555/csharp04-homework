using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    internal interface IBookService
    {
        void Add(Book book);

        void Update(Book book);

        void Delete(int id);

        Book? GetById(int id);

        List<Book> GetAll();
    }
}
