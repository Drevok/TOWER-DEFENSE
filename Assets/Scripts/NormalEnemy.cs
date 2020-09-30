using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy/Normal")]
    public class NormalEnemy : ENEMY
    {
        //public int MoveSpeed;
        //public int MaxHealth;
        //public float CurrentHealth;
         

        public override void Moving(EnemyScript enemyScript, Vector3 position) 
        {
            //enemyScript.NavMeshAgentspeed = Random.value * MoveSpeed;
            enemyScript.NavMeshAgent.SetDestination(position);
        }

        public override void TakeDamage(EnemyScript enemy)
        {
            
        }  
    }

    [CreateAssetMenu(fileName ="New Enemy", menuName = "Fast Enemy")]

    public class FastEnemy : ENEMY
    {
        public override void Moving(EnemyScript enemyScript, Vector3 position)
        {
            //enemyScript.NavMeshAgentspeed = Random.value * MoveSpeed;
            enemyScript.NavMeshAgent.SetDestination(position);
        }

        public override void TakeDamage(EnemyScript enemy)
        {

        }
    }
}
