using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner
{
    public class PlayerSpawnerController : ObjectController<PlayerSpawnerController, PlayerSpawnerModel, PlayerSpawnerView>
    {
        public void SpawnPlayerPlanes(int count)
        {
            count = Mathf.Min(count, _model.MaxPlayer);

            bool isOdd = count % 2 == 1;
            float startX = -Mathf.Floor(count / 2) + (isOdd ? 0 : 0.5f);
            float currentX = startX;

            for (int i = 0; i < count; i++)
            {
                SpawnPlayerPlane(i, currentX++ * 1.5f);
            }
        }

        private void SpawnPlayerPlane(int playerIndex, float spawnPositionX)
        {
            PlayerPlaneController playerPlane = _model.GetPlayerPlane(playerIndex);
            if (playerPlane == null)
            {
                PlayerPlaneModel model = new PlayerPlaneModel();
                model.SetPlayerIndex(playerIndex);

                PlayerPlaneView view = _view.InstantiatePlayerPlane();
                view.transform.localPosition = new Vector2(spawnPositionX, 0f);

                playerPlane = new PlayerPlaneController();
                playerPlane.Init(model, view);

                _model.RegisterPlayerPlane(playerPlane);
            }

            playerPlane.SetViewActive(true);
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