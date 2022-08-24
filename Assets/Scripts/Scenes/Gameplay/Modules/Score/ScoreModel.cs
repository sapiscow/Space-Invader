using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Score
{
    public class ScoreModel : BaseModel, IScoreModel
    {
        public int Score { get; private set; }

        public void AddScore(int value) => SetScore(Score + value);

        public void SetScore(int score)
        {
            Score = score;
            SetDataAsDirty();
        }
    }
}