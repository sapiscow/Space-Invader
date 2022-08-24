using Agate.MVC.Base;
using TMPro;

namespace Sapi.SpaceInvader.Gameplay.Score
{
    public class ScoreView : ObjectView<IScoreModel>
    {
        private TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        protected override void InitRenderModel(IScoreModel model) { }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            _scoreText.SetText("Score: " + model.Score);
        }
    }
}