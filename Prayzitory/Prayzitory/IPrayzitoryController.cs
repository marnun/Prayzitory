using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prayzitory
{
    public interface IPrayzitoryController
    {
        void NewPray(PrayDTO prayDto);
        List<PrayDTO> ListPrays();
    }

    public class Prayzitory : IPrayzitoryController
    {
        public void NewPray(PrayDTO prayDto)
        {
            //calls add new pray UseCase
            var interactor = new PrayInteractor();
            interactor.CreateNewPray(prayDto.Pray, prayDto.Timestemp, prayDto.User);
        }

        public List<PrayDTO> ListPrays()
        {
            var interactor = new PrayInteractor();
            List<PrayDTO> result = interactor.GetTopPrays();
            
            return result;
        }
    }
}
