using System;
using System.Collections.Generic;
using Domain;

namespace Interactors
{

    public interface IPraysService
    {
        IEnumerable<Pray> GetTopPrays();
    }

    public class PraysService : IPraysService
    {
        public IEnumerable<Pray> GetTopPrays()
        {
            throw new NotImplementedException();
        }
    }
}