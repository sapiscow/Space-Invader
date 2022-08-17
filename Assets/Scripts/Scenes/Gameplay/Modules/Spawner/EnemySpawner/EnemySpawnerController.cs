using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, EnemySpawnerView>
    {
        public void SpawnEnemyPlane()
        {
            EnemyPlaneController enemyPlane = _model.GetEnemyFromPool();
            if (enemyPlane == null)
            {
                EnemyPlaneModel model = new EnemyPlaneModel();
                EnemyPlaneView view = _view.InstantiateEnemyPlane();
                enemyPlane = new EnemyPlaneController();
                enemyPlane.Init(model, view);
                _model.AddEnemyToPool(enemyPlane);
            }

            enemyPlane.SetViewActive(true);
        }
    }
}