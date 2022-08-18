using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane
{
    public class EnemyPlaneView : BasePlaneView<IEnemyPlaneModel>
    {
        protected override void UpdateRenderModel(IEnemyPlaneModel model)
        {
            base.UpdateRenderModel(model);

            transform.name = $"Enemy [{model.X},{model.Y}]";
        }
    }
}