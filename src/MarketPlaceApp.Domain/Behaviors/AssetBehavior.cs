using FamiliesApp.Domain.Infrastructure.Repositories;
using MarketPlaceApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlaceApp.Domain.Behaviors
{
    public class AssetBehavior : IAssetBehavior
    {
        private readonly IDataStorage<Asset> _assetRepository;

        public AssetBehavior(IDataStorage<Asset> assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public async Task CreateAsync(Asset asset)
        {
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));


            await _assetRepository.InsertAsync(asset);
        }

        public async Task<List<Asset>> GetAllAsync()
        {
            return await _assetRepository.FindAllAsync();
        }
        public async Task<List<Asset>> GetQuantityAsync()
        {
            return await _assetRepository.FindQuantityAsync();
        }

        public async Task<Asset> GetByIdAsync(int id)
        {
            return await _assetRepository.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task UpdateAsync(Asset asset)
        {
            await _assetRepository.UpdateAsync(asset);
        }
    }
}
