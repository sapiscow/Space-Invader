using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public interface IBulletModel : IBaseModel
    {
        bool IsFromAlly { get; }
        float Speed { get; }
        bool IsPaused { get; }
    }
}