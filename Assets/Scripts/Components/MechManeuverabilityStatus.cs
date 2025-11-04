using Unity.Entities;

public struct MechManeuverabilityStatus : IComponentData
{
    float normalSpeedCurrent;
    float normalSpeedDefault;
    float boostedSpeedCurrent;
    float boostedSpeedDefault;
    float rotationSpeedCurrent;
    float rotationSpeedDefault;
    float boosterTimeCurrent;
    float boosterTimeDefault;
    float boosterRegenRateCurrent;
    float boosterRegenRateDefault;
    float jumpSpeedCurrent;
    float jumpSpeedDefault;
}
