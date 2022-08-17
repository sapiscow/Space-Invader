using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public interface IPlaneModel : IBaseModel
    {
        bool IsAlly { get; }
        float BulletSpeed { get; }
    }
}