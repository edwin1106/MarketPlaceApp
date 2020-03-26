using System.Collections.Generic;
using System.Threading.Tasks;
using MarketPlaceApp.Domain.Models;

namespace MarketPlaceApp.Domain.Behaviors
{
    public interface IAssetBehavior
    {
        Task CreateAsync(Asset asset);
        Task<List<Asset>> GetAllAsync();
        Task<List<Asset>> GetLastAssetsAsync();
        Task<Asset> GetByIdAsync(int id);
        Task UpdateAsync(Asset asset);
    }
}