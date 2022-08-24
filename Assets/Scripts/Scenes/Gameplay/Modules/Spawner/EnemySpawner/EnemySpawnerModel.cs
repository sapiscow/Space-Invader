using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;
using System.Collections.Generic;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerModel : BaseModel, IEnemySpawnerModel
    {
        private const string _enemySpawnerConfigPath = "Spawner/EnemySpawnerScriptable";

        private EnemySpawnerScriptable _enemySpawnerConfig;
        private List<EnemyPlaneController> _enemyPool = new List<EnemyPlaneController>();
        private int _spawnedEnemyCount;

        public bool IsPaused { get; private set; }

        public int GridWidth => _enemySpawnerConfig.Width;
        public int GridHeight => _enemySpawnerConfig.Height;
        public int SpawnedEnemyCount => _spawnedEnemyCount;
        public float MoveSpeed => _enemySpawnerConfig.MoveSpeed;

        public EnemySpawnerModel()
        {
            _enemySpawnerConfig = Resources.Load<EnemySpawnerScriptable>(_enemySpawnerConfigPath);
        }

        public void AddEnemyToPool(EnemyPlaneController enemy)
            => _enemyPool.Add(enemy);

        public EnemyPlaneController GetEnemyFromPool()
            => _enemyPool.Find(e => !e.IsViewActive);

        public void SetSpawnedEnemyCount(int count)
            => _spawnedEnemyCount = count;

        public void SetPauseState(bool isPaused)
        {
            IsPaused = isPaused;
            SetDataAsDirty();
        }
    }
}