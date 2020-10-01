using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.EventSourcedNormalizers.Cidade
{
    public class CidadeHistoryData
    {
        public string Action { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public object Timestamp { get; internal set; }
    }
}
