﻿using RootMotion.Dynamics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeastHunter
{
    public class StompSplashAttackSkill : BossBaseSkill
    {
        private const float DELAY_HAND_TRIGGER = 0.2f;
        private GameObject _target;
        public StompSplashAttackSkill(bool IsEnable, int Id, float RangeMin, float RangeMax, float Cooldown, bool IsReady, Dictionary<int, BossBaseSkill> skillDictionary, BossStateMachine stateMachine) 
            : base(IsEnable, Id, RangeMin, RangeMax, Cooldown, IsReady, skillDictionary, stateMachine)
        {
        }

        public StompSplashAttackSkill((bool, int, float, float, float, bool, bool) skillInfo, Dictionary<int, BossBaseSkill> skillDictionary, BossStateMachine stateMachine) : base(skillInfo, skillDictionary, stateMachine)
        {
        }

        public override void UseSkill(int id)
        {
            Debug.Log("StompAttackSkill");
            _bossModel.BossAnimator.Play("BossStompAttack", 0, 0f);
            var TimeRem = new TimeRemaining(() => StompShockWave(), 0.65f);
            TimeRem.AddTimeRemaining(0.65f);

          //  TurnOnHitBoxTrigger (_currenTriggertHand,_stateMachine.CurrentState.CurrentAttackTime, DELAY_HAND_TRIGGER);

            ReloadSkill(id);
        }

        private void StompShockWave()
        {
            _bossModel.leftStompEffect.Play(true);
            var force = 50f;
            var list = Services.SharedInstance.PhysicsService.GetObjectsInRadiusByTag(_bossModel.LeftFoot.position, 20f, "Player");
            if (list.Count != 0)
            {
                var target = list.Find(x => x.name == "Player");

                if (target != null)
                {
                    _stateMachine._context.CharacterModel.BehaviorPuppet.SetState(BehaviourPuppet.State.Unpinned);

                    foreach (var item in _stateMachine._context.CharacterModel.PuppetMaster.muscles)
                    {
                        item.rigidbody.AddExplosionForce(force, _bossModel.LeftFoot.transform.position, 15f, 1.5f, ForceMode.Impulse);
                    }
                }
            }

        }
        public override void StopSkill()
        {
        }
        private void Damage()
        {
            var damage = new Damage();
            damage.PhysicalDamage = Random.Range(15f, 30f);
            Services.SharedInstance.AttackService.CountAndDealDamage(damage, _target.transform.root.gameObject.GetInstanceID());;
        }
    }
}