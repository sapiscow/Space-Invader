using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Plane.BasePlane
{
    public abstract class BasePlaneModel : BaseModel, IPlaneModel
    {
        public abstract bool IsAlly { get; }
        public abstract float BulletSpeed { get; }
    }
}