using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using System.Collections.Generic;

namespace Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner
{
    public class BulletSpawnerModel : BaseModel
    {
        private List<BulletController> _bulletPool = new List<BulletController>();

        public void AddBulletToPool(BulletController bullet)
            => _bulletPool.Add(bullet);

        public BulletController GetBulletFromPool()
            => _bulletPool.Find(b => !b.IsViewActive);
    }
}