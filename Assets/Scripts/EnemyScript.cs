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
        public float _currentHealth;
        public float CurrentHealth
        {
            get
            {
                return _currentHealth;
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
            CurrentHealth = MaxHealth;
        }

        private void Start() 
        {
            testenemy.Moving(this, Goal.transform.position);
            
        }
        public void TakeDamage(float amount)
        {
            CurrentHealth -= amount;
            Debug.Log("Il me reste" + CurrentHealth + "PV");

        }

        public void Die()
        {
            //Destroy(gameObject);
            Debug.Log("Eurgh");
        }

    }
}
