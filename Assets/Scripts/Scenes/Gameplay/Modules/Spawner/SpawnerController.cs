using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Bullet;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner
{
    public class SpawnerController : ObjectController<SpawnerController, SpawnerModel, SpawnerView>
    {
        public void SpawnPlayerPlane(int playerIndex)
        {
            PlayerPlaneController playerPlane = _model.GetPlayerPlane(playerIndex);
            if (playerPlane == null)
            {
                PlayerPlaneModel model = new PlayerPlaneModel();
                model.SetPlayerIndex(playerIndex);

                PlayerPlaneView view = _view.InstantiatePlayerPlane();
                
                playerPlane = new PlayerPlaneController();
                playerPlane.Init(model, view);

                _model.RegisterPlayerPlane(playerPlane);
            }

            playerPlane.SetViewActive(true);
        }

        public void SpawnBullet(Vector2 position, float speed)
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

            bullet.SetPosition(position);
            bullet.SetSpeed(speed);
            bullet.SetViewActive(true);
        }

        public void OnInputKeyPressed(int playerIndex, InputKey inputKey)
        {
            PlayerPlaneController playerPlane = _model.GetPlayerPlane(playerIndex);
            if (playerPlane != null)
            {
                playerPlane.OnInputKeyPressed(inputKey);
            }
        }
    }
}