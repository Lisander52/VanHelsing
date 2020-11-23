﻿using System;
using UnityEngine;


namespace BeastHunter
{
    [Serializable]
    public struct HellHoundStats
    {
        #region Properties

        [Tooltip ("The radius the dog will move away from the spawn point. Default: 50.0")]
        public float WanderingRadius;
        [Tooltip ("Player detection radius. Default: 30.0")]
        public float DetectionRadius;
        [Tooltip ("How often will the dog walk. Default: 75.0")]
        public float RoamingChance;
        [Tooltip ("Non-attack jump animation speed. Default: 1.2")]
        public float JumpingSpeedRate;

        [Header("Damage")]
        public float PhysicalDamage;
        public float StunProbability;

        [Header("Attacks")]
        [Tooltip("The speed at which the dog will turn towards the player during attacks. Default: 0.5")]
        public float AttacksTurnSpeed;
        [Tooltip ("The maximum distance from which the dog will try to attack the player, excluding jumping. Default: 1.5")]
        public float AttacksMaxDistance;
        [Tooltip ("The maximum distance from which the dog will conduct an attacking jump. Default: 3.0")]
        public float AttackJumpMaxDistance;
        [Tooltip ("The minimum distance from which the dog will conduct an attacking jump. Default: 2.5")]
        public float AttackJumpMinDistance;

        [Header("Idling")]
        [Tooltip ("Default: 5.0")]
        public float IdlingMinTime;
        [Tooltip ("Default: 10.0")]
        public float IdlingMaxTime;

        [Header("Resting")]
        [Tooltip ("The chance is calculated from idling chance. Default: 10.0")]
        public float RestingChance;
        [Tooltip ("Default: 30.0")]
        public float RestingMinTime;
        [Tooltip ("Default: 60.0")]
        public float RestingMaxTime;

        [Header("Escaping")]
        [Tooltip("Must be greater than a detection radius. Default: 40.0")]
        public float EscapeDistance;
        [Tooltip ("The percentage of health at which the escape state is enabled. Default: 30.0")]
        public float PercentEscapeHealth;

        [Header("BackJumping")]
        [Tooltip ("Distance at which the jump will occur. Default: 1.0")]
        public float BackJumpDistance;
        [Tooltip ("The longer the length, the further the point is put, which the jump must reach. Default: 1.5")]
        public float BackJumpLength;
        [Tooltip ("The higher the speed, the further the landing will be, but not further BackJumpDistance. Default: 5.0")]
        public float BackJumpSpeed;
        [Tooltip ("The higher the speed, the faster the animation ends. Default: 2.0")]
        public float BackJumpAnimationSpeedRate;
        [Range(0,1), Tooltip("The higher, the more pronounced the jump will be. At zero, the dog will not jump. Default: 0.5")]
        public float BackJumpAnimationIntensity;

        [Header("BattleCircling")]
        [Tooltip ("The distance from the player that the dog will try to keep after back jumping. Default: 3.0")]
        public float BattleCirclingRadius;
        [Tooltip ("The speed at which the dog will move during the stage. Default: 3.0")]
        public float BattleCirclingSpeed;
        [Tooltip ("Default: 1.0")]
        public float BattleCirclingMinTime;
        [Tooltip ("Default: 3.0")]
        public float BattleCirclingMaxTime;

        [Header("NavMeshAgent")]
        [Tooltip ("Default: 2.0")]
        public float MaxRoamingSpeed;
        [Tooltip("Default: 10.0")]
        public float MaxChasingSpeed;
        [Tooltip("Default: 450.0")]
        public float AngularSpeed;
        [Tooltip("Default: 10.0")]
        public float Acceleration;
        [Tooltip("Default: 1.0")]
        public float StoppingDistance;
        [Tooltip("Default: -0.05")]
        public float BaseOffsetByY;

        #endregion
    }
}
