using App.Scripts.Core.CustomActionBase;
using UnityEngine;

namespace App.Scripts.Runtime.Modules
{
    public class ObjectSpawnerModule: ActionBase
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private GameObject[] _prefabPull;

        [SerializeField] private float _skipSpawnChance = 0.5f;
        
        protected override void ExecuteInternal()
        {
            SpawnRandomObjectFromPull();
        }

        private void SpawnRandomObjectFromPull()
        {
            if (_spawnPoint == null || _prefabPull.Length == 0)
            {
                Debug.LogError("Object Spawner | Spawn point empty or you are forgot add prefab pull");
                return;
            }

            if (Random.value < _skipSpawnChance)
            {
                return;
            }
            
            var randomIndex = Random.Range(0, _prefabPull.Length);
            var selectedObject = _prefabPull[randomIndex];

           Instantiate(selectedObject, _spawnPoint.position, Quaternion.identity, _spawnPoint);
        }
    }
}