using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane
{
    public interface IEnemyPlaneModel : IPlaneModel
    {
        int X { get; }
        int Y { get; }
        int ScoreValue { get; }
    }
}