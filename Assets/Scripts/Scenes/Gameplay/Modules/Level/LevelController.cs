using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public class LevelController : DataController<LevelController, LevelModel>
    {
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
    }
}