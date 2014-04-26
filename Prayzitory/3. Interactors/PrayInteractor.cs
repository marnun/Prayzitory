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

        public void CreateNewPray(string pray, DateTime timestamp, int userId)
        {
            var user = _praysService.GetUser(userId);
            _praysService.CreateNewPray(pray, timestamp, user);
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