using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public class LevelModel : BaseModel, ILevelModel
    {
        public int Level { get; private set; }
        public bool HasStarted { get; private set; }
        public bool IsPaused { get; private set; }

        public void StartLevel()
        {
            Level++;
            HasStarted = true;
            SetDataAsDirty();
        }

        public void FinishLevel()
        {
            HasStarted = false;
            SetDataAsDirty();
        }

        public void TogglePause()
        {
            IsPaused = !IsPaused;
            SetDataAsDirty();
        }
    }
}