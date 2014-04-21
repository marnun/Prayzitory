using System;
using System.Collections.Generic;
using Interactors;

namespace Presenters.Controllers
{
    public interface IPraysController
    {
        void NewPray(string text, DateTime timestemp, string user);
        List<PrayDto> ListPrays();
    }

    public class PraysController : IPraysController
    {
        public void NewPray(string text, DateTime timestemp, string user)
        {
            //calls add new text UseCase
            var interactor = new PrayInteractor();
            interactor.CreateNewPray(text, timestemp, user);
        }

        public List<PrayDto> ListPrays()
        {
            var interactor = new PrayInteractor();
            List<PrayDto> result = interactor.GetTopPrays();

            return result;
        }
    }
}