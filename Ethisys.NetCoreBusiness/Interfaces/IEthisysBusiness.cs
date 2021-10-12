using Ethisys.NetCoreDomain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ethisys.NetCoreBusiness.Interfaces
{
    public interface IEthisysBusiness
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
