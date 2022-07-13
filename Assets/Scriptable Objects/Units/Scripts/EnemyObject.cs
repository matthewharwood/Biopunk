using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Object", menuName = "Inventory System/Unit/Enemy")]
public class EnemyObject : UnitObject
{
    [SerializeField] protected MoneyObject[] moneyDrop;
    [SerializeField] protected ExperienceObject[] experienceDrop;
    public Enemy prefab;
    private void Awake()
    {
        type = UnitType.Enemy;
        health = 1;
        speed = 1f;
        damage = 1;
        rarityColor = RarityColorType.Black;
    }

    public void Test()
    {
        Debug.Log("test");
    }
    
    public ExperienceObject MaybeDropExperience()
    {
        ExperienceObject item = null;
        if (experienceDrop.Length > 0 && experienceDrop[0])
        {
            item = experienceDrop[0];  
        }
        return item;
    }
    
    public MoneyObject MaybeDropMoney()
    {
        MoneyObject item = null;
        if (moneyDrop.Length > 0 && moneyDrop[0])
        {
            item = moneyDrop[0];  
        }
        return item;
    }
}
