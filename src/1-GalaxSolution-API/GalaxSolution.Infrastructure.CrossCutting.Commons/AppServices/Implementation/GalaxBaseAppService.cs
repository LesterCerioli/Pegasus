using GalaxSolution.Infrastructure.CrossCutting.Commons.AppServices.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.Infrastructure.CrossCutting.Commons.AppServices.Implementation
{
    public abstract class GalaxBaseAppService : IGalaxSolutionBaseAppService, IDisposable
    {

        private bool _disposeValue = false;
        private List<IDisposable> _services;

        public GalaxBaseAppService(IEnumerable<IDisposable> services)
        {
            _services = new List<IDisposable>(services);
        }

        ~GalaxBaseAppService()
        {
            Dispose(false);
        }
        
        public string User { get; set; }

        public virtual void Dispose(GalaxBaseAppService galaxBaseAppService)
        {
            Dispose(this);
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposeValue)
            {
                foreach (var item in _services)
                {
                    item.Dispose();
                }
                _services?.Clear();
                _services = null;

            }
            _disposeValue = true;

        }
    }
}
