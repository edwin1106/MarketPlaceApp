using AutoMapper;
using MarketPlaceApp.Commands;
using MarketPlaceApp.Domain.Behaviors;
using MarketPlaceApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlaceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetBehavior _assetBehavior;
        private readonly IMapper _mapper;

        public AssetsController(IAssetBehavior assetBehavior, IMapper mapper)
        {
            _assetBehavior = assetBehavior;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Asset>> CreateAsync(CrearAsset crearAsset)
        {
            var asset = _mapper.Map<Asset>(crearAsset);
            await _assetBehavior.CreateAsync(asset);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = asset.Id }, asset);
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<List<Asset>> GetAllAsync()
        {
            return await _assetBehavior.GetAllAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Asset>> GetByIdAsync(int id)
        {
            var assetExistente = await _assetBehavior.GetByIdAsync(id);
            if(assetExistente == null)
            {
                return NotFound();
            }
            return assetExistente;
        }
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateAsync(int id, ActualizarAsset actualizarAsset)
        {
            var asset = await _assetBehavior.GetByIdAsync(id);
            if(asset == null)
            {
                return NotFound();
            }
            _mapper.Map(actualizarAsset, asset);
            await _assetBehavior.UpdateAsync(asset);

            return NoContent();
        }

    }
}
