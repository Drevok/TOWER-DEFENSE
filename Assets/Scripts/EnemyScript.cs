using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class EnemyScript : MonoBehaviour
    {

        public float CurrentHealth;

        public ENEMY testenemy;
        public GameObject Goal;
        //public Camera Camera;
        [HideInInspector] public NavMeshAgent NavMeshAgent;

        private void Awake()
        {
            NavMeshAgent = GetComponent<NavMeshAgent>();
            NavMeshAgent.speed = testenemy.MoveSpeed;
            
        }

        private void Start() 
        {
            testenemy.Moving(this, Goal.transform.position);
            CurrentHealth = testenemy.MaxHealth;
            Debug.Log("Il me reste" + CurrentHealth + "PV");
        }
        public void TakeDamage(float amount)
        {
            CurrentHealth -= amount;
            Debug.Log("Il me reste" + CurrentHealth + "PV");
            if (CurrentHealth <= 0)
                Die();

        }

        public void Die()
        {
            //Destroy(gameObject);
            Debug.Log("Eurgh");
        }

    }
}
