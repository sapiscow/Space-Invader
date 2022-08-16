using Agate.MVC.Base;

namespace Sapi.SpaceInvader.Gameplay.Bullet
{
    public class BulletModel : BaseModel, IBulletModel
    {
        public float Speed { get; private set; }

        public void SetSpeed(float speed)
        {
            Speed = speed;
            SetDataAsDirty();
        }
    }
}