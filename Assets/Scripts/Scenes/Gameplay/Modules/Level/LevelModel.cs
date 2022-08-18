using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Level
{
    public class LevelModel : BaseModel
    {
        public int Level { get; private set; }
        public bool HasStarted { get; private set; }

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
    }
}