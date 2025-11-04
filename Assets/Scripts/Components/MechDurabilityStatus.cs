using Unity.Entities;

public struct MechDurabilityStatus : IComponentData
{
    // default (max): default (max) at the start of a stage
    // current (max): current (max) with temporary buff/debuff
    public int lifeCount;
    public float healthCurrent;
    public float healthDefaultMax;
    public float healthCurrentMax;
    public float shieldCurrent;
    public float shieldDefaultMax;
    public float shieldCurrentMax;
    public float shieldRegenRateCurrent;
    public float shieldRegenRateDefault;
    public float armourCurrent;
    public float armourDefault;
}
