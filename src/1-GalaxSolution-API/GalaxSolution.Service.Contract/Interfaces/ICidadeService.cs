﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Service.Contract.Interfaces
{
    public interface ICidadeService
    {
        Task<IEnumerable<Cidade>> GetCidadeAsync();
    }
}
