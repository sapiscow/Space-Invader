using Sapi.SpaceInvader.Gameplay.Plane.BasePlane;

namespace Sapi.SpaceInvader.Gameplay.Plane.EnemyPlane
{
    public class EnemyPlaneModel : BasePlaneModel, IEnemyPlaneModel
    {
        private float _bulletSpeed;

        public int X { get; private set; }
        public int Y { get; private set; }
        public int ScoreValue { get; private set; } = 5;

        public override bool IsAlly => false;
        public override float BulletSpeed => _bulletSpeed;

        public void SetGridPoint(int x, int y)
        {
            X = x;
            Y = y;
            SetDataAsDirty();
        }

        public void SetBulletSpeed(int bulletSpeed)
        {
            _bulletSpeed = bulletSpeed;
            SetDataAsDirty();
        }
    }
}