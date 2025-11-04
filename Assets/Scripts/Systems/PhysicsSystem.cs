using System;
using Unity.Burst;
using Unity.Entities;

partial struct PhysicsSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        
    }


    [BurstCompile]
    bool IsColliding(RigidBody2D b1, CollisionBody2D c1, RigidBody2D b2, CollisionBody2D c2)
    {
        // simplified collision body
        if (c1.type == CollisionBodyType.Square && c2.type == CollisionBodyType.Square) return IsCollidingSquareToSquare(b1, c1, b2, c2);
        if (c1.type == CollisionBodyType.Square && c2.type == CollisionBodyType.Circle) return IsCollidingSquareToCircle(b1, c1, b2, c2);
        if (c1.type == CollisionBodyType.Circle && c2.type == CollisionBodyType.Square) return IsCollidingSquareToSquare(b1, c1, b2, c2);
        if (c1.type == CollisionBodyType.Circle && c2.type == CollisionBodyType.Circle) return IsCollidingSquareToSquare(b1, c1, b2, c2);
        throw new NotImplementedException();
    }

    [BurstCompile]
    bool IsCollidingSquareToSquare(RigidBody2D b1, CollisionBody2D c1, RigidBody2D b2, CollisionBody2D c2)
    {
        return false;
    }

    [BurstCompile]
    bool IsCollidingSquareToCircle(RigidBody2D bSquare, CollisionBody2D cSquare, RigidBody2D bCircle, CollisionBody2D cCircle)
    {
        return false;  
    }

    [BurstCompile]
    bool IsCollidingCircleToCircle(RigidBody2D b1, CollisionBody2D c1, RigidBody2D b2, CollisionBody2D c2)
    {
        return false;
    }
}
