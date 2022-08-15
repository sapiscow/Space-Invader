using Agate.MVC.Base;
using Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane;

namespace Sapi.SpaceInvader.Gameplay.Spawner
{
    public class SpawnerController : ObjectController<SpawnerController, SpawnerModel, SpawnerView>
    {
        public void SpawnPlayerPlane(int playerIndex)
        {
            PlayerPlaneController playerPlane = _model.GetPlayerPlane(playerIndex);
            if (playerPlane == null)
            {
                playerPlane = new PlayerPlaneController();
                PlayerPlaneModel model = new PlayerPlaneModel();
                model.SetPlayerIndex(playerIndex);
                PlayerPlaneView view = _view.InstantiatePlayerPlane();
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