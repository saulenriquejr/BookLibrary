using Business;
using Contracts;
using Data;
using Data.Implementations;
using Ninject.Modules;

namespace DependencyResolver
{
    public class NinjectResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IBooksOperations>().To<BooksOperations>();
            Bind<IBookRepository>().To<BookRepository>();

        }
    }
}
