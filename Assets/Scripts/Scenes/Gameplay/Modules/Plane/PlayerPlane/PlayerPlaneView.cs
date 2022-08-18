using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneView : BasePlaneView<IPlayerPlaneModel>
    {
        public void Move(int directionX)
        {
            transform.Translate(directionX * _model.MoveSpeed * Time.deltaTime, 0f, 0f);
        }

        protected override void InitRenderModel(IPlayerPlaneModel model)
        {
            _renderer.color = _model.Color;

            transform.name = $"Player {model.PlayerIndex}";
        }
    }
}