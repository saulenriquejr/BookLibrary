using Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs;
using Data;
using System;

namespace Business
{
    public class BooksOperations : IBooksOperations
    {
        private readonly IBookRepository _bookRepository;

        public BooksOperations(IBookRepository genericRepository)
        {
            _bookRepository = genericRepository;
        }

        public Task Delete(int Id)
        {
            return _bookRepository.Delete(x => x.ID == Id);
        }

        public Task<IList<Book>> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Task<IList<Book>> GetBooksByAuthor(string author)
        {
            return _bookRepository.GetBy(b => b.Author == author);
        }

        public Task<IList<Book>> GetBooksByCategory(string category)
        {
            return _bookRepository.GetBy(b => b.Category == category);
        }
    }
}
