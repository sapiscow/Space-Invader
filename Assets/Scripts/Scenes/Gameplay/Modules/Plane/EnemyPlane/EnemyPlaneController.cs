using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;
using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane
{
    public class EnemyPlaneController : BasePlaneController<EnemyPlaneController, EnemyPlaneModel, IEnemyPlaneModel, EnemyPlaneView>
    {
        public int ScoreValue => _model.ScoreValue;

        public void SetGridPoint(int x, int y)
            => _model.SetGridPoint(x, y);

        public void SetPosition(Vector2 position)
            => _view.transform.position = position;

        public override void OnShooted()
        {
            base.OnShooted();

            if (!IsViewActive)
            {
                Publish(new EnemyKilledMessage(_model.X, _model.Y, _model.ScoreValue));
            }
        }
    }
}