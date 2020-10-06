using Galax.Solution.Domain.Core.Events;
using Galax.Solution.Domain.Interfaces;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppServices.Implementation.Services
{
    public class CidadeAppService
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cidadeRepository;
        private readonly IEventStockRepository eventStockRepository;
        private readonly IMediatorHandler _mediator;

        public CidadeAppServoce(IMapper mapper,
                                 ICityRepository cidadeRepository,
                                 IMediatorHandler mediator,
                                 IEventStockRepository eventStockRepository)
        {

        }

    }

    
}
