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
            protected static int MoveSpeed;
            protected static int MaxHealth;
            protected static float CurrentHealth;
            protected static Vector3 destination;
            protected static Transform target;
            protected static NavMeshAgent agent;

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
                agent = GetComponent<NavMeshAgent>();
                Goal = agent.Goal; 
            }
        }
    }
}
