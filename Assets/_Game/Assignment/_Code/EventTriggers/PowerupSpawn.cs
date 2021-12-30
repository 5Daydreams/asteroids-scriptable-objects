using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assignment._Code.EventTriggers
{
    public class PowerupSpawn : MonoBehaviour
    {
        [Range(0, 1)] [SerializeField] private float _spawnChance;
        [SerializeField] private GameObject _powerupGameObject;
        
        public void TrySpawnPowerup()
        {
            float spawnValue = Random.Range(0.0f, 1.0f);

            if (spawnValue < _spawnChance)
            {
                SpawnPowerup();
            }
        }

        private void SpawnPowerup()
        {
            Instantiate(_powerupGameObject, this.transform.position, Quaternion.identity,null);
        }
    }
}