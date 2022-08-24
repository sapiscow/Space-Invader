using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, IEnemySpawnerModel, EnemySpawnerView>
    {
        public void SpawnGroupEnemies()
        {
            bool isOdd = _model.GridWidth % 2 == 1;
            float startColumn = -Mathf.Floor(_model.GridWidth / 2) + (isOdd ? 0 : 0.5f);
            float currentColumn = startColumn;

            for (int y = 0; y < _model.GridHeight; y++)
            {
                for (int x = 0; x < _model.GridWidth; x++)
                {
                    Vector2 spawnPosition = new Vector2(currentColumn++, y);
                    SpawnEnemyPlane(x, y, spawnPosition);
                }

                currentColumn = startColumn;
            }
        }

        public void SpawnEnemyPlane(int x, int y, Vector2 position)
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

            enemyPlane.SetGridPoint(x, y);
            enemyPlane.SetPosition(position);
            enemyPlane.SetViewActive(true);

            _model.SetSpawnedEnemyCount(_model.SpawnedEnemyCount + 1);
        }

        public void SetPauseState(bool isPaused)
            => _model.SetPauseState(isPaused);

        public void OnEnemyKilled()
        {
            _model.SetSpawnedEnemyCount(_model.SpawnedEnemyCount - 1);
            if (_model.SpawnedEnemyCount == 0)
            {
                Publish(new EnemiesClearedMessage());
            }
        }
    }
}