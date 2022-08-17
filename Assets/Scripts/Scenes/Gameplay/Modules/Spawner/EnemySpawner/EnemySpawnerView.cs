using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerView : BaseView
    {
        [Header("Prefab")]
        [SerializeField] private EnemyPlaneView _enemyPlanePrefab;

        public EnemyPlaneView InstantiateEnemyPlane()
            => Instantiate(_enemyPlanePrefab, transform);
    }
}