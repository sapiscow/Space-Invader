using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public class LevelController : ObjectController<LevelController, LevelModel, ILevelModel, LevelView>
    {
        public bool IsPaused => _model.IsPaused;

        public override void SetView(LevelView view)
        {
            base.SetView(view);
            _view.SetPauseButton(TogglePause);
        }

        public void StartLevel()
        {
            _model.StartLevel();
            Publish(new LevelStartedMessage(_model.Level));
        }

        public void FinishLevel()
        {
            _model.FinishLevel();
            Publish(new LevelFinishedMessage(_model.Level));

            // Temporary Code, to make it endless
            StartLevel();
        }

        public void TogglePause()
        {
            _model.TogglePause();
            Publish(new LevelPausedMessage(_model.IsPaused));
        }
    }
}