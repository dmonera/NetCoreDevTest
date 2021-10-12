using Ethisys.NetCoreDomain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ethisys.NetCoreBusiness.Interfaces
{
    public interface IInventoryData
    {
        Task<IEnumerable<ProductDto>> GetInventory();
    }
}
