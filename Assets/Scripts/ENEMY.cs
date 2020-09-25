using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
    public class ENEMY : ScriptableObject
    {
        public static int MoveSpeed;
        public static int MaxHealth;
        public static float CurrentHealth;

        public virtual void Moving()
        {

        }
    }

    public class NormalEnemy : ENEMY
    {
        public override void Moving() 
        {
            Debug.Log("I'M MOVING PEDAY");
        }

    }
}
