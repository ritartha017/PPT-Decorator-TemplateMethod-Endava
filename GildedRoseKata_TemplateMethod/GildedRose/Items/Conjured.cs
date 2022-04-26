namespace GildedRoseKata;

public class Conjured : InventoryItem
{
    public const string ITEM_NAME = "Conjured Mana Cake";

    public Conjured(Item item) : base(item)
    {
    }

    protected override void UpdateQuality()
    {
        DecreaseQuality();
        DecreaseQuality();
    }

    protected override void ProcessExpired()
    {
        DecreaseQuality();
        DecreaseQuality();
    }
}
