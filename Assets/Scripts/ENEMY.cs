﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public abstract class ENEMY : ScriptableObject
    {
        public int MoveSpeed;
        public int MaxHealth;
        public abstract void Moving(EnemyScript enemyScript, Vector3 position);

        public abstract void TakeDamage(EnemyScript enemy);

    }
}
