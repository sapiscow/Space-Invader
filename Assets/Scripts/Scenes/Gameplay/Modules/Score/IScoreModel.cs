using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Score
{
    public interface IScoreModel : IBaseModel
    {
        int Score { get; }
    }
}