using System.Collections.Generic;

namespace BethanysPies.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}