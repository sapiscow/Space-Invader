using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;

namespace Sapi.SpaceInvader.Gameplay.Spawner.PlayerSpawner
{
    public class PlayerSpawnerController : ObjectController<PlayerSpawnerController, PlayerSpawnerModel, PlayerSpawnerView>
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