using Unity.Entities;

public struct MechWeaponStatus : IComponentData
{
    uint activeWeaponIdx;
    uint Weapon0DefHash;
    uint Weapon1DefHash;
    uint Weapon2DefHash;
    float damageCoefficientCurrent;
    float damageCoefficientDefault;
}
