using Microsoft.EntityFrameworkCore.Migrations;

namespace MarketPlaceApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Tag = table.Column<string>(nullable: false),
                    ImageURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Description", "ImageURL", "Tag", "Title" },
                values: new object[,]
                {
                    { 1, "UE4 - Align Actors in Editor using tools like in 3ds max", "https://cdn1.epicgames.com/ue/product/Featured/AssetBuilderToolsFreeDemo_featured-894x488-c332a75f9f46e558ffe6bbe3588b5d08.png", "Align, Snap, Construction", "AssetBuilder Tools Free Demo" },
                    { 2, "56 PBR Fabric Materials - Game and Arch Viz Ready, ideal for both environments and characters. Created at 4K resolution", "https://cdn1.epicgames.com/ue/product/Featured/FabricMaterials56Pack_featured-894x488-8c9cb21c4608e5e6aeb9e92ac352cbb6.png", "Materials, PBR, Textures", "Fabric Materials - 56 Pack" },
                    { 3, "Package contains over 350 models to build stylized dungeons for top-down and first-person games.", "https://cdn1.epicgames.com/ue/item/MultistoryDungeons_Image_894X488-896x488-0bdc200ab21cf23c07a9c5b676a6d996.png", "Dungeons, Fantasy, Low Poly, Stylized, Modular, RPG", "Multistory Dungeons" },
                    { 4, "This project includes a set of modular meshes and simple blueprint setups to create a subway train. All assets, materials, and vfx created in the Unreal Engine at production ready quality. Each asset was created for realistic AAA quality visuals, style, and budget.", "https://cdn1.epicgames.com/ue/product/Screenshot/subwaytrain_screenshot_01-1920x1080-9336094e9e4eded2c797621b34eb2ac8.png", "Realistic, City, Horror, Metro", "City Subway Train - Modular" },
                    { 5, "‘Freedom’ is a bold, uplifting orchestral track, imbued with ideas of exploration, and the pioneering spirit.", "https://img.youtube.com/vi/8wQd6G1ONTg/maxresdefault.jpg", "Orchestral, Uplifting, Exploration", "Freedom" },
                    { 6, "A 2019 remaster of an old track! ‘Ashes’ is a simple, uplifting orchestral track with acoustic drums and strings. The new version has more emphasis on solo strings (violin and cello).", "https://img.youtube.com/vi/dOkZKq5o99w/maxresdefault.jpg", "Orchestral, Uplifting", "Ashes of a Fallen Year - Remaster" },
                    { 7, "Elevator music, pure and simple. Three versions are provided: Full Mix, EQ’d (for the elevator speaker experience), and EQ’d + Less Drums (heard above), which has a simpler, more comedic vibe.V", "http://www.scottbuckley.com.au/wp-content/uploads/scott-wall2-flipped-fade3.jpg", "Elevator, Samba, Jazzy, Relaxing", "Skyscraper Samba" },
                    { 8, "Sweeping orchestra, with a touch of sadness, a pinch of melancholy, but a smidgeon of hope for balance – a modern tone poem for the trials of overcoming adversity. A simple, distorted synth helps drive the orchestra forward.", "https://img.youtube.com/vi/fMx5roxJ7Uk/maxresdefault.jpg", "Sad, Orchestra", "Ascension" },
                    { 9, "Simple piano and strings, evoking the naivety of childhood.", "https://img.youtube.com/vi/0JhMDxp3LFA/maxresdefault.jpg", "Piano, Happy", "Childhood" },
                    { 10, "Ambient electronics, strings and solo cello, melding into an amorphous tonal explorational soundscape. I’ve also included a ‘No Cello’ mix, which transforms the track into atmospheric underscore.", "https://img.youtube.com/vi/kbTClxgehrQ/maxresdefault.jpg", "Ambient, Dark", "Computations in a Snowstorm" },
                    { 11, "Darker ambient piano – subtle thriller vibes, with a simpler piano theme which should hopefully work well as underscore. Also included is a ‘no melody’ alternative mix.", "https://img.youtube.com/vi/TO5eGVihmN0/maxresdefault.jpg", "Ambient, Dark, Piano", "Intervention" },
                    { 12, "A cinematic re-orchestration of ‘O Come All Ye Faithful’, with sweeping strings, brass and percussion. Merry Christmas guys! Thanks for an amazing year.", "https://img.youtube.com/vi/Or0AdFdwICA/maxresdefault.jpg", "Chistmas, Xmas, Orchestral", "‘O Come All Ye Faithful" },
                    { 13, "A heartfelt reflection of the snowy darkness of Midwinter (at least of what it’s like here in Sweden!). Simple layered pianos, percussive and sustained strings, and synths.", "https://img.youtube.com/vi/2N6LRMFT7_A/maxresdefault.jpg", "Snow, Winter, Piano, Synth, Strings", "" },
                    { 14, "A simple, moody extrapolation of a piano improvisation, featuring atmospheric strings. Slightly uplifting, slightly melancholy.", "https://img.youtube.com/vi/ZUua4pp2PKw/maxresdefault.jpg", "Moody, Piano, Strings", "Extrapolation" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
