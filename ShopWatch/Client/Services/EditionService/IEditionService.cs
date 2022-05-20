using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.EditionService
{
    public interface IEditionService
    {
        Task<List<Edition>> GetEditions();
    }
}
