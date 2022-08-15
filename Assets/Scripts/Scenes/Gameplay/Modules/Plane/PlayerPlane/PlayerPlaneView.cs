using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.PlayerPlane
{
    public class PlayerPlaneView : BasePlaneView<IPlayerPlaneModel>
    {
        [SerializeField] protected float _moveSpeed = 4f;
        [SerializeField] protected Color[] _planeColors;

        public void Move(int directionX)
        {
            transform.Translate(directionX * _moveSpeed * Time.deltaTime, 0f, 0f);
        }

        protected override void InitRenderModel(IPlayerPlaneModel model)
        {
            _renderer.color = _planeColors[model.PlayerIndex];
        }
    }
}