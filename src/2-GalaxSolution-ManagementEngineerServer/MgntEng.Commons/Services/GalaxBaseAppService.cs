using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MgntEng.Commons.Services
{
    public abstract class GalaxBaseAppService : DisposableObject
    {
        public static string Jobuser { get; private set; }
        public string user { get; set; }

        static GalaxBaseAppService()
        {
            Jobuser = "AUTOMATIC";
        }

        protected GalaxBaseAppService(IEnumerable<IDisposable> compositions) : base(compositions)
        {

        }
    }

    
    
}
