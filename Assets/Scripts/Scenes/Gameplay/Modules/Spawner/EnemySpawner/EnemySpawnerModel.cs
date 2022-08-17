using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;
using System.Collections.Generic;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerModel : BaseModel
    {
        private List<EnemyPlaneController> _enemyPool = new List<EnemyPlaneController>();

        public void AddEnemyToPool(EnemyPlaneController enemy)
            => _enemyPool.Add(enemy);

        public EnemyPlaneController GetEnemyFromPool()
            => _enemyPool.Find(e => !e.IsViewActive);
    }
}