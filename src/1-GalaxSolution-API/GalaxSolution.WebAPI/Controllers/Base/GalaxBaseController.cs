using System;
using System.Collections.Generic;
using GalaxSolution.Infrastructure.CrossCutting.Commons.AppServices.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace GalaxSolution.WebAPI.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
<<<<<<< HEAD
    public abstract class GalaxBaseController : ControllerBase
=======
    public class GalaxBaseController : ControllerBase
>>>>>>> master
    {
        private bool _disposeValue = false;
        private List<IDisposable> _disposables;
        private List<IDisposable> _disposable;

        public IEnumerable<IGalaxSolutionBaseAppService> AppServices { get; private set; }

        protected GalaxBaseController(IEnumerable<IDisposable> disposables, IEnumerable<IGalaxSolutionBaseAppService> appServices)
        {
            _disposable = new List<IDisposable>(disposables);
            AppServices = new List<IGalaxSolutionBaseAppService>(appServices);

        }

        protected GalaxBaseController(IEnumerable<IDisposable> disposables)
        {
            _disposable = new List<IDisposable>(disposables);
            AppServices = new List<IGalaxSolutionBaseAppService>();

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposeValue)
            {
                foreach (var item in _disposables)
                {
                    item.Dispose();
                }
                _disposable?.Clear();
                _disposable = null;
            }
            _disposeValue = true;

        }
        ~GalaxBaseController()
        {
            Dispose(false);
        }

        public void Dispose(GalaxBaseController galaxBaseController)
        {
            Dispose(this);
            GC.SuppressFinalize(this);
        }

    }
}
