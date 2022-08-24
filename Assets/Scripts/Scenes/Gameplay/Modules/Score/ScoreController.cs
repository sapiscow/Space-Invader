using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Score
{
    public class ScoreController : ObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
        public void AddScore(int value) => _model.AddScore(value);
    }
}