using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]
public class DefaultObject : ItemObject
{
  private void Awake()
  {
    type = ItemType.Default;
    rarity = RarityType.Poor;
    rarityColor = RarityUtil.RarityToColorMap(rarity);
  }

  private void OnValidate()
  {
    rarityColor = RarityUtil.RarityToColorMap(rarity);
  }
}
