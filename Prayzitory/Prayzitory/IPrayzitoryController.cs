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
}
