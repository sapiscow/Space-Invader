using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneView : BasePlaneView<IPlayerPlaneModel>
    {
        public void Move(int directionX)
        {
            transform.Translate(directionX * _moveSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}