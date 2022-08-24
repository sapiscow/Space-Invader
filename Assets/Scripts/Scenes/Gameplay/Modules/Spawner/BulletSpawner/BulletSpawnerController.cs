using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.BulletSpawner
{
    public class BulletSpawnerController : ObjectController<BulletSpawnerController, BulletSpawnerModel, BulletSpawnerView>
    {
        public void SpawnBullet(Vector2 position, bool isAlly, float speed)
        {
            BulletController bullet = _model.GetBulletFromPool();
            if (bullet == null)
            {
                BulletModel model = new BulletModel();
                BulletView view = _view.InstantiateBullet();
                bullet = new BulletController();
                bullet.Init(model, view);

                _model.AddBulletToPool(bullet);
            }

            bullet.Spawn(position, isAlly, speed);
            bullet.SetViewActive(true);
        }

        public void SetBulletsPauseState(bool isPaused)
        {
            foreach (var bullet in _model.Bullets)
            {
                bullet.SetPauseState(isPaused);
            }
        }
    }
}