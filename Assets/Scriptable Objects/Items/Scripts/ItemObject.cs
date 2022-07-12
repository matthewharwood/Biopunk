using UnityEngine;

public enum ItemType
{
    Weapon,
    Money,
    Experience,
    Default,
}


[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]
public abstract class ItemObject : ScriptableObject
{
    [SerializeField]
    public GameObject prefab;
    [SerializeField]
    protected ItemType type;
    [SerializeField]
    protected RarityType rarity;
    [SerializeField]
    protected RarityColorType rarityColor;
    
    [TextArea(15, 20)]
    [SerializeField] protected string description;
}