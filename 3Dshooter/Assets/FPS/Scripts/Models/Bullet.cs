using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

namespace FPS
{
    public class Bullet:Ammunition
    {
        [SerializeField] private float _timeToDestruct = 10;
        [SerializeField] private float _damage = 20;    //урон пули
        [SerializeField] private float _mass = 0.01f;   //масса пули

        private float _currentDamage;  //текущий урон, который может нанести пуля

        protected override void Awake()
        {
            base.Awake();
            Destroy(InstanceObject, _timeToDestruct);
            _currentDamage = _damage;
            
        }
    }
}
