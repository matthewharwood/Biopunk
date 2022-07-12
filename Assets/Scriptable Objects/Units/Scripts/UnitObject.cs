using UnityEngine;


public enum UnitType
{
    Player,
    Enemy,
}
public class UnitObject : ScriptableObject
{
    [SerializeField]
    protected GameObject prefab;
    
    [SerializeField]
    protected UnitType type;
    
    [SerializeField]
    protected RarityColorType rarityColor;
    
    [TextArea(15, 20)]
    [SerializeField] protected string description;
    
    [SerializeField]
    protected int health;
    
    [SerializeField]
    protected float speed;

    [SerializeField]
    protected int damage;
    
    [SerializeField]
    protected WeaponObject[] weapons;
}
