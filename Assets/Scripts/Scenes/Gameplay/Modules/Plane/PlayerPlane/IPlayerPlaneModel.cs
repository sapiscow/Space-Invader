using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public interface IPlayerPlaneModel : IPlaneModel
    {
        int PlayerIndex { get; }
        public Color Color { get; }

        float MoveSpeed { get; }
    }
}