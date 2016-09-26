using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBooksOperations
    {
        Task<IList<Book>> GetAllBooks();

        Task<IList<Book>> GetBooksByCategory(string category);

        Task<IList<Book>> GetBooksByAuthor(string category);

        Task Delete(int Id);
    }
}
