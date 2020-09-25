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
            public GameObject target;
            public static NavMeshAgent agent;

            protected void Moving ()
            {
                agent.SetDestination(target.transform.position);                         
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
