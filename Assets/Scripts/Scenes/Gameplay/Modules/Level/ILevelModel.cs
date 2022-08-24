using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public interface ILevelModel : IBaseModel
    {
        bool IsPaused { get; }
    }
}