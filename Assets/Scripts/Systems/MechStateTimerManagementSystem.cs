using Unity.Burst;
using Unity.Entities;

partial struct MechStateTimerManagementSystem : ISystem
{
    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        foreach (var timers in SystemAPI.Query<DynamicBuffer<MechStateTimer>>())
        {
            for (int i = timers.Length - 1; i >= 0; i--)
            {
                if (timers[i].remainingTime < 0f)
                {
                    timers.RemoveAtSwapBack(i);
                }
                else
                {
                    timers.ElementAt(i).remainingTime -= SystemAPI.Time.DeltaTime;
                }
            }
        }
    }
}
