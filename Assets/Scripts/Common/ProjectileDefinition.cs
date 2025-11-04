using UnityEngine;

public struct ProjectileDefinition
{
    public uint movementFuncHash;
    public uint collisionCheckFuncHash;
    public uint onCollisionFuncHash;
    public CollisionBodyType colliderType;
    public Vector3 colliderData;
    public bool isExplosive;
    public bool isPenetrating;
    public float hitStunTime;
    public float selfDestructTime;
    public float damageAverage;
    public float damageVariance;
    public float criticalDamageAverage;
    public float criticalDamageVariance;
    public float criticalPossibility;
}
