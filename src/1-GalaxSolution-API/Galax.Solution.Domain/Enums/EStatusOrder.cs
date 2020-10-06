using System;
using System.Collections.Generic;
using System.Text;

namespace Galax.Solution.Domain.Enums
{
    public enum EStatusOrder
    {
        //Esperando pelo pagamento
        WaitingPayment = 1,
        //Aguardando a entrega
        WaitingEelivery = 2,
        //Canceladp
        Canceled = 3

    }
}
