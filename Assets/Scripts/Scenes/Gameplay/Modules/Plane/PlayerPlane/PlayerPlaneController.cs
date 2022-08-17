using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneController : BasePlaneController<PlayerPlaneController, PlayerPlaneModel, IPlayerPlaneModel, PlayerPlaneView>
    {
        public int PlayerIndex => _model.PlayerIndex;

        public void OnInputKeyPressed(InputKey inputKey)
        {
            switch (inputKey)
            {
                case InputKey.Left: _view.Move(-1); break;
                case InputKey.Right: _view.Move(1); break;
                case InputKey.Shoot: Shoot(); break;
            }
        }
    }
}