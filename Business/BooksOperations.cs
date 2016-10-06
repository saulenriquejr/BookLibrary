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

        public async Task<int> DeleteBook(int Id)
        {
            return await _bookRepository.Delete(x => x.ID == Id);
        }

        public async Task<IList<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAll();
        }

        public async Task<IList<Book>> GetBooksByAuthor(string author)
        {
            return await _bookRepository.GetBy(b => b.Author == author);
        }

        public async Task<IList<Book>> GetBooksByCategory(string category)
        {
            return await _bookRepository.GetBy(b => b.Category == category);
        }
    }
}
