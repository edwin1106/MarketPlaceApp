using MarketPlaceApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketPlaceApp.Domain.Infrastructure.Data
{
    public static class SeedExtensions
    {
       public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = 1,
                    Title= "AssetBuilder Tools Free Demo",
                    Description= "UE4 - Align Actors in Editor using tools like in 3ds max",
                    Tag= "Align, Snap, Construction",
                    ImageURL= "https://cdn1.epicgames.com/ue/product/Featured/AssetBuilderToolsFreeDemo_featured-894x488-c332a75f9f46e558ffe6bbe3588b5d08.png",
                },
                new Asset
                {
                    Id = 2,
                    Title = "Fabric Materials - 56 Pack",
                    Description = "56 PBR Fabric Materials - Game and Arch Viz Ready, ideal for both environments and characters. Created at 4K resolution",
                    Tag = "Materials, PBR, Textures",
                    ImageURL = "https://cdn1.epicgames.com/ue/product/Featured/FabricMaterials56Pack_featured-894x488-8c9cb21c4608e5e6aeb9e92ac352cbb6.png",
                },
                new Asset
                {
                    Id = 3,
                    Title = "Multistory Dungeons",
                    Description = "Package contains over 350 models to build stylized dungeons for top-down and first-person games.",
                    Tag = "Dungeons, Fantasy, Low Poly, Stylized, Modular, RPG",
                    ImageURL = "https://cdn1.epicgames.com/ue/item/MultistoryDungeons_Image_894X488-896x488-0bdc200ab21cf23c07a9c5b676a6d996.png",
                },
                new Asset
                {
                    Id = 4,
                    Title = "City Subway Train - Modular",
                    Description = "This project includes a set of modular meshes and simple blueprint setups to create a subway train. All assets, materials, and vfx created in the Unreal Engine at production ready quality. Each asset was created for realistic AAA quality visuals, style, and budget.",
                    Tag = "Realistic, City, Horror, Metro",
                    ImageURL = "https://cdn1.epicgames.com/ue/product/Screenshot/subwaytrain_screenshot_01-1920x1080-9336094e9e4eded2c797621b34eb2ac8.png",
                },
                new Asset
                {
                    Id = 5,
                    Title = "Freedom",
                    Description = "‘Freedom’ is a bold, uplifting orchestral track, imbued with ideas of exploration, and the pioneering spirit.",
                    Tag = "Orchestral, Uplifting, Exploration",
                    ImageURL = "https://img.youtube.com/vi/8wQd6G1ONTg/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 6,
                    Title = "Ashes of a Fallen Year - Remaster",
                    Description = "A 2019 remaster of an old track! ‘Ashes’ is a simple, uplifting orchestral track with acoustic drums and strings. The new version has more emphasis on solo strings (violin and cello).",
                    Tag = "Orchestral, Uplifting",
                    ImageURL = "https://img.youtube.com/vi/dOkZKq5o99w/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 7,
                    Title = "Ascension",
                    Description = "Sweeping orchestra, with a touch of sadness, a pinch of melancholy, but a smidgeon of hope for balance – a modern tone poem for the trials of overcoming adversity. A simple, distorted synth helps drive the orchestra forward.",
                    Tag = "Sad, Orchestra",
                    ImageURL = "https://img.youtube.com/vi/fMx5roxJ7Uk/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 8,
                    Title = "Childhood",
                    Description = "Simple piano and strings, evoking the naivety of childhood.",
                    Tag = "Piano, Happy",
                    ImageURL = "https://img.youtube.com/vi/0JhMDxp3LFA/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 9,
                    Title = "Computations in a Snowstorm",
                    Description = "Ambient electronics, strings and solo cello, melding into an amorphous tonal explorational soundscape. I’ve also included a ‘No Cello’ mix, which transforms the track into atmospheric underscore.",
                    Tag = "Ambient, Dark",
                    ImageURL = "https://img.youtube.com/vi/kbTClxgehrQ/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 10,
                    Title = "Intervention",
                    Description = "Darker ambient piano – subtle thriller vibes, with a simpler piano theme which should hopefully work well as underscore. Also included is a ‘no melody’ alternative mix.",
                    Tag = "Ambient, Dark, Piano",
                    ImageURL = "https://img.youtube.com/vi/TO5eGVihmN0/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 11,
                    Title = "‘O Come All Ye Faithful",
                    Description = "A cinematic re-orchestration of ‘O Come All Ye Faithful’, with sweeping strings, brass and percussion. Merry Christmas guys! Thanks for an amazing year.",
                    Tag = "Chistmas, Xmas, Orchestral",
                    ImageURL = "https://img.youtube.com/vi/Or0AdFdwICA/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 12,
                    Title = "Snowfall",
                    Description = "A heartfelt reflection of the snowy darkness of Midwinter (at least of what it’s like here in Sweden!). Simple layered pianos, percussive and sustained strings, and synths.",
                    Tag = "Snow, Winter, Piano, Synth, Strings",
                    ImageURL = "https://img.youtube.com/vi/2N6LRMFT7_A/maxresdefault.jpg",
                },
                new Asset
                {
                    Id = 13,
                    Title = "Extrapolation",
                    Description = "A simple, moody extrapolation of a piano improvisation, featuring atmospheric strings. Slightly uplifting, slightly melancholy.",
                    Tag = "Moody, Piano, Strings",
                    ImageURL = "https://img.youtube.com/vi/ZUua4pp2PKw/maxresdefault.jpg",
                }

                );;


        }
    }
}
