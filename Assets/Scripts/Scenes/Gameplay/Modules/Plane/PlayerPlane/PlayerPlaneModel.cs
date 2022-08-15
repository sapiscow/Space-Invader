using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneModel : BasePlaneModel, IPlayerPlaneModel
    {
        public int PlayerIndex { get; private set; }

        public void SetPlayerIndex(int playerIndex)
        {
            PlayerIndex = playerIndex;
            SetDataAsDirty();
        }
    }
}