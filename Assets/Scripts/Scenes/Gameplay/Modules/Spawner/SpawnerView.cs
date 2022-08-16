using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner
{
    public class SpawnerView : BaseView
    {
        [Header("Prefab")]
        [SerializeField] private PlayerPlaneView _playerPlanePrefab;
        [SerializeField] private BulletView _bulletPrefab;

        [Header("Component")]
        [SerializeField] private Transform _playerParent;
        [SerializeField] private Transform _bulletParent;

        public PlayerPlaneView InstantiatePlayerPlane()
            => Instantiate(_playerPlanePrefab, _playerParent);

        public BulletView InstantiateBullet()
            => Instantiate(_bulletPrefab, _bulletParent);
    }
}