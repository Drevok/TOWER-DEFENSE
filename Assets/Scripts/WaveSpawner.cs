using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawner
{
    public class WaveSpawner : MonoBehaviour
    {
        public Transform enemyPrefab;
        public float timeBetweenWaves = 5f;
        private float countdown = 2f;

        private int waveNumber = 1;

        void Update ()
        {
            if (countdown <= 0f)
            {
                SpawnWave();
                countdown = timeBetweenWaves;
            }

            countdown -= Time.deltaTime;
        }

        void SpawnWave ()
        {
            waveNumber
        }
    }
}
