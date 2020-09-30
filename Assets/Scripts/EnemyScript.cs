using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class EnemyScript : MonoBehaviour
    {
        public int MoveSpeed;
        public int MaxHealth;
        public float CurrentHealth
        {
            get
            {
                return CurrentHealth;
            }
            set 
            {
                if (CurrentHealth <= 0)
                {
                    Die();
                }
            }
        }

        public ENEMY testenemy;
        public GameObject Goal;
        //public Camera Camera;
        [HideInInspector] public NavMeshAgent NavMeshAgent;

        private void Awake()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Start() 
        {
            testenemy.Moving(this, Goal.transform.position);
            CurrentHealth = MaxHealth;
        }
        public void TakeDamage(float amount)
        {
            CurrentHealth -= amount;

        }

        public void Die()
        {
            Destroy(this);
        }

    }
}
