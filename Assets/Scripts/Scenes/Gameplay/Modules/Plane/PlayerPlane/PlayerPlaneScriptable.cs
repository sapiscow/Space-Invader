using UnityEngine;

namespace Sapi.SpaceInvader.Gameplay.Plane
{
    [CreateAssetMenu]
    public class PlayerPlaneScriptable : ScriptableObject
    {
        [SerializeField] private float _moveSpeed = 4f;
        [SerializeField] private float _bulletSpeed = 8f;
        [SerializeField] private Color[] _planeColors;

        public float MoveSpeed => _moveSpeed;
        public float BulletSpeed => _bulletSpeed;
        public Color[] PlaneColors => _planeColors;
    }
}