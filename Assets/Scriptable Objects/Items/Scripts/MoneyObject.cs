using UnityEngine;

[CreateAssetMenu(fileName = "New Money Object", menuName = "Inventory System/Items/Money")]
public class MoneyObject : ItemObject
{
   public int value;
   private void Awake()
   {
      type = ItemType.Money;
      rarity = RarityType.Poor;
      rarityColor = RarityUtil.RarityToColorMap(rarity);
   }
   private void OnValidate()
   {
      rarityColor = RarityUtil.RarityToColorMap(rarity);
   }
}
