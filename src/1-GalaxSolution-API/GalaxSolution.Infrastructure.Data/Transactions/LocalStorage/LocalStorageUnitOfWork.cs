using GalaxSolution.Infrastructure.Data.Context.LocalStorage;


namespace GalaxSolution.Infrastructure.Data.Transactions.LocalStorage
{
    public sealed class LocalStorageUnitOfWork : ILocalStorageUnitOfWork
    {
        private GalaxSolutionLocalStorageDbContext _context;

        public LocalStorageUnitOfWork(GalaxSolutionLocalStorageDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }

        }
    }

    
}
