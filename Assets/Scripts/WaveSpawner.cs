using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawner
{
    public class WaveSpawner : MonoBehaviour
    {
        public List<Transform> enemiesTypes = new List<Transform>();
        public Transform enemyPrefab;
        public Transform fastEnemy;
        public float timeBetweenWaves = 5f;
        private float countdown = 2f;
        public Transform spawnPoint;

        private int randomEnemy;

        private int waveIndex = 0;

        void Update ()
        {
            if (countdown <= 0f)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
                randomEnemy = Random.Range(0, enemiesTypes.Count);
            }

            countdown -= Time.deltaTime;
        }

        void Start ()
        {
            enemiesTypes.Add(enemyPrefab);
            enemiesTypes.Add(fastEnemy);
        }

        IEnumerator SpawnWave ()
        {
            waveIndex++;

            for (int i = 0; i < waveIndex; i++)
            {
                SpawnEnemy();
                
            yield return new WaitForSeconds(0.3f);
            }

        }

        void SpawnEnemy ()
        {
            Instantiate(enemiesTypes[randomEnemy], spawnPoint.position, spawnPoint.rotation);
        }
    }
}
