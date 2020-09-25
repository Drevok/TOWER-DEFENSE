using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    [CreateAssetMenu (fileName= "New Enemy", menuName = "Enemy")]
    public class ENEMY  : ScriptableObject
    {
            public static int MoveSpeed;
            public static int MaxHealth;
            public static float CurrentHealth;
            public static Vector3 destination;
            public Transform target;
            public static NavMeshAgent agent;

            protected void Moving ()
            {
                if (Vector3.Distance(destination, target.position) > 1.0f)
                {
                    destination = target.position;
                    agent.destination = destination;
                }                
            }

            void Start()
            {
                agent = agent.GetComponent<NavMeshAgent>();
                destination = agent.destination; 
            }

            void Update ()
            {
                Moving();
            }

        public class NormalEnemy : ENEMY
        {

        }
    }
}
