using System;
using System.Collections.Generic;
using Interactors;

namespace Presenters.Controllers
{
    public interface IPraysController
    {
        void NewPray(string text, DateTime timestemp, string user);
        IEnumerable<PrayDto> ListPrays();
    }

    public class PraysController : IPraysController
    {
        protected IPraysService _praysService;

        public PraysController(IPraysService praysService)
        {
            _praysService = praysService;
        }

        public void NewPray(string text, DateTime timestemp, string user)
        {
            //calls add new text UseCase
            var interactor = new PrayInteractor(_praysService);
            interactor.CreateNewPray(text, timestemp, user);
        }

        public IEnumerable<PrayDto> ListPrays()
        {
            var interactor = new PrayInteractor(_praysService);
            IEnumerable<PrayDto> result = interactor.GetTopPrays();

            return result;
        }
    }
}