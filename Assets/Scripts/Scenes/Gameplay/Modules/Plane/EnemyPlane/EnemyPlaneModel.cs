using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane
{
    public class EnemyPlaneModel : BasePlaneModel, IEnemyPlaneModel
    {
        private float _bulletSpeed;

        public override bool IsAlly => false;
        public override float BulletSpeed => _bulletSpeed;

        public void SetBulletSpeed(int bulletSpeed)
        {
            _bulletSpeed = bulletSpeed;
            SetDataAsDirty();
        }
    }
}