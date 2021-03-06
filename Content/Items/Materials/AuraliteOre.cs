using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace VoidArsenal.Content.Items.Materials
{
    internal class AuraliteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auralite Ore");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.material = true;
            Item.rare = ItemRarityID.White;
            Item.createTile = ModContent.TileType<Tiles.AuraliteOre>();
            Item.maxStack = 999;
        }
    }
}