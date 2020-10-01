using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MngEng.Cidade.AppService.Interfaces
{
    public interface ICidadeAppService : IDisposable
    {
        Task<ResponseMessage<CidadeImportResponse>> ImportCidadeAsync();
    }

    
}
