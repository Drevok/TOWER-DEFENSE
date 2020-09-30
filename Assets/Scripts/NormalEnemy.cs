using UnityEngine;

namespace Enemies
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy/Normal")]
    public class NormalEnemy : ENEMY
    {
        public override void Moving(EnemyScript enemyScript, Vector3 position) 
        {
            //enemyScript.NavMeshAgent.speed = Random.value * MoveSpeed;
            enemyScript.NavMeshAgent.SetDestination(position);
        }

    }
}
