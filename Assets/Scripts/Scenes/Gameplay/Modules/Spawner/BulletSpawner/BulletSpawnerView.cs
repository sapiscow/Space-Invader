using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner
{
    public class BulletSpawnerView : BaseView
    {
        [Header("Prefab")]
        [SerializeField] private BulletView _bulletPrefab;

        public BulletView InstantiateBullet()
            => Instantiate(_bulletPrefab, transform);
    }
}