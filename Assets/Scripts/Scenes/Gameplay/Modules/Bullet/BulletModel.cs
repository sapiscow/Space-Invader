using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public class BulletModel : BaseModel, IBulletModel
    {
        public bool IsFromAlly { get; private set; }
        public float Speed { get; private set; }
        public bool IsPaused { get; private set; }

        public void SetFromAllyState(bool isAlly)
        {
            IsFromAlly = isAlly;
            SetDataAsDirty();
        }

        public void SetSpeed(float speed)
        {
            Speed = speed;
            SetDataAsDirty();
        }

        public void SetPauseState(bool isPaused)
        {
            IsPaused = isPaused;
            SetDataAsDirty();
        }
    }
}