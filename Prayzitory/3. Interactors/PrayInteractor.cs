using System;
using System.Collections.Generic;
using Domain;

namespace Interactors
{
    public class PrayInteractor
    {
        private IPraysService _praysService;

        public PrayInteractor(IPraysService praysService)
        {
            this._praysService = praysService;
        }

        public void CreateNewPray(string pray, DateTime timestemp, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrayDto> GetTopPrays()
        {
            IEnumerable<Pray> prays = _praysService.GetTopPrays();

            IEnumerable<PrayDto> result = ConvertToDto(prays);
            return result;
        }

        private IEnumerable<PrayDto> ConvertToDto(IEnumerable<Pray> prays)
        {
            List<PrayDto> results = new List<PrayDto>();
            foreach (var pray in prays)
            {
                var item = new PrayDto()
                    {
                        Text = pray.Text,
                        Author = pray.UserName,
                        Created = pray.Created
                    };
             
                results.Add(item);
            }

            return results;
        }
    }

    
}