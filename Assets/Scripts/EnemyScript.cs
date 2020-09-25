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

        private void Update() {
            if (Input.GetButtonDown("Fire1"))
            {
                //RaycastHit hit;
                //Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
                //if (Physics.Raycast(ray, out hit))
                //{
                    testenemy.Moving(this, Goal.transform.position);
                //}
            }
        }
    }
}
