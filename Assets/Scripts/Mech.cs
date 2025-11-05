using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Weapon))]
public abstract class Mech : MonoBehaviour
{
    Rigidbody2D rb;
    Weapon[] weapons;

    [SerializeField]
    int teamNumber;

    [SerializeField]
    int lifeCountDefault;
    int lifeCountCurrent;

    [SerializeField]
    int hpCurrent;
    [SerializeField]
    int hpMaxDefault;
    [SerializeField]
    int hpMaxCurrent;

    [SerializeField]
    int defenseCurrent;
    [SerializeField]
    int defenseDefault;

    [SerializeField]
    int shieldCurrent;
    [SerializeField]
    int shieldMaxDefault;
    [SerializeField]
    int shieldMaxCurrent;

    [SerializeField]
    int shieldRegenRateCurrent;
    [SerializeField]
    int shieldRegenRateDefault;

    [SerializeField]
    float walkSpeedCurrent;
    [SerializeField]
    float walkSpeedDefault;

    [SerializeField]
    float boostedSpeedCurrent;
    [SerializeField]
    float boostedSpeedDefault;

    [SerializeField]
    float jumpSpeedCurrent;
    [SerializeField]
    float jumpSpeedDefault;

    [SerializeField]
    float decendSpeedCurrent;
    [SerializeField]
    float decendSpeedDefault;

    [SerializeField]
    float rotationSpeedCurrent;
    [SerializeField]
    float rotationSpeedDefault;

    [SerializeField]
    float boostTimeCurrent;
    [SerializeField]
    float boostTimeMaxDefault;
    [SerializeField]
    float boostTimeMaxCurrent;

    [SerializeField]
    float boostTimeRegenRateCurrent;
    [SerializeField]
    float boostTimeRegenRateDefault;

    struct ControlCommand
    {
        public Vector2 moveDirection;
        public Vector2 headDirection;
        public int wantedWeapon;
        public bool isWantBooster;
        public bool isWantJump;
        public bool isWantShot;
        public bool isWantAimAssist;
    }

    ControlCommand command;

    [SerializeField]
    float invincibleTime;
    float invincibleDefault;
    float invincibleTimer;

    [SerializeField]
    float stunTimeDefault;
    float stunTimer;

    [SerializeField]
    float downTimeDefault;
    float downTimer;

    float preSwapDelayTimer;
    float postSwapDelayTimer;
    float preShotDelayTimer;
    float postShotDelayTimer;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        weapons = GetComponents<Weapon>();
    }

    void FixedUpdate()
    {

        rb.velocity = command.moveDirection * 
    }

    void Update()
    {
        PollControlCommand();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if      (collision.CompareTag("Projectile"))    OnProjectileCollide();
        else if (collision.CompareTag("Mech"))          OnMechCollide();
        else if (collision.CompareTag("Item"))          OnItemCollide();
        else if (collision.CompareTag("MissionObject")) OnMissionObjectCollide();
    }

    protected abstract void OnProjectileCollide();
    protected abstract void OnMechCollide();
    protected abstract void OnItemCollide();
    protected abstract void OnMissionObjectCollide();
    protected abstract void PollControlCommand();
}
