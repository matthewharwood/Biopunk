using UnityEngine;


[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]
public class WeaponObject : ItemObject
{
    [SerializeField]
    private int damage;
    
    [SerializeField]
    private int health;

    [SerializeField]
    private int defence;

    [SerializeField]
    public double dropPercentage;
    
    [SerializeField]
    public int minLevelRequirement;
    private void Awake()
    {
        type = ItemType.Weapon;
        rarity = RarityType.Poor;
        rarityColor = RarityUtil.RarityToColorMap(rarity);
    }
    
    private void OnValidate()
    {
        rarityColor = RarityUtil.RarityToColorMap(rarity);
        if (dropPercentage >= 1f)
        {
            dropPercentage = 1f;
        }

        if (dropPercentage <= 0f)
        {
            dropPercentage = 0f;
        }

        if (minLevelRequirement <= 0)
        {
            minLevelRequirement = 0;
        }

        if (minLevelRequirement >= 110)
        {
            minLevelRequirement = 110;
        }
    }
}
