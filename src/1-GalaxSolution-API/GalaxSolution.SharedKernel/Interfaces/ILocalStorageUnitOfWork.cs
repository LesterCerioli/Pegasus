using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.SharedKernel.Interfaces
{
    public interface ILocalStorageUnitOfWork : IDisposable
    {
        void Commit();
    }
}
