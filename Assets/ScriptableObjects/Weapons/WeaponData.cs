using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapons/Weapon Data")]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public WeaponType type;
    public int damage;
    public float cooldown;
}

public enum WeaponType
{
    None,
    Knife,
    Gun
}
