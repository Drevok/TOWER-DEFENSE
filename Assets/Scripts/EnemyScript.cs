using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemies
{
    public class EnemyScript : MonoBehaviour
    {
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
        }
    }
}
