using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Experience Object", menuName = "Inventory System/Items/Experience")]
public class ExperienceObject : ItemObject
{
    public int point;
    private void Awake()
    {
        type = ItemType.Experience;
        rarity = RarityType.Poor;
        rarityColor = RarityUtil.RarityToColorMap(rarity);
    }
    private void OnValidate()
    {
        rarityColor = RarityUtil.RarityToColorMap(rarity);
    }
}
