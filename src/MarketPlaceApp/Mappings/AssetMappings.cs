using AutoMapper;
using MarketPlaceApp.Commands;
using MarketPlaceApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlaceApp.Mappings
{
    public class AssetMappings : Profile
    {
        public AssetMappings()
        {
            CreateMap<ActualizarAsset, Asset>();
            CreateMap<CrearAsset, Asset>();
        }

    }
}
