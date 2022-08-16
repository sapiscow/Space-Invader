using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct ShootMessage
    {
        public Vector2 ShootPosition { get; }
        public float BulletSpeed { get; }

        public ShootMessage(Vector2 shootPosition, float bulletSpeed)
        {
            ShootPosition = shootPosition;
            BulletSpeed = bulletSpeed;
        }
    }
}