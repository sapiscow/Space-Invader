using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay
{
    public readonly struct ShootMessage
    {
        public Vector2 ShootPosition { get; }
        public bool IsFromAlly { get; }
        public float BulletSpeed { get; }

        public ShootMessage(Vector2 shootPosition, bool isFromAlly, float bulletSpeed)
        {
            ShootPosition = shootPosition;
            IsFromAlly = isFromAlly;
            BulletSpeed = bulletSpeed;
        }
    }
}