using LibraryManagementSystem.Application.Repositories;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Application.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository; 
        }
        public void Add(Book book)
        {
            if(string.IsNullOrEmpty(book.Title))
            {
                return;
            }

            if(string.IsNullOrEmpty(book.Author))
            {
                return;
            }

            if (string.IsNullOrEmpty(book.Description)) 
            {
                return;
            }

            if (book.Year <= 0)
            {
                return;
            }

            //title,author  ve year a gore yoxlama apar. 

            var existingBook = _repository.FindBy(book.Title, book.Author, book.Year);

            if (existingBook != null)
            {
                // null deyilse geriye qaytarmaliyigki bu kitab movcuddur.

                return;
            }


            _repository.Add(book);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
