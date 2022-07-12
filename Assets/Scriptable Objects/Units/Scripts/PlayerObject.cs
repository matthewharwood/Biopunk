using UnityEngine;

[CreateAssetMenu(fileName = "New Player Object", menuName = "Inventory System/Unit/Player")]
public class PlayerObject : UnitObject
{
    private void Awake()
    {
        type = UnitType.Enemy;
        health = 1;
        speed = 1f;
        damage = 1;
        rarityColor = RarityColorType.Black;
    }
}
