using Unity.Entities;
using UnityEngine;

partial class PlayerControllerSystem : SystemBase
{
    float weaponSwapScrollCoolDownTime = 0.25f;
    float weaponSwapScrollTimer;
    uint weaponCount = 3;

    protected override void OnStartRunning()
    {
        weaponSwapScrollTimer = weaponSwapScrollCoolDownTime;
    }

    protected override void OnUpdate()
    {
        float movementX = (Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0);
        float movementY = (Input.GetKey(KeyCode.W) ? 1 : 0) - (Input.GetKey(KeyCode.S) ? 1 : 0);
        Vector2 direction = new Vector2(movementX, movementY).normalized;

        Vector2 aimAt = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        bool jump = Input.GetKey(KeyCode.Space);

        bool dash = Input.GetKey(KeyCode.LeftShift);

        uint weaponKeyPress =
            Input.GetKeyDown(KeyCode.Alpha1) ? 0u :
            Input.GetKeyDown(KeyCode.Alpha2) ? 1u :
            Input.GetKeyDown(KeyCode.Alpha3) ? 2u : uint.MaxValue;

        bool shot = Input.GetMouseButtonDown(0);

        uint weaponUpDown = 0;
        if (0 >= (weaponSwapScrollTimer -= SystemAPI.Time.DeltaTime))
        {
            weaponUpDown = (uint)(weaponCount + Mathf.Sign(Input.mouseScrollDelta.y));
            weaponSwapScrollTimer = weaponSwapScrollCoolDownTime;
        }

        uint weaponCountCopy = weaponCount;

        Entities.ForEach((ref UserControl u, ref ControlCommand command)=>
        {
            command.movementDirection = direction;
            command.aimAt = aimAt;
            command.jump = jump;
            command.dash = dash;
            command.shot = shot;

            if(uint.MaxValue == weaponKeyPress)
            {
                command.wantedWeaponIdx += weaponUpDown;
                command.wantedWeaponIdx %= weaponCountCopy;
            }
            else
            {
                command.wantedWeaponIdx = weaponKeyPress;
            }
        }).Run();
    }
}
