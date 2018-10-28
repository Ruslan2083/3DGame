using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public abstract class Weapons : BaseSceneObject
    {
        //позиция из которой будут вылетать снаряды
        [SerializeField] protected Transform _gun;
        // сила выстрела
        [SerializeField] protected float _force=500;
        //время задержки между выстрелами
        [SerializeField] protected float _rechargeTime=0.2f;

        
        protected bool _fire = true;    //флаг разрешающий выстрел

        public abstract void Fire();    //функция для вызова выстрела, обязательна во всех дочерних классах

    }
}
