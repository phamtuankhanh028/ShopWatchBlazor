using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.EditionService
{
    public interface IEditionService
    {
        Task<List<Edition>> GetEditions();
    }
}
