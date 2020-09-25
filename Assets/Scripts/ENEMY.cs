using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class ENEMY : MonoBehaviour
    {
        public abstract class Enemy
        {
            protected int MoveSpeed;
            protected int MaxHealth;
            protected float CurrentHealth;

            protected void Moving ()
            {

            }
        }
    }
}
