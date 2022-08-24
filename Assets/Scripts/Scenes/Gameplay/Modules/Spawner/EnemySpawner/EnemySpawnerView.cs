using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.EnemySpawner
{
    public class EnemySpawnerView : ObjectView<IEnemySpawnerModel>
    {
        private const float _sideBound = 3f;

        [Header("Prefab")]
        [SerializeField] private EnemyPlaneView _enemyPlanePrefab;

        private int _direction;

        protected override void InitRenderModel(IEnemySpawnerModel model) { }

        protected override void UpdateRenderModel(IEnemySpawnerModel model) { }

        private void Awake()
        {
            _direction = Random.value > 0.5f ? 1 : -1;
        }

        private void Update()
        {
            if (_model == null || _model.IsPaused)
            {
                return;
            }

            if ((_direction > 0 && transform.position.x > _sideBound) ||
                _direction < 0 && transform.position.x < -_sideBound)
            {
                _direction *= -1;
            }

            transform.Translate(_direction * _model.MoveSpeed * Time.deltaTime, 0f, 0f);
        }

        public EnemyPlaneView InstantiateEnemyPlane()
            => Instantiate(_enemyPlanePrefab, transform);
    }
}