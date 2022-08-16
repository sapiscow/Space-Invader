using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public interface IBulletModel : IBaseModel
    {
        float Speed { get; }
    }
}